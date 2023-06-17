using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace hospitalDbConnect.userC
{
    public partial class receptionserch : UserControl
    {
        public receptionserch()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            recpanel.Controls.Clear();
            recpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Appsearch_Click(object sender, EventArgs e)
        {
            reciptionPRO reciptionPRO = new reciptionPRO();
            addUserControl(reciptionPRO);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ReceptionistDetails WHERE DoctorName1=@doctorname", con);
            cmd.Parameters.AddWithValue("Name", APPdoc.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
        }
    }
}
