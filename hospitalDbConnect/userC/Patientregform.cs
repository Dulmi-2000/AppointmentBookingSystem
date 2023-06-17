using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalDbConnect.userC
{
    public partial class Patientregform : UserControl
    {
        public Patientregform()
        {
            InitializeComponent();
        }




        //create variable for patient id
        public int Patient_id;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");




        private void prcancel_Click(object sender, EventArgs e)
        {
            pr1.Clear();
            pr2.Clear();
            pr3.Clear();
        }






        private bool IsValid()
        {
            if (pr1.Text == string.Empty)
            {
                MessageBox.Show("Patient name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }




        private void Appsubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

            
                String  Patient_Name,Patient_Age,Appointment_Date,Contact_Number,Gender,Doctor_Name ;


                try
                {
                    String querry = "INSERT INTO PatientsDB(Patient_Name,Patient_Age,Appointment_Date,Contact_Number,Gender,Doctor_Name) VALUES('" + pr1.Text + "','" + pr2.Text + "','" + APPdate.Text + "','" + pr3.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "')";

                    
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                  if (dt.Rows.Count > 0)
                {
                    Patient_Name = pr1.Text;
                    Patient_Age = pr2.Text;
                    Appointment_Date = APPdate.Text;
                    Contact_Number = pr3.Text;
                    Gender = comboBox2.Text;
                    Doctor_Name = comboBox1.Text;

                    MessageBox.Show("successfully registered", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

               /* else
                {
                    MessageBox.Show("Invalid");
                }*/
                
                }
                catch
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    con.Close();
                }









            /*   try
               {


                   if (IsValid1())
                   {
                       SqlCommand cmd = new SqlCommand("INSERT INTO PatientsDB VALUES (@Patient_Name, @Patient_Age, @Appoinment_Date, @Contact_Number, @Gender, @Doctor_name)", con);
                       cmd.CommandType = CommandType.Text;
                       cmd.Parameters.AddWithValue("@Patient_Name", pr1.Text);
                       cmd.Parameters.AddWithValue("@Patient_Age", pr2.Text);
                       cmd.Parameters.AddWithValue("@Appoinment_Date", APPdate.Value);
                       cmd.Parameters.AddWithValue("@Contact_Number", pr3.Text);
                       cmd.Parameters.AddWithValue("@Doctor_name", comboBox1.Text);
                       string gender;
                            if (maleRadioBttn.Checked == true)
                             {
                                 gender = "Male";
                             }
                             else
                             {
                                 gender = "Female";
                             }
                       cmd.Parameters.AddWithValue("@Gender", maleRadioBttn);

                       con.Open();
                       cmd.ExecuteNonQuery();
                       con.Close();

                       MessageBox.Show("successfully registered", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   }


               }
               catch { 
               }
               finally
               {
                   con.Close();
               }


   }

           private bool IsValid1()
           {
               if (pr1.Text == string.Empty)
               {
                   MessageBox.Show("Patient name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
               return true;*/




        }





        }
}
