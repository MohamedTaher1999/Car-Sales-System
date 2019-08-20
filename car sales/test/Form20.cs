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

namespace WindowsFormsApplication2
{
    public partial class admin_lgn : Form
    {
        public admin_lgn()
        {
            InitializeComponent();
           
        }

        private void Sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminRegistration adminreg = new AdminRegistration();
            adminreg.Show();
            this.Close();
        }

        private void admin_lgn_Load(object sender, EventArgs e)
        {
           
            log2.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Login_Click(object sender, EventArgs e)
        {
            bool visit = false;
            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            String query = "SELECT admain_name,admain_pass FROM Admain";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox1.Text == reader.GetString(0))
                {
                    visit = true;

                    if (textBox2.Text == reader.GetString(1))
                    {
                        WindowsFormsApp7.Form1 f = new WindowsFormsApp7.Form1();
                        f.Show();
                        this.Close();
                    }
                    else MessageBox.Show("Wrong Passward");

                }


            }

            if (visit == false) MessageBox.Show("Wrong Name");
            //cmd.ExecuteNonQuery();
            reader.Close();
            con.Close();
        
           
        }
    }
}
