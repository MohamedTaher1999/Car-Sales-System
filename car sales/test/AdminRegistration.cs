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
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void Day_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminRegistration_Load(object sender, EventArgs e)
        {

            adminpl.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void E_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
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
                if (E_mail.Text == reader.GetString(0))
                {

                    if (Password.Text == reader.GetString(1))
                    {
                        visit = true;

                    }

                }


            }
            //cmd.ExecuteNonQuery();
            reader.Close();
            con.Close();
            if (visit == false) MessageBox.Show("Wrong Admin");
            else
            {
                 sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                con = new SqlConnection(sql);
                con.Open();
                query = "INSERT INTO Admain (admain_name , admain_pass ) VALUES (@admain_name , @admain_pass )";
                 cmd = new SqlCommand(query, con);
                 cmd.Parameters.AddWithValue("@admain_name", FirstName.Text);
                 cmd.Parameters.AddWithValue("@admain_pass", LastName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                WindowsFormsApp7.Form1 f = new WindowsFormsApp7.Form1();
                f.Show();
                this.Close();
    
            }

        }
    }
}
