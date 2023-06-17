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
    public partial class searchdoc : UserControl
    {
        public searchdoc()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            sdpanel.Controls.Clear();
            sdpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Appsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void Appsearch_Click_1(object sender, EventArgs e)
        {
            DoctorPro dp = new DoctorPro();
            addUserControl(dp);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM PatientsDBvwHERE DoctorName1=@doctorname", con);
        }
    }
}
