using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospitalDbConnect.userC
{
    public partial class Register : UserControl
    {
        private const string V = "@Patint_ID,int.PArse()";
        public int Patient_id;

        public Register()
        {
            InitializeComponent();
        }

        private void APPname_TextChanged(object sender, EventArgs e)
        {

        }

        private void APPdoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void APPdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdcancel_Click(object sender, EventArgs e)
        {
            if (rdcancel != null)
            {
                rd1.Clear();
                rd2.Clear();
                rd3.Clear();
            }
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            


          //  String Patient_Name, Patient_Age, Appointment_date, Contact_Number, Gender, Doctor_name;
            try
            {
                /*    String querry = "UPDATE PatientsDB SET Patient_Name='"+rd1.Text+"',Patient_Age='"+rd2.Text+"',Appointment_Date='"+APPdate.Text+"',Contact_Number='"+rd3.Text+"',Gender='"+gender.Text+"',Doctor_Name='"+APPdoc.Text+"' WHERE='"+rd1.Text+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                */


                SqlCommand cmd = new SqlCommand("UPDATE PatientsDB SET Patient_Name = @Patient_Name , Patient_Age = Patient_Age, Appointment_Date = @Appointment_Date, Contact_Number = @Contact_Number, Gender =@Gender, Doctor_Name = @Doctor_Name WHERE Patient_ID = @Patient_ID",con);
                    //SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Patient_Name", rd1.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", rd2.Text);
                cmd.Parameters.AddWithValue("@Appoinment_date", APPdate.Value);
                cmd.Parameters.AddWithValue("@Contact_Number", rd3.Text);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.Parameters.AddWithValue("@Doctor_name", APPdoc.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("successfully Changed", "changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

            if (Patient_id > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM patient_tb WHERE PatientsDB = @Patient_ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Patient_ID", this.Patient_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("patient is deleted from the system", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetPatientRecord();
                ClearFormControls();
                Patient_id = 0;
            }
            else
            {
                MessageBox.Show("Please select a patient to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        private void ClearFormControls()
        {
            Patient_id = 0;

            rd2.Clear();
            APPdate.Text = string.Empty;    
            rd3.Clear();
            gender.Text = string.Empty;
            APPdate.Value = DateTime.Now;//Sets the appointmentDateTimePicker value to the current date and time

            rd1.Focus();

        }

        private void patientRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
               Patient_id = Convert.ToInt32(patientRecordDataGridView.SelectedRows[0].Cells[0].Value);
                rd1.Text = patientRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                rd2.Text = patientRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                APPdate.Value = Convert.ToDateTime(patientRecordDataGridView.SelectedRows[0].Cells[3].Value);
                rd3.Text = patientRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                gender.Text = patientRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();

                APPdoc.Text = patientRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            con.Open();

            GetPatientRecord();

            
            ClearFormControls();    
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
           
            
            

        }



        private void GetPatientRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("Select * from PatientsDB", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            patientRecordDataGridView.DataSource = dt;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GetPatientRecord();
        }

        private void rd1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open(); 

            SqlCommand cmd = new SqlCommand("Select Patient_ID,Patient_Name,Patient_Age,Appointment_Date,Contact_Number,Doctor_name from PatientsDB where Patient_ID=@Patients_ID", con);
            cmd.Parameters.AddWithValue("@Patient_ID",int.Parse(rd1.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rd2.Text = dash.getValue(0).ToString();
                APPdate.Text = dash.getValue(1).ToString();
                rd3.Text = dash.getValue(2).ToString(); 
                gender.Text = dash.getValue(3). ToString();
                APPdoc.Text = dash.getValue(4).ToString();  

            }
            DataTable dt = new DataTable();

        }
    }
}
