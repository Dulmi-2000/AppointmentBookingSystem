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
    public partial class availableDoc : UserControl
    {
        public availableDoc()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Appsubmit_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //databse connection link
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Appsubmit_Click_1(object sender, EventArgs e)
        {
            if(docavailBUTOON != null)
            {
                panel4.Visible = true;
            }


            //database connection
            //appointment booking 
            try
            {
                con.Open();

                string querry = "SELECT COUNT(*) FROM AppointmentsDB WHERE DoctorName='" + txtDoc.Text + "' AND Date='" + Appdate.Text + "' ";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
               // MessageBox.Show("The number of rows in the table is " + count);

                PatientCount.Text=count.ToString(); 
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }




    private void appgobutton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(PatientCount.Text);
            if (a < 26)
            {
                UserControlAPPOINTMENT aaPP = new UserControlAPPOINTMENT();
                addUserControl(aaPP);
            }
            

          
        }

        private void docavailcancel_Click(object sender, EventArgs e)
        {
            
        }

        private void PatientCount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
