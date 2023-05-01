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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

        private void Appsubmit_Click(object sender, EventArgs e)
        {
            String Date, AppointmentNo, DoctorIDName, PatientRegNo, PatientName,Payment;




            try
            {
                String querry = "INSERT INTO Appointments(Date,AppointmentNo,DoctorIDName,PatientRegNo,PatientName,Payment) VALUES('" + APPdate.Text + "','" + APPnumber.Text + "','"+ APPdoc.Text + "','"+ APPrequestNO.Text + "','"+ APPname.Text + "','"+ APPpay.Text + "')";

                //String querry = "SELECT *FROM patientDb";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Date = APPdate.Text;
                    AppointmentNo = APPname.Text;
                    DoctorIDName = APPdoc.Text;
                    PatientRegNo = APPrequestNO.Text;
                    PatientName = APPname.Text;
                    Payment = APPpay.Text;

                    
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
        }
    }
}
