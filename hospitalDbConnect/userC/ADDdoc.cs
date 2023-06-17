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

namespace hospitalDbConnect.userC
{
    public partial class ADDdoc : UserControl
    {
        public ADDdoc()
        {
            InitializeComponent();
        }

        private void APPcancel_Click(object sender, EventArgs e)
        {
            if (docclear != null)
            {
                RDTEXT5.Clear();
                RDTEXT1.Clear();
                RDTEXT2.Clear();
                RDTEXT3.Clear();
                RDTEXT4.Clear();
                RDTEXT6.Clear();

            }
        }

        private void Appsubmit_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

            
                String Name,Specification,Address,Age,Gender,RegisteredDate,ContactNo,Email;
            Name = RDTEXT1.Text;
            Specification = RDTEXT2.Text;
            Address = RDTEXT3.Text;
            Age = RDTEXT4.Text;
            Gender = Dgender.Text;
            RegisteredDate = APPdate.Text;
            ContactNo = RDTEXT5.Text;
            Email = RDTEXT6.Text;


            //send doc details to doctor database
            try
                {
                    string querry = "INSERT INTO DoctorDetailsDB(DotorName,Specialization,Address,Age,Gender,RegisterdDate,ContactNo,Email) VALUES('" + Name + "','" + Specification + "','" + Address + "','" + Age + "','" + Gender + "','" + RegisteredDate + "','"+ContactNo+"','"+Email+"')";

                    //String querry = "SELECT *FROM patientDb";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {

                        Name=RDTEXT1.Text;
                    Specification = RDTEXT2.Text;
                    Address = RDTEXT3.Text;
                        Age=RDTEXT4.Text;
                        Gender=Dgender.Text;
                    RegisteredDate = APPdate.Text;
                        ContactNo=RDTEXT5.Text;
                        Email=RDTEXT6.Text;

                    MessageBox.Show("successfully registered", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                    else
                    {
                        MessageBox.Show("Invalid");
                    }

                }
                catch
                {
                //MessageBox.Show("error");
            }
                finally
                {
                    con.Close();
                }


            }
        }
}
