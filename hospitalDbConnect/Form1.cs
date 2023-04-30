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
            String Name,Age;

            Name=textBox1.Text;
            Age=textBox2.Text;

            try
            {
                String querry = "INSERT INTO patientDb1(Name,age) VALUES('"+textBox1.Text+"','"+textBox2.Text+"')";

                //String querry = "SELECT *FROM patientDb";
                SqlDataAdapter sda=new SqlDataAdapter(querry,con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                if(dt.Rows.Count > 0 )
                {
                    Name = textBox1.Text;
                    Age = textBox2.Text;

                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }

            }
            catch {
                MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
