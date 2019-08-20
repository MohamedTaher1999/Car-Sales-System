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
using System.IO;
namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String imageLocation = "";
        String imageLocation2 = "";
        String imageLocation4 = "";
           

        private void Acc_Nme_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Acc_Nme_txt.ForeColor == SystemColors.ScrollBar)
            {
                Acc_Nme_txt.ForeColor = Color.Black;
                Acc_Nme_txt.Clear();
            }
        }

        private void Acc_Nme_txt_Leave(object sender, EventArgs e)
        {
            if (Acc_Nme_txt.Text == "")
            {
                Acc_Nme_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Nme_txt.Text = "Enter Name";
            }
        }
     

        

       

        private void OrdersPage_Enter(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void Acc_mngmntPage_Enter(object sender, EventArgs e)
        {

            acc_Mngmnt_panel.Visible = true;
        }

        private void AccExit_btn_Click(object sender, EventArgs e)
        {

            acc_Mngmnt_panel.Visible = false;
           // Acc_ID_txt.ForeColor = SystemColors.ScrollBar;
            //Acc_ID_txt.Text = "Enter ID";
            Acc_Nme_txt.ForeColor = SystemColors.ScrollBar;
            Acc_Nme_txt.Text = "Enter Name";
            Acc_Price_txt.ForeColor = SystemColors.ScrollBar;
            Acc_Price_txt.Text = "Enter Price";
            Acc_Mdl_txt.ForeColor = SystemColors.ScrollBar;
            Acc_Mdl_txt.Text = "Enter Model;";
            Acc_pcturebx.Image = null;
            Acc_srsh_panel.Visible = false;
        }

        private void Acc_ID_txt_Leave(object sender, EventArgs e)
        {
            
        }

        private void Acc_ID_txt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Acc_Price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Acc_Price_txt.ForeColor == SystemColors.ScrollBar)
            {
                Acc_Price_txt.ForeColor = Color.Black;
                Acc_Price_txt.Clear();
            }
        }

        private void Acc_Price_txt_Leave(object sender, EventArgs e)
        {
            if (Acc_Price_txt.Text == "")
            {
                Acc_Price_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Price_txt.Text = "Enter Price";
            }
        }

        private void Acc_Mdl_txt_Leave(object sender, EventArgs e)
        {
            if (Acc_Mdl_txt.Text == "")
            {
                Acc_Mdl_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Mdl_txt.Text = "Enter Model";
            }
        }

        private void Acc_Mdl_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Acc_Mdl_txt.ForeColor == SystemColors.ScrollBar)
            {
                Acc_Mdl_txt.ForeColor = Color.Black;
                Acc_Mdl_txt.Clear();
            }
        }

        private void Acc_Add_btn_Click(object sender, EventArgs e)
        {

            if (Acc_Nme_txt.ForeColor == SystemColors.ScrollBar|| Acc_pcturebx.Image == null || Acc_Price_txt.ForeColor == SystemColors.ScrollBar|| Acc_Mdl_txt.ForeColor == SystemColors.ScrollBar)
            { MessageBox.Show("Please enter all data"); }
            else
            {


                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "INSERT INTO accessories_inf (accessories_name , type , picture , price ) VALUES (@accessories_name , @type , @picture , @price )";
                byte[] images3 = null;
                FileStream Streem3 = new FileStream(imageLocation4, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem3);
                images3 = brs.ReadBytes((int)Streem3.Length);

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accessories_name", Acc_Mdl_txt.Text);
                cmd.Parameters.AddWithValue("@type", Acc_Nme_txt.Text);
                cmd.Parameters.AddWithValue("@picture", images3);
                cmd.Parameters.AddWithValue("@price", Acc_Price_txt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved successfuly");
            

               // Acc_ID_txt.ForeColor = SystemColors.ScrollBar;
                //Acc_ID_txt.Text = "Enter ID";
                Acc_Nme_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Nme_txt.Text = "Enter Name";
                Acc_Price_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Price_txt.Text = "Enter Price";
                Acc_Mdl_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Mdl_txt.Text = "Enter Model";
                Acc_pcturebx.Image = null;
            }
        }

        private void Acc_srch_btn_Click(object sender, EventArgs e)
        {
            Acc_srsh_panel.Visible = true;
            Acc_find_btn.Visible = true;
            button8.Visible = false;
            
        }

        

        private void Acc_dlte_btn_Click(object sender, EventArgs e)
        {
            Acc_srsh_panel.Visible = true;
            Acc_find_btn.Visible = false;
            button8.Visible = true;
         
        }

        private void Acc_Updt_btn_Click(object sender, EventArgs e)
        {
            if (Acc_Nme_txt.ForeColor == SystemColors.ScrollBar || Acc_pcturebx.Image == null || Acc_Price_txt.ForeColor == SystemColors.ScrollBar || Acc_Mdl_txt.ForeColor == SystemColors.ScrollBar)
            { MessageBox.Show("Please enter all data"); }
            else
            {
                MessageBox.Show("Data updated successfuly");
                //Acc_ID_txt.ForeColor = SystemColors.ScrollBar;
                //Acc_ID_txt.Text = "Enter ID";
                Acc_Nme_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Nme_txt.Text = "Enter Name";
                Acc_Price_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Price_txt.Text = "Enter Price";
                Acc_Mdl_txt.ForeColor = SystemColors.ScrollBar;
                Acc_Mdl_txt.Text = "Enter Model";
                Acc_pcturebx.Image = null;
            }
        }

        private void Acc_srsh_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Acc_srsh_txt.ForeColor == SystemColors.ScrollBar)
            {
                Acc_srsh_txt.ForeColor = Color.Black;
                Acc_srsh_txt.Clear();
            }
        }

        private void Acc_srsh_txt_Leave(object sender, EventArgs e)
        {
            if (Acc_srsh_txt.Text == "")
            {
                Acc_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Acc_srsh_txt.Text = "Enter Name";
            }
        }

        private void Acc_find_btn_Click(object sender, EventArgs e)
        {
            if (Acc_srsh_txt.ForeColor == SystemColors.ScrollBar)
            {
                MessageBox.Show("Please enter accessory name to searsh for");
            }
            else
            {
                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();

                DataTable dt = new DataTable();
                String query = "SELECT  *FROM accessories_inf WHERE accessories_name LIKE'%" + Acc_srsh_txt.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView3.DataSource = dt;

               
                Acc_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Acc_srsh_txt.Text = "Enter Name";
                dataGridView3.Visible = true;
            }
        }

        private void Prt_pctur_btn_Click(object sender, EventArgs e)
        {
        
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation2 = dialog.FileName;
                    Prt_pcturebx.ImageLocation = imageLocation2;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void parts_mngmntPage_Enter(object sender, EventArgs e)
        {
            Prts_mngmnt_pnl.Visible = true;
        }

        private void Prts_mngmnt_Exit_btn_Click(object sender, EventArgs e)
        {

            Prts_mngmnt_pnl.Visible = false;
            //Prts_nme_txt.ForeColor = SystemColors.ScrollBar;
            //Prts_nme_txt.Text = "Enter Name";
            Prts_mdl_txt.ForeColor = SystemColors.ScrollBar;
            Prts_mdl_txt.Text = "Enter Type";
            Prts_ID_txt.ForeColor = SystemColors.ScrollBar;
            Prts_ID_txt.Text = "Enter ID";
            Prts_Price_txt.ForeColor = SystemColors.ScrollBar;
            Prts_Price_txt.Text = "Enter Price";
            Prt_pcturebx.Image = null;
            Prts_srsh_pnl.Visible = false;
        }

        private void Prts_srsh_btn_Click(object sender, EventArgs e)
        {
            Prts_srsh_pnl.Visible = true;
            prts_find_btn.Visible = true;
            button5.Visible = false;

        }

        private void prts_find_btn_Click(object sender, EventArgs e)
        {
            if (Prts_srsh_txt.ForeColor == SystemColors.ScrollBar)
            {
                MessageBox.Show("Please enter part name to searsh for");
            }
            else
            {
                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();

                DataTable dt = new DataTable();
                String query = "SELECT  *FROM part_car WHERE partname LIKE'%" +Prts_srsh_txt.Text +"%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView2.DataSource = dt;

                Prts_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Prts_srsh_txt.Text = "Enter Name";
                Prts_srsh_pnl.Visible = false;
                dataGridView2.Visible = true;
            }
        }

        private void Prts_add_btn_Click(object sender, EventArgs e)
        {


            if ( Prt_pcturebx.Image == null || Prts_Price_txt.ForeColor == SystemColors.ScrollBar || Prts_mdl_txt.ForeColor == SystemColors.ScrollBar)
            { MessageBox.Show("Please enter all data"); }
            else
            {

                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "INSERT INTO part_car (partname , type , pictuer , price ) VALUES (@partname , @type , @pictuer , @price )";
                byte[] images2 = null;
                FileStream Streem2 = new FileStream(imageLocation2, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem2);
                images2 = brs.ReadBytes((int)Streem2.Length);

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@partname", Prts_ID_txt.Text);
                cmd.Parameters.AddWithValue("@type", Prts_mdl_txt.Text);
                cmd.Parameters.AddWithValue("@pictuer", images2);
                cmd.Parameters.AddWithValue("@price", Prts_Price_txt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved successfuly");
            
                //Prts_nme_txt.ForeColor = SystemColors.ScrollBar;
                //Prts_nme_txt.Text = "Enter Name";
                Prts_mdl_txt.ForeColor = SystemColors.ScrollBar;
                Prts_mdl_txt.Text = "Enter Type";
                Prts_ID_txt.ForeColor = SystemColors.ScrollBar;
                Prts_ID_txt.Text = "Enter ID";
                Prts_Price_txt.ForeColor = SystemColors.ScrollBar;
                Prts_Price_txt.Text = "Enter Price";
                Prt_pcturebx.Image = null;
            }

        }

        private void Prts_dlte_btn_Click(object sender, EventArgs e)
        {
            Prts_srsh_pnl.Visible = true;
            prts_find_btn.Visible = false;
            button5.Visible = true;
        }

        private void Prts_updte_btn_Click(object sender, EventArgs e)
        {

            if ( Prt_pcturebx.Image == null || Prts_Price_txt.ForeColor == SystemColors.ScrollBar || Prts_mdl_txt.ForeColor == SystemColors.ScrollBar)
            { MessageBox.Show("Please enter all data"); }
            else
            {
                //Prts_nme_txt.ForeColor = SystemColors.ScrollBar;
                //Prts_nme_txt.Text = "Enter Name";
                Prts_mdl_txt.ForeColor = SystemColors.ScrollBar;
                Prts_mdl_txt.Text = "Enter Type";
                Prts_ID_txt.ForeColor = SystemColors.ScrollBar;
                Prts_ID_txt.Text = "Enter ID";
                Prts_Price_txt.ForeColor = SystemColors.ScrollBar;
                Prts_Price_txt.Text = "Enter Price";
                Prt_pcturebx.Image = null;
                MessageBox.Show("Data updated successfuly");
            }
        }

        private void Prts_srsh_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Prts_srsh_txt.ForeColor == SystemColors.ScrollBar)
            {
                Prts_srsh_txt.ForeColor = Color.Black;
                Prts_srsh_txt.Clear();
            }
        }

        private void Prts_srsh_txt_Leave(object sender, EventArgs e)
        {
            if (Prts_srsh_txt.Text == "")
            {
                Prts_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Prts_srsh_txt.Text = "Enter Name";
            }
        }

        private void Prts_mdl_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Prts_mdl_txt.ForeColor == SystemColors.ScrollBar)
            {
                Prts_mdl_txt.ForeColor = Color.Black;
                Prts_mdl_txt.Clear();
            }
        }

        private void Prts_mdl_txt_Leave(object sender, EventArgs e)
        {
            if (Prts_mdl_txt.Text == "")
            {
                Prts_mdl_txt.ForeColor = SystemColors.ScrollBar;
                Prts_mdl_txt.Text = "Enter Type";
            }
        }

        private void Prts_ID_txt_KeyDown(object sender, KeyEventArgs e)
        {

            if (Prts_ID_txt.ForeColor == SystemColors.ScrollBar)
            {
                Prts_ID_txt.ForeColor = Color.Black;
                Prts_ID_txt.Clear();
            }
        }

        private void Prts_ID_txt_Leave(object sender, EventArgs e)
        {
            if (Prts_ID_txt.Text == "")
            {
                Prts_ID_txt.ForeColor = SystemColors.ScrollBar;
                Prts_ID_txt.Text = "Enter ID";
            }
        }

        private void Prts_nme_txt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Prts_nme_txt_Leave(object sender, EventArgs e)
        {
            
        }

        private void Acc_pcture_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation4 = dialog.FileName;
                    Acc_pcturebx.ImageLocation = imageLocation4;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        

        private void Car_find_btn_Click(object sender, EventArgs e)
        {
            if (Car_srsh_txt.ForeColor == SystemColors.ScrollBar || textBox1.ForeColor==SystemColors.ScrollBar)
            {
                MessageBox.Show("Please enter car name to searsh for");
            }
            else
            {


                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                
                DataTable dt = new DataTable();
                String x = Car_srsh_txt.Text;
                String query = "SELECT  *FROM car_inf WHERE make ='" + Car_srsh_txt.Text + "' AND car_model='"+textBox1.Text+"' ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                
                Car_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Car_srsh_txt.Text = "Enter Name";
                textBox1.Text = "";
            //    panel1.Visible = true;




            }
        }

        private void Car_srsh_txt_Leave(object sender, EventArgs e)
        {
            if (Car_srsh_txt.Text == "")
            {
                Car_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Car_srsh_txt.Text = "Enter Name";
            }
        }

        private void Car_srsh_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Car_srsh_txt.ForeColor == SystemColors.ScrollBar)
            {
                Car_srsh_txt.ForeColor = Color.Black;
                Car_srsh_txt.Clear();
            }
        }

        private void Car_ID_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Car_ID_txt.ForeColor == SystemColors.ScrollBar)
            {
                Car_ID_txt.ForeColor = Color.Black;
                Car_ID_txt.Clear();
            }
        }

        private void Car_ID_txt_Leave(object sender, EventArgs e)
        {
            if (Car_ID_txt.Text == "")
            {
                Car_ID_txt.ForeColor = SystemColors.ScrollBar;
                Car_ID_txt.Text = "Enter ID";
            }
        }

        private void Car_nme_txt_Leave(object sender, EventArgs e)
        {
            if (Car_nme_txt.Text == "")
            {
                Car_nme_txt.ForeColor = SystemColors.ScrollBar;
                Car_nme_txt.Text = "Enter Name";
            }
        }

        private void Car_mdl_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Car_mdl_txt.ForeColor == SystemColors.ScrollBar)
            {
                Car_mdl_txt.ForeColor = Color.Black;
                Car_mdl_txt.Clear();
            }
        }

        private void Car_nme_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Car_nme_txt.ForeColor == SystemColors.ScrollBar)
            {
                Car_nme_txt.ForeColor = Color.Black;
                Car_nme_txt.Clear();
            }
        }

        private void Car_mdl_txt_Leave(object sender, EventArgs e)
        {
            if (Car_mdl_txt.Text == "")
            {
                Car_mdl_txt.ForeColor = SystemColors.ScrollBar;
                Car_mdl_txt.Text = "Enter Model";
            }
        }

        private void Car_price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Car_price_txt.ForeColor == SystemColors.ScrollBar)
            {
                Car_price_txt.ForeColor = Color.Black;
                Car_price_txt.Clear();
            }
        }

        private void Car_price_txt_Leave(object sender, EventArgs e)
        {
            if (Car_mdl_txt.Text == "")
            {
                Car_mdl_txt.ForeColor = SystemColors.ScrollBar;
                Car_mdl_txt.Text = "Enter Model";
            }
        }

        private void Car_pctur_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    Cars_pcturbx.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Car_add_btn_Click(object sender, EventArgs e)
        {

            if (Car_nme_txt.ForeColor == SystemColors.ScrollBar || Car_ID_txt.ForeColor == SystemColors.ScrollBar || Cars_pcturbx.Image == null || Car_price_txt.ForeColor == SystemColors.ScrollBar || Car_mdl_txt.ForeColor == SystemColors.ScrollBar || Car_mnul_txt.Text == " " || Car_mxspeed_txt.Text == " " || Car_weght_txt.Text == " " || Car_yeresblshd_lbl.Text == " " || CarEng_txt.Text == " ")
            { MessageBox.Show("Please enter all data"); }
            else
            {

                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "INSERT INTO car_inf (make, price , picture , car_model , engine , weight , manufacturedstate ,yearestablished , maxspeed , tank , details , color) VALUES (@make , @price , @picture , @car_model , @engine , @weight , @manufacturedstate , @yearestablished ,@maxspeed , @tank , @details , @color )";
                byte[] images = null;
                FileStream Streem = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@make", Car_ID_txt.Text);
                cmd.Parameters.AddWithValue("@price", Car_price_txt.Text);
                cmd.Parameters.AddWithValue("@picture", images);
                cmd.Parameters.AddWithValue("@car_model", Car_mdl_txt.Text);
                cmd.Parameters.AddWithValue("@engine", CarEng_txt.Text);
                cmd.Parameters.AddWithValue("@weight", Car_weght_txt.Text);
                cmd.Parameters.AddWithValue("@manufacturedstate", Car_mnul_txt.Text);
                cmd.Parameters.AddWithValue("@yearestablished", Car_yer_combobx.Text);
                cmd.Parameters.AddWithValue("@maxspeed", Car_mxspeed_txt.Text);
                cmd.Parameters.AddWithValue("@tank", Car_nme_txt.Text);
                cmd.Parameters.AddWithValue("@details", textBox2.Text);
                cmd.Parameters.AddWithValue("@color", textBox3.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved successfuly");
                Cars_pcturbx.Image = null;
                Car_nme_txt.ForeColor = SystemColors.ScrollBar;
                Car_nme_txt.Text = "Enter Name";
                Car_ID_txt.ForeColor = SystemColors.ScrollBar;
                Car_ID_txt.Text = "Enter ID";
                Car_mdl_txt.ForeColor = SystemColors.ScrollBar;
                Car_mdl_txt.Text = "Enter Model";
                Car_price_txt.ForeColor = SystemColors.ScrollBar;
                Car_price_txt.Text = "Enter Price";
                CarEng_txt.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                Car_mnul_txt.Text = " ";
                Car_mxspeed_txt.Text = " ";
                Car_srsh_pnl.Visible = false;
                Car_yer_combobx.Text = " ";
                Car_weght_txt.Text = " ";   



                



            }
        }

        private void Prts_rprt_exit_btn_Click(object sender, EventArgs e)
        {
            Prts_rprt_pnl.Visible = false;
        }

        private void Prts_reportPage_Enter(object sender, EventArgs e)
        {

            Prts_rprt_pnl.Visible = true;
        }

        private void Cars_Rprt_exit_btn_Click(object sender, EventArgs e)
        {
            Cars_rprt_pnl.Visible = false;
        }

        private void Crs_rprtPage_Enter(object sender, EventArgs e)
        {

            Cars_rprt_pnl.Visible = true;
        }

        private void Cus_rprt_exit_btn_Click(object sender, EventArgs e)
        {
            Cus_rprt_pnl.Visible = false;
        }

        private void Cstmr_reportPage_Enter(object sender, EventArgs e)
        {

            Cus_rprt_pnl.Visible = true;
        }

        private void Cars_mngmntPage_Enter(object sender, EventArgs e)
        {
            Ca_mngmnt_pnl.Visible = true;
        }

        private void Acc_rprt_Exitbtn_Click(object sender, EventArgs e)
        {
            Acc_rprt_panel.Visible = false;
        }

        private void Acc_reportPage_Enter(object sender, EventArgs e)
        {
            Acc_rprt_panel.Visible = true;
        }

        private void Pswrd_exit_btn_Click(object sender, EventArgs e)
        {
        }

        private void Psw_mngmntPage_Enter(object sender, EventArgs e)
        {
        }

        private void Car_update_btn_Click(object sender, EventArgs e)
        {

            if (Car_nme_txt.ForeColor == SystemColors.ScrollBar || Car_ID_txt.ForeColor == SystemColors.ScrollBar || Cars_pcturbx.Image == null || Car_price_txt.ForeColor == SystemColors.ScrollBar || Car_mdl_txt.ForeColor == SystemColors.ScrollBar || Car_mnul_txt.Text == " " || Car_mxspeed_txt.Text == " " || Car_weght_txt.Text == " " || Car_yeresblshd_lbl.Text == " " || CarEng_txt.Text == " ")
            { MessageBox.Show("Please enter all data"); }
            else
            {
                MessageBox.Show("Data updated successfuly");
                Cars_pcturbx.Image = null;
                Car_nme_txt.ForeColor = SystemColors.ScrollBar;
                Car_nme_txt.Text = "Enter Name";
                Car_ID_txt.ForeColor = SystemColors.ScrollBar;
                Car_ID_txt.Text = "Enter ID";
                Car_mdl_txt.ForeColor = SystemColors.ScrollBar;
                Car_mdl_txt.Text = "Enter Model";
                Car_price_txt.ForeColor = SystemColors.ScrollBar;
                Car_price_txt.Text = "Enter Price";
            }
        }

        private void Car_srsh_btn_Click(object sender, EventArgs e)
        {
            Car_srsh_pnl.Visible = true;
            dataGridView1.Visible = true;
            panel1.Visible = false;
            Car_find_btn.Visible = true;
            button4.Visible = false;
            
        }

        private void Car_dlte_btn_Click(object sender, EventArgs e)
        {
            Car_srsh_pnl.Visible = true;
            dataGridView1.Visible = true;
            panel1.Visible = false;
            Car_find_btn.Visible = false;
            button4.Visible = true;
        }

        private void Cur_pswrd_txt_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
      

        private void Cur_pswrd_txt_Leave(object sender, EventArgs e)
        {
        }

        private void New_pswrd_txt_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void New_pswrd_txt_Leave(object sender, EventArgs e)
        {
        }

        private void Cnfrm_pswrd_txt_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void Cnfrm_pswrd_txt_Leave(object sender, EventArgs e)
        {
           
        }

        private void Dne_btn_Click(object sender, EventArgs e)
        {
         
        }

        private void Cars_mngmnt_exit_btn_Click_1(object sender, EventArgs e)
        {
            
                Ca_mngmnt_pnl.Visible = false;
            Cars_pcturbx.Image = null;
            Car_nme_txt.ForeColor = SystemColors.ScrollBar;
            Car_nme_txt.Text = "Enter Name";
            Car_ID_txt.ForeColor = SystemColors.ScrollBar;
            Car_ID_txt.Text = "Enter ID";
            Car_mdl_txt.ForeColor = SystemColors.ScrollBar;
            Car_mdl_txt.Text = "Enter Model";
            Car_price_txt.ForeColor = SystemColors.ScrollBar;
            Car_price_txt.Text = "Enter Price";
            CarEng_txt.Text = " ";
            Car_mnul_txt.Text = " ";
            Car_mxspeed_txt.Text = " ";
            Car_srsh_pnl.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = false;
            Car_yer_combobx.Text = " ";
        }

        private void Prt_srch_ext_btn_Click(object sender, EventArgs e)
        {
            Prts_srsh_pnl.Visible = false;
            Prts_srsh_txt.ForeColor = SystemColors.ScrollBar;
            Prts_srsh_txt.Text = "Enter Name";
            dataGridView2.Visible = false;
        }

        private void parts_mngmntPage_Leave(object sender, EventArgs e)
        {
            //Prts_nme_txt.ForeColor = SystemColors.ScrollBar;
            //Prts_nme_txt.Text = "Enter Name";
            Prts_mdl_txt.ForeColor = SystemColors.ScrollBar;
            Prts_mdl_txt.Text = "Enter Type";
            Prts_ID_txt.ForeColor = SystemColors.ScrollBar;
            Prts_ID_txt.Text = "Enter ID";
            Prts_Price_txt.ForeColor = SystemColors.ScrollBar;
            Prts_Price_txt.Text = "Enter Price";
            Prt_pcturebx.Image = null;
            Prts_srsh_pnl.Visible = false;
        }

        private void Acc_mngmntPage_Leave(object sender, EventArgs e)
        {
            //Acc_ID_txt.ForeColor = SystemColors.ScrollBar;
            //Acc_ID_txt.Text = "Enter ID";
            Acc_Nme_txt.ForeColor = SystemColors.ScrollBar;
            Acc_Nme_txt.Text = "Enter Name";
            Acc_Price_txt.ForeColor = SystemColors.ScrollBar;
            Acc_Price_txt.Text = "Enter Price";
            Acc_Mdl_txt.ForeColor = SystemColors.ScrollBar;
            Acc_Mdl_txt.Text = "Enter Model";
            Acc_pcturebx.Image = null;
            Acc_srsh_panel.Visible = false;
        }

        private void Car_srch_ext_btn_Click(object sender, EventArgs e)
        {
            Car_srsh_pnl.Visible = false;
            Car_srsh_txt.ForeColor = SystemColors.ScrollBar;
            Car_srsh_txt.Text = "Enter Name";
        }

        private void Cars_mngmntPage_Leave(object sender, EventArgs e)
        {
            Cars_pcturbx.Image = null;
            Car_nme_txt.ForeColor = SystemColors.ScrollBar;
            Car_nme_txt.Text = "Enter Name";
            Car_ID_txt.ForeColor = SystemColors.ScrollBar;
            Car_ID_txt.Text = "Enter ID";
            Car_mdl_txt.ForeColor = SystemColors.ScrollBar;
            Car_mdl_txt.Text = "Enter Model";
            Car_price_txt.ForeColor = SystemColors.ScrollBar;
            Car_price_txt.Text = "Enter Price";
            CarEng_txt.Text = " ";
            Car_mnul_txt.Text = " ";
            Car_mxspeed_txt.Text = " ";
            Car_srsh_pnl.Visible = false;
            Car_yer_combobx.Text = " ";
        }

        private void Acc_srch_ext_btn_Click(object sender, EventArgs e)
        {
            Acc_srsh_panel.Visible = false;
            dataGridView3.Visible = false;
            Acc_srsh_txt.ForeColor = SystemColors.ScrollBar;
            Acc_srsh_txt.Text = "Enter Name";
        }

        private void Cars_mngmnt_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Car_price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Car_ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prt_pcturebx_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Prts_rprt_pnl.BackColor = Color.FromArgb(180, 0, 0, 0);
          //  Orederspanel.BackColor = Color.FromArgb(180, 0, 0, 0);
            acc_Mngmnt_panel.BackColor = Color.FromArgb(180, 0, 0, 0);
            Prts_mngmnt_pnl.BackColor = Color.FromArgb(180, 0, 0, 0);
            Prts_mngmnt_pnl.BackColor = Color.FromArgb(180, 0, 0, 0);
            Acc_rprt_panel.BackColor = Color.FromArgb(180, 0, 0, 0);
            Cars_rprt_pnl.BackColor = Color.FromArgb(180, 0, 0, 0);
            Cus_rprt_pnl.BackColor = Color.FromArgb(180, 0, 0, 0);
           // Pswrd_pnl.BackColor = Color.FromArgb(180, 0, 0, 0);
            Ca_mngmnt_pnl.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void AccID_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Acc_srsh_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ca_mngmnt_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acc_Price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prts_mdl_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prts_Price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Prts_Price_txt.ForeColor == SystemColors.ScrollBar)
            {
                Prts_Price_txt.ForeColor = Color.Black;
                Prts_Price_txt.Clear();
            }
        }

        private void Prts_Price_txt_Leave(object sender, EventArgs e)
        {
            if (Prts_Price_txt.Text == "")
            {
                Prts_Price_txt.ForeColor = SystemColors.ScrollBar;
                Prts_Price_txt.Text = "Enter New Password";
            }
        }

        private void Cars_pcturbx_Click(object sender, EventArgs e)
        {

        }

        private void Car_yer_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car_srsh_pnl.Visible = false;
            dataGridView1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.Visible = false;
            Car_srsh_pnl.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            String query = "DELETE FROM car_inf WHERE car_id='"+textBox4.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DELETE DONE");
            dataGridView1.Visible = false;
            panel1.Visible = false;
            Car_srsh_pnl.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Car_srsh_txt.ForeColor == SystemColors.ScrollBar || textBox1.ForeColor == SystemColors.ScrollBar)
            {
                MessageBox.Show("Please enter car name to searsh for");
            }
            else
            {


                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();

                DataTable dt = new DataTable();
                String x = Car_srsh_txt.Text;
                String query = "SELECT  *FROM car_inf WHERE make ='" + Car_srsh_txt.Text + "' AND car_model='" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;

                Car_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Car_srsh_txt.Text = "Enter Name";
                textBox1.Text = "";
                //    panel1.Visible = true;



                panel1.Visible = true;

                button4.Visible = false;
            }
       
        }

        private void parts_mngmntPage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Car_srsh_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Prts_srsh_txt.ForeColor == SystemColors.ScrollBar)
            {
                MessageBox.Show("Please enter part name to searsh for");
            }
            else
            {
                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();

                DataTable dt = new DataTable();
                String query = "SELECT  *FROM part_car WHERE partname LIKE'%" + Prts_srsh_txt.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dataGridView2.DataSource = dt;

                Prts_srsh_txt.ForeColor = SystemColors.ScrollBar;
                Prts_srsh_txt.Text = "Enter Name";
                dataGridView2.Visible = true;
                panel2.Visible = true;
                button5.Visible = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Prts_srsh_pnl.Visible = false;
            dataGridView2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "") { MessageBox.Show("Enter ID "); }
            else
            {

                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "DELETE FROM part_car WHERE part_id='" + textBox5.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETE DONE");
                panel2.Visible = false;
                Prts_srsh_pnl.Visible = false;
                dataGridView2.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();

            DataTable dt = new DataTable();
            String query = "SELECT  *FROM accessories_inf WHERE accessories_name LIKE'%" + Acc_srsh_txt.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            dataGridView3.DataSource = dt;


            Acc_srsh_txt.ForeColor = SystemColors.ScrollBar;
            Acc_srsh_txt.Text = "Enter Name";
            dataGridView3.Visible = true;
            panel3.Visible = true;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Acc_srsh_panel.Visible = false;
            dataGridView3.Visible = false;
            Acc_srsh_txt.ForeColor = SystemColors.ScrollBar;
            Acc_srsh_txt.Text = "Enter Name";
            panel3.Visible = false;
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "") { MessageBox.Show("Enter ID of Part"); }
            else {

                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                String query = "DELETE FROM accessories_inf WHERE accessories_id='" + textBox6.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETE DONE");
                dataGridView3.Visible = false;
                panel3.Visible = false;
                Acc_srsh_panel.Visible = false;
            
            
            
            }
        }

        private void Acc_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Acc_rprt_panel_Paint(object sender, PaintEventArgs e)
        {

            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();

            DataTable dt = new DataTable();
            String query = "SELECT  *FROM accessories_inf ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            Acc_GridView.DataSource = dt;

        }

        private void Prts_rprt_pnl_Paint(object sender, PaintEventArgs e)
        {

            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();

            DataTable dt = new DataTable();
            String query = "SELECT  *FROM part_car ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            Prts_rprt_dataGridView.DataSource = dt;
        }

        private void Cars_rprt_pnl_Paint(object sender, PaintEventArgs e)
        {

            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();

            DataTable dt = new DataTable();
            String query = "SELECT  *FROM car_inf ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            Cars_rprt_dataGridView.DataSource = dt;
        }

        private void Cus_rprt_pnl_Paint(object sender, PaintEventArgs e)
        {

            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();

            DataTable dt = new DataTable();
            String query = "SELECT  *FROM customer_inf ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            Cus_rprt_dataGridView.DataSource = dt;
        }

        private void OrdersPage_Click(object sender, EventArgs e)
        {

        }

        private void Orederspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersPage_Click_1(object sender, EventArgs e)
        {

        }
        }
    }
    

