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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            userpl.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void Day_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void E_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bool x = true;
            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            String query = "SELECT *FROM customer_inf";
             SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (FirstName.Text == reader.GetString(1)) {

                    MessageBox.Show("Enter another name");
                    x = false;
                }


            }
            reader.Close();
            cmd.ExecuteNonQuery();

            if (x == true)
            {

                sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                con = new SqlConnection(sql);
                con.Open();
                query = "INSERT INTO customer_inf (name , passward , address , email , phone , gender ) VALUES (@name , @passward , @address , @email , @phone , @gender )";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", FirstName.Text);
                cmd.Parameters.AddWithValue("@passward", Password.Text);
                cmd.Parameters.AddWithValue("@address", textBox1.Text);
                cmd.Parameters.AddWithValue("@email", E_mail.Text);
                cmd.Parameters.AddWithValue("@phone", textBox2.Text);
                if (Male.TabStop == true) cmd.Parameters.AddWithValue("@gender", "male");
                else cmd.Parameters.AddWithValue("@gender", "female");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved successfuly");
                test.Form10 f = new test.Form10();
                f.Show();
                this.Close();


            }

        }
        


    }
}
