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
    public partial class receptlogin : UserControl
    {
        public receptlogin()
        {
            InitializeComponent();
        }

        private void repsub_Click(object sender, EventArgs e)
        {
            if (repsub != null)
            {
                this.Hide();

                Form3 ff3 = new Form3();
                ff3.Show();

                String username, password;

                

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


                try
                {
                    String querry = "SELECT * FROM ReceptionistDetails WHERE UserName = '" + rece.Text + "' AND Password = '" + pass.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = rece.Text;
                        password = pass.Text;

                        //page that needed to be load next
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rece.Clear();
                        pass.Clear();

                        //to focus username
                        rece.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    con.Close();
                }




            }
        }

        private void adlogclear_Click(object sender, EventArgs e)
        {

            rece.Clear();
            pass.Clear();

            rece.Focus();
        }
    }
}
