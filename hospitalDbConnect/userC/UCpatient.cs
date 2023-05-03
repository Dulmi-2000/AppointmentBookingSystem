using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hospitalDbConnect
{
    public partial class UCpatient : UserControl
    {
        public UCpatient()
        {
            InitializeComponent();
        }

        //aishu database connection
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-06H4HJ9G;Initial Catalog=patientregisterdb;Integrated Security=True");

        //create variable for patient id
        public int Patient_id;


        private void doctorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBttn_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO patient_tb VALUES (@Patient_Name, @Patient_Age, @Appoinment_date, @Contact_Number, @Gender, @Doctor_name)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Patient_Name", patientNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", patientAgeTextBox.Text);
                cmd.Parameters.AddWithValue("@Appoinment_date", appointmentDateTimePicker.Value);
                cmd.Parameters.AddWithValue("@Contact_Number", contactNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@Doctor_name", doctorNameTextBox.Text);
                string gender;
                if(maleRadioBttn.Checked== true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                cmd.Parameters.AddWithValue("@Gender", gender);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("successfully registered", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPatientsRecord();
                ClearFormControls();

            }
        }

        private bool IsValid() 
        {
            if(patientNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Patient name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UCpatient_Load(object sender, EventArgs e)
        {
            //patient record tika table ekata gann methode eka
            GetPatientsRecord();
        }

        private void GetPatientsRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from patient_tb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            patientRecordDataGridView.DataSource = dt;
           
        }

        private void clearBttn_Click(object sender, EventArgs e)
        {
            ClearFormControls();

        }

        private void ClearFormControls()
        {
            Patient_id = 0;
            patientNameTextBox.Clear();
            patientAgeTextBox.Clear();
            contactNumberTextBox.Clear();
            doctorNameTextBox.Clear();
            maleRadioBttn.Checked = false;
            femaleRadioBttn.Checked = false;
            appointmentDateTimePicker.Value = DateTime.Now;//Sets the appointmentDateTimePicker value to the current date and time

            patientNameTextBox.Focus();

        }

        private void patientRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Patient_id = Convert.ToInt32(patientRecordDataGridView.SelectedRows[0].Cells[0].Value);
            patientNameTextBox.Text = patientRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            patientAgeTextBox.Text = patientRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            appointmentDateTimePicker.Value = Convert.ToDateTime(patientRecordDataGridView.SelectedRows[0].Cells[3].Value);
            contactNumberTextBox.Text = patientRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            string gender = patientRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            if (gender == "Male")
            {
                maleRadioBttn.Checked = true;
                femaleRadioBttn.Checked = false;
            }
            else if (gender == "Female")
            {
                maleRadioBttn.Checked = false;
                femaleRadioBttn.Checked = true;
            }
            doctorNameTextBox.Text = patientRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void updateBttn_Click(object sender, EventArgs e)
        {
            if(Patient_id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE patient_tb SET Patient_Name = @Patient_Name, Patient_Age= @Patient_Age, Appoinment_date= @Appoinment_date, Contact_Number = @Contact_Number, Gender = @Gender, Doctor_name = @Doctor_name WHERE Patient_ID = @Patient_ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Patient_Name", patientNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", patientAgeTextBox.Text);
                cmd.Parameters.AddWithValue("@Appoinment_date", appointmentDateTimePicker.Value);
                cmd.Parameters.AddWithValue("@Contact_Number", contactNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@Doctor_name", doctorNameTextBox.Text);
                string gender;
                if (maleRadioBttn.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Patient_ID", this.Patient_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPatientsRecord();
                ClearFormControls();
            }
            else
            {
                MessageBox.Show("Please select a patient to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            if (Patient_id > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM patient_tb WHERE Patient_ID = @Patient_ID", con);
                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.AddWithValue("@Patient_ID", this.Patient_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("patient is deleted from the system", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPatientsRecord();
                ClearFormControls();
                Patient_id = 0;
            }
            else
            { 
                MessageBox.Show("Please select a patient to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void patientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void doctorNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
