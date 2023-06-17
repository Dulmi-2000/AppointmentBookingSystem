using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalDbConnect.userC
{
    public partial class dash : UserControl
    {
        public dash()
        {
            InitializeComponent();
        }

        private void docbutton1_Click(object sender, EventArgs e)
        {
            int a = 20;
            if (a < 26 && docbutton1 != null)
            {

                UserControlAPPOINTMENT uc = new UserControlAPPOINTMENT();
                //addUserControl(uc);
            }
            else
            {
                docbutton1.Enabled = false;
            }
        }

        private void docbutton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        internal static object getValue(int v)
        {
            throw new NotImplementedException();
        }

        private void docbutton8_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
