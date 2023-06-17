using hospitalDbConnect.userC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalDbConnect
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            loginpanel.Controls.Clear();
            loginpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void receptbutt_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (receptbutt != null)
            {
                receptlogin relog = new receptlogin();
                addUserControl(relog);
            }
        }

        private void Appsubmit_Click(object sender, EventArgs e)
        {
            


            if (Appsubmit != null)
            {
                adminlogin1 adlog = new adminlogin1();
                addUserControl(adlog);
            }
        }
    }
}
