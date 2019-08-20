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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            log1.BackColor = Color.FromArgb(180, 0, 0, 0);    
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister Regist = new UserRegister();
            Regist.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Submit_Login_Click(object sender, EventArgs e)
        {
            bool visit = false;
            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            String query = "SELECT name,passward,customer_id FROM customer_inf";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
             if(textBox1.Text==reader.GetString(0)){
                 visit = true;

                 if (textBox2.Text == reader.GetString(1))
                 {
                     test.Form10 f = new test.Form10(reader.GetInt32(2));
                     f.Show();
                     this.Close();
                 }
                 else MessageBox.Show("Wrong Passward");
             
             }


            }

            if (visit == false) MessageBox.Show("Wrong Name");
          //  cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}
