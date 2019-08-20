using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test
{
    public partial class order : Form
    {
        int customer;
        private List<carclass> list;

        public order(List<carclass> x)
        {
            InitializeComponent();
            list = x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || (radioButton2.TabStop == true && textBox3.Text == ""))
            {

                MessageBox.Show("Enter All Data");
            }
            else
            {
                if (list[0].makke == "car")
                {
                    String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                    SqlConnection con = new SqlConnection(sql);
                    con.Open();
                    String query = "UPDATE car_inf SET customerid=@customerid WHERE car_id=" + list[0].car_id;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@customerid", list[0].customer_id);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if (list[0].makke == "part")
                {
                    String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                    SqlConnection con = new SqlConnection(sql);
                    con.Open();
                    String query = "UPDATE part_car SET customerid=@customerid WHERE part_id=" + list[0].car_id;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@customerid", list[0].customer_id);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if (list[0].makke == "access")
                {
                    String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                    SqlConnection con = new SqlConnection(sql);
                    con.Open();
                    String query = "UPDATE accessories_inf SET customerid=@customerid WHERE accessories_id=" + list[0].car_id;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@customerid", list[0].customer_id);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                String sqll = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sqll);
                    conn.Open();
                    String queryy = "INSERT INTO contract (customerid , id_buy , type , Address , national_id , visa_number ) VALUES (@customerid , @id_buy , @type , @Address , @national_id , @visa_number )";
                    SqlCommand cmdd = new SqlCommand(queryy, conn);
                    cmdd.Parameters.AddWithValue("@customerid", list[0].customer_id);
                    cmdd.Parameters.AddWithValue("@id_buy", list[0].car_id);
                    cmdd.Parameters.AddWithValue("@type", list[0].makke);
                    cmdd.Parameters.AddWithValue("@national_id", textBox2.Text);
                    cmdd.Parameters.AddWithValue("@Address", textBox1.Text);
                    cmdd.Parameters.AddWithValue("@visa_number", textBox3.Text);
                   
                    cmdd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data saved successfuly");
          
           
                
                
                

                

                
            }
            this.Close();

        }

        private void order_Load(object sender, EventArgs e)
        {

        }
    }
}
