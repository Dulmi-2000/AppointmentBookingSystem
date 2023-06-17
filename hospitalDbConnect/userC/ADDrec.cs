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
    public partial class ADDrec : UserControl
    {
        public ADDrec()
        {
            InitializeComponent();
        }

        private void APPcancel_Click(object sender, EventArgs e)
        {
            if (rrclear != null)
            {
                rr1.Clear();
                rr2.Clear();
                rr3.Clear();
                rr4.Clear();
                rr5.Clear();
            }
        }

        private void Appsubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            String Name, Address, Age, Gender, RegisteredDate, ContactNo, Email;

            Name = rr1.Text;
            Address = rr2.Text;
            Age = rr3.Text;
            Gender = gender.Text;
            RegisteredDate = APPdate.Text;
            ContactNo = rr4.Text;
            Email = rr5.Text;

            try
            {
                con.Open();
                string querry = "INSERT INTO ReceptionistDetails(Name,Address,Age,Gender,RegisteredDate,ContactNo,Email) VALUES('" + Name + "','" + Address + "','" + Age + "','''" + Gender + "," + ContactNo + "','" + RegisteredDate + "','" + Email + "')";

                //String querry = "SELECT *FROM patientDb";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Name = rr1.Text;
                    Address = rr2.Text;

                    Age = rr3.Text;
                    Gender = gender.Text;
                    RegisteredDate = APPdate.Text;
                    ContactNo = rr4.Text;
                    Email = rr5.Text;

                    MessageBox.Show("successfully registered", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid");
                }

            }
            catch
            {
               // MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }
        }
    }
        }


    
           