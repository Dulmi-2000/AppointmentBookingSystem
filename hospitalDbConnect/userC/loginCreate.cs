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
    public partial class loginCreate : UserControl
    {
        public loginCreate()
        {
            InitializeComponent();
        }

        private void prcancel_Click(object sender, EventArgs e)
        {
            if (prcancel != null)
            {
                pr1.Clear();
                pr2.Clear();
            }
        }

        private void Appsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            String UName, pass;
            UName = pr1.Text;
            pass = pr2.Text;


            try
            {
                con.Open();
                string querry = "INSERT INTO FROM ReceptionistDetails (UserName,Password) VALUES('" + UName + "','" + pass + "')";

                //String querry = "SELECT *FROM patientDb";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    UName = pr1.Text;
                    pass = pr2.Text;


                    MessageBox.Show("successfully registered", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid");
                }

            }
            catch
            {
                // MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
