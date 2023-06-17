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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospitalDbConnect.userC
{
    public partial class UserControlAPPOINTMENT : UserControl
    {
        public UserControlAPPOINTMENT()
        {
            InitializeComponent();
        }


        //databse connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


        private void APPrequestNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void baclear_Click(object sender, EventArgs e)
        {
            if (baclear != null)
            {
                ba1.Clear();
                ba2.Clear();
                ba3.Clear();
            }
        }


        //pass data to database
        private void Appsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

     
                String Date, AppointmentNo, DoctorIDName, PatientRegNo, PatientName, Payment;




                try
                {
                    string querry = "INSERT INTO AppointmentsDB(Date,AppointmentNo,DoctorIDName,PatientRegNo,PatientName,Payment) VALUES('" + APPdate.Text + "','" + ba3.Text + "','" + APPdoc.Text + "','" + ba2.Text + "','" + ba1.Text + "','" + comboBox1.Text + "')";

                    //String querry = "SELECT *FROM patientDb";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Date = APPdate.Text;
                        AppointmentNo = ba3.Text;
                        DoctorIDName = APPdoc.Text;
                        PatientRegNo = ba2.Text;
                        PatientName = ba1.Text;
                        Payment = comboBox1.Text;

                    MessageBox.Show("successfully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    else
                    {
                        MessageBox.Show("Invalid");
                    }

                }
                catch
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    con.Close();
                }


            //

            }
        }
}
