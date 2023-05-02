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
            UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCregister uc = new UCregister();
            addUserControl(uc);
        }

        private void patientBttn_Click(object sender, EventArgs e)
        {
            UCpatient uc = new UCpatient();
            addUserControl(uc);
        }
    }
}
