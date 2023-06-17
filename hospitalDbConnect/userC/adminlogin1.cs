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
    public partial class adminlogin1 : UserControl
    {
        public adminlogin1()
        {
            InitializeComponent();
        }

        private void adlogclear_Click(object sender, EventArgs e)
        {
            if (adlogclear != null)
            {
                aduser.Clear();
                adpass.Clear();
            }

            aduser.Clear();
            adpass.Clear();

            aduser.Focus();
        }

        private void Appsubmit_Click(object sender, EventArgs e)
        {
            if (ADMINsubmit != null)
            {
                this.Hide();

                Form1 ff1 = new Form1();
                ff1.Show();
            }
            String username, password;

            username = aduser.Text;
            password = adpass.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

            try
            {
                String querry = "SELECT * AdminLoginDB WHERE UserName = '" + username + "' AND Password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = aduser.Text;
                    password = adpass.Text;

                    //page that needed to be load next
                    Form1 form2 = new Form1();
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    aduser.Clear();
                    adpass.Clear();

                    //to focus username
                    aduser.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
