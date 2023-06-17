using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using hospitalDbConnect.userC;
using System.Security.Policy;

namespace hospitalDbConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCon.Controls.Clear();
            panelCon.Controls.Add(userControl);
            userControl.BringToFront();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(dashbutton != null)
            {
                dash da = new dash();
                addUserControl(da);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Name1_Click(object sender, EventArgs e)
        {
            if(Name1 != null)
            {
            
               loginCreate log=new loginCreate();
            addUserControl (log);
            }
            
        }

        private void addUserControl(login nl)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void docbutton1_Click(object sender, EventArgs e)
        { int a = 20;
            if(a < 26 && docbutton1 != null  ) 
            {
                
                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton1.Enabled = false;
            }
           
        }

        private void docbutton2_Click(object sender, EventArgs e)
        {
            int ab= 30;
            if (ab < 26 && docbutton2 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton2.Enabled = false;
            }
        }

        private void docbutton3_Click(object sender, EventArgs e)
        {
            int c = 20;
            if (c < 26 && docbutton3 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton3.Enabled = false;
            }
        }

        private void docbutton4_Click(object sender, EventArgs e)
        {
            int d = 20;
            if (d < 26 && docbutton4 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton4.Enabled = false;
            }
        }

        private void docbutton5_Click(object sender, EventArgs e)
        {
            int f = 20;
            if (f < 26 && docbutton5 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton5.Enabled = false;
            }
        }

        private void docbutton6_Click(object sender, EventArgs e)
        {
            int g = 20;
            if (g < 26 && docbutton6 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton6.Enabled = false;
            }
        }

        private void docbutton7_Click(object sender, EventArgs e)
        {
            int h = 20;
            if (h < 26 && docbutton7 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton7.Enabled = false;
            }
        }

        private void docbutton8_Click(object sender, EventArgs e)
        {
            int i = 20;
            if (i < 26 && docbutton8 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton8.Enabled = false;
            }
        }

        private void docbutton9_Click(object sender, EventArgs e)
        {
            int j = 20;
            if (j < 26 && docbutton9 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton9.Enabled = false;
            }
        }

        private void docbutton10_Click(object sender, EventArgs e)
        {
            int k = 20;
            if (k < 26 && docbutton10 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton10.Enabled = false;
            }
        }

        private void docbutton11_Click(object sender, EventArgs e)
        {
            int l = 20;
            if (l < 26 && docbutton11 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton11.Enabled = false;
            }
        }

        private void docbutton12_Click(object sender, EventArgs e)
        {
            int m = 20;
            if (m < 26 && docbutton12 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                addUserControl(uc);
            }
            else
            {
                docbutton12.Enabled = false;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            searchdoc sd= new searchdoc();
            addUserControl(sd);
            
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            receptionserch receptionserch = new receptionserch();
            addUserControl(receptionserch);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            ADDdoc docadd = new ADDdoc();
            addUserControl(docadd);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            ADDrec aDDrec = new ADDrec();
            addUserControl(aDDrec);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            sms sms = new sms();
            addUserControl(sms);
        }

        private void panelCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox4.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox10.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox6.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox8.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox12.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox20.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox22.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox24 + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox18.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox16.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox14.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox6.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
