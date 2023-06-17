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
    public partial class changeapp : UserControl
    {
        public changeapp()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ChangeAppPanel.Controls.Clear();
            ChangeAppPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Appsubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void Appsubmit_Click_1(object sender, EventArgs e)
        {
            ChangeappForm deleteapp = new ChangeappForm();
            addUserControl(deleteapp);
        }
    }
}
