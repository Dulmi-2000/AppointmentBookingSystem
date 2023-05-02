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

        private void doctorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBttn_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO patient_Details VALUES (@Patient_Name, @Patient_Age, @Appoinment_date, @Contact_Number, @Gender, @Doctor_name)", con);
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
            
            SqlCommand cmd = new SqlCommand("Select * from patient_Details", con);
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
            patientNameTextBox.Clear();
            patientAgeTextBox.Clear();
            contactNumberTextBox.Clear();
            doctorNameTextBox.Clear();
            maleRadioBttn.Checked = false;
            femaleRadioBttn.Checked = false;
            appointmentDateTimePicker.Value = DateTime.Now;//Sets the appointmentDateTimePicker value to the current date and time

            patientNameTextBox.Focus();

        }
    }
}
