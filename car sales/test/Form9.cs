using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace test
{
    public partial class Form9 : Form
    {
        private List<carclass> list;
        List<carclass> temp2 = new List<carclass>();
        private String y;
        public Form9(List<carclass> x )
        {
            InitializeComponent();
            list = x;
            if (list[0].makke == "car")
            {
                panel1.Visible = false;
                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "SELECT *FROM car_inf WHERE car_id =" + list[0].car_id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    label1.Text = reader.GetString(1);
                    label2.Text = reader.GetString(2);

                    byte[] xx = (byte[])reader["picture"];
                    MemoryStream p = new MemoryStream(xx);

                    p.Seek(0, SeekOrigin.Begin);
                    pictureBox1.Image = Image.FromStream(p);
                    label22.Text = reader.GetString(4);
                    label21.Text = reader.GetString(5);
                    label20.Text = reader.GetString(6);
                    label19.Text = reader.GetString(7);
                    label18.Text = reader.GetString(8);
                    label17.Text = reader.GetString(9);
                    label16.Text = reader.GetString(11);
                    label15.Text = reader.GetString(13);
                    label6.Text = reader.GetString(12);
                    label29.Text = list[0].customer_id.ToString();

                }
            }
            else if(list[0].makke=="part") {
                panel1.Visible = true;
                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "SELECT *FROM part_car WHERE part_id =" + list[0].car_id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    label24.Text = reader.GetString(1);
                    label26.Text = reader.GetString(4);
                    label28.Text = reader.GetString(2);
                    label29.Text = list[0].customer_id.ToString();
                    byte[] xx = (byte[])reader["pictuer"];
                    MemoryStream p = new MemoryStream(xx);

                    p.Seek(0, SeekOrigin.Begin);
                    pictureBox2.Image = Image.FromStream(p);
                   

                }
                
            }
            else if (list[0].makke == "access")
            {
                panel1.Visible = true;
                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "SELECT *FROM accessories_inf WHERE accessories_id =" + list[0].car_id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    label24.Text = reader.GetString(1);
                    label26.Text = reader.GetString(4);
                    label28.Text = reader.GetString(2);
                    label29.Text = list[0].customer_id.ToString();
                    byte[] xx = (byte[])reader["picture"];
                    MemoryStream p = new MemoryStream(xx);

                    p.Seek(0, SeekOrigin.Begin);
                    pictureBox2.Image = Image.FromStream(p);


                }


             
            }



        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            hdform2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void f2close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void hdform2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            order o = new order(list);
            o.Show();

            this.Close();
            //Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order o = new order(list);
            o.Show();
            this.Close();
        }
    }
}
