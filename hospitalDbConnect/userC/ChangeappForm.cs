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

namespace hospitalDbConnect.userC
{
    public partial class ChangeappForm : UserControl
    {
        public ChangeappForm()
        {
            InitializeComponent();
        }

        private void APPcancel_Click(object sender, EventArgs e)
        {
            if (APPcancel != null)
            {
                AppName.Clear();
                da2.Clear();    
                
                da4.Clear();
                
            }
        }


        private void GetAppointmentRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("Select * from AppointmentsDB", con);
            DataTable dt=new DataTable();

            con.Open(); 
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            patientRecordDataGridView.DataSource = dt;  
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

                cmd.Parameters.AddWithValue("@Patient_Name", AppName.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", da2.Text);
                cmd.Parameters.AddWithValue("@Appoinment_date", APPdate.Value);
                cmd.Parameters.AddWithValue("@Contact_Number", da3.Text);
                cmd.Parameters.AddWithValue("@Gender", da4.Text);
                cmd.Parameters.AddWithValue("@Doctor_name", da5.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("successfully Changed", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            SqlCommand cmd = new SqlCommand("DELETE FROM AppointmentsDB WHERE PatientRegNo = @Patient_ID", con);
                    cmd.CommandType = CommandType.Text;
            /*
                    cmd.Parameters.AddWithValue("@Patient_ID", this.Patient_id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("patient is deleted from the system", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPatientsRecord();
                    ClearFormControls();
                    Patient_id = 0;
                
              */

            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            GetAppointmentRecord();
        }

        private void Deletepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //appID_id = Convert.ToInt32(patientRecordDataGridView.SelectedRows[0].Cells[0].Value);
            AppName.Text = patientRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            da2.Text = patientRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            APPdate.Value = Convert.ToDateTime(patientRecordDataGridView.SelectedRows[0].Cells[3].Value);
            da3.Text = patientRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            da4.Text = patientRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            da5.Text = patientRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();

            con.Open();

            GetAppointmentRecord();


            
        }

        private void Display_Click(object sender, EventArgs e)
        {
      /*      if(IsValid)
            {
                SqlCommand cmd = new SqlCommand("");
            }
        }
        private bool IsValid()
        {
            if(AppName.Text==string.Empty)
            {
                MessageBox.Show("Patient Registration number is required");
                return false;
            }
            return true;    */
        }
    }
}
