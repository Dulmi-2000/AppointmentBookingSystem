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
    public partial class sms : UserControl
    {
        public sms()
        {
            InitializeComponent();
        }

        private void smscancel_Click(object sender, EventArgs e)
        {
            if (smscancel != null)
            {
                pnum.Clear();
                message.Clear();
            }
        }

        private void Appsubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("successfully Sent", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
