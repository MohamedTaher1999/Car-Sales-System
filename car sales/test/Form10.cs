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
    public partial class Form10 : Form
    {
        String lab="";
        List<carclass> car = new List<carclass>();
        List<partclass> part = new List<partclass>();
        List<Accessories_Class> accessories = new List<Accessories_Class>();
        List<carclass> temp = new List<carclass>();
        List<carclass> list2 = new List<carclass>();
        int xx;
        public Form10()
        {
            // TODO: Complete member initialization
            this.BackgroundImage = Properties.Resources._4210;
            InitializeComponent();
            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
            cardb();
            ADD(car);
            partdb();
            ADDPARTh(part);
            Accessoriesdb();
            ADDACCESSORIESh(accessories);
        }

        public Form10(int x)
        {       
            // TODO: Complete member initialization
            this.BackgroundImage = Properties.Resources._4210;
            InitializeComponent();
             xx = x;
            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
            cardb();
            ADD(car);
            partdb();
            ADDPARTh(part);
            Accessoriesdb();
            ADDACCESSORIESh(accessories);
        }

     

        void cardb() {

            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            car.Clear();

            string query = "SELECT *FROM car_inf where customerid is null";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {

                carclass c = new carclass {car_id=reader.GetInt32(0),makke=reader.GetString(1),price=reader.GetString(2),pic= (byte[])reader["picture"],
                                           car_model = reader.GetString(4),
                                           engine = reader.GetString(5),
                                           weight = reader.GetString(6),
                                           manufacturedstate = reader.GetString(7),
                                           yearestablished = reader.GetString(8),
                                           maxspeed = reader.GetString(9),
                                           tank = reader.GetString(11),
                                           details = reader.GetString(12),
                                           customer_id=xx
                                          // color = reader.GetString(12),
                
                
                };
                car.Add(c);
               
                }
            
            
            
            }


        void partdb() {
            part.Clear();
            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = "SELECT *FROM part_car where customerid is null";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {


                partclass p = new partclass { 
                part_id=reader.GetInt32(0),
                partname=reader.GetString(1),
                type = reader.GetString(2),
                pic = (byte[])reader["pictuer"],
                price = reader.GetString(4),
                 customer_id=xx
                
                
                };
                part.Add(p);
            
            }
        
        
        
        }
        void Accessoriesdb()
        {
            accessories.Clear();
            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            accessories.Clear();
            string query = "SELECT *FROM accessories_inf where customerid is null ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Accessories_Class a = new Accessories_Class
                {
                    accessories_id = reader.GetInt32(0),
                    accessories_name = reader.GetString(1),
                    accessories_type = reader.GetString(2),
                    accessories_picture = (byte[])reader["picture"],
                    accessories_price = reader.GetString(4),
                    customer_id=xx
                };

                accessories.Add(a);
            }
        }


        void ADD(List<carclass> list) {

            flp1.Controls.Clear();
            foreach (carclass s in list) {


                ShowUc u = new ShowUc();
            //    u.BackColor = System.Drawing.Color.Khaki;
                u.Name = "user" + u;
                u.addd(s);
               
                u.My_click += d_My_click;
                flp1.Controls.Add(u);
            }
            
        
        }
        void ADDACCESSORIESh(List<Accessories_Class> list)
        {
           // flp1.Controls.Clear();
            foreach (Accessories_Class a in list)
            {
                ShowUc u = new ShowUc();
              //  u.BackColor = System.Drawing.Color.Khaki;
                u.Name = "user" + u;
                u.addaccess(a);
                u.My_click += d_My_click;
                flp1.Controls.Add(u);
            }
        }
        void ADDPARTh(List<partclass> list)
        {
           // flp1.Controls.Clear();
            foreach (partclass p in list)
            {
                ShowUc u = new ShowUc();
                //u.BackColor = System.Drawing.Color.Khaki;
                u.Name = "user" + u;
                u.adddpart(p);
                u.My_click += d_My_click;
                flp1.Controls.Add(u);


            }


        }

        void ADDACCESSORIES(List<Accessories_Class> list)
        {
            flp4.Controls.Clear();
            foreach (Accessories_Class a in list)
            {
                ShowUc u = new ShowUc();
               // u.BackColor = System.Drawing.Color.Khaki;
                u.Name = "user" + u;
                u.addaccess(a);
                u.My_click += d_My_click;
                flp4.Controls.Add(u);
            }
        }

        void ADDCAR(List<carclass> list)
        {

            flpcar.Controls.Clear();
            foreach (carclass s in list)
            {


                ShowUc u = new ShowUc();
               // u.BackColor = System.Drawing.Color.Khaki;
                u.Name = "user" + u;
                u.addd(s);
                u.My_click += d_My_click;
                flpcar.Controls.Add(u);
            }


        }

        void ADDPART(List<partclass> list) {
            flppart.Controls.Clear();
            foreach (partclass p in list) {
                ShowUc u = new ShowUc();
              //  u.BackColor = System.Drawing.Color.Khaki;
                u.Name = "user" + u;
                u.adddpart(p);
                u.My_click += d_My_click;
                flppart.Controls.Add(u);
            
            
            }
        
        
        }
        
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._4210);
          //  b1.Add(Properties.Resources.خلفيات_سيارات_جميلة_2);
            int index = DateTime.Now.Second % 1;
            this.BackgroundImage = b1[index];
        }

        ShowUc items(int r4)
        {
            ShowUc d = new ShowUc();
            
            d.Name = " control" + r4.ToString();
            d.Margin = new Padding(5);
            d.My_click += d_My_click;
            
            return d;
        }
        int o = 0, n = 0;
        private List<carclass> list;
        Label Addlabel(int r)
        {
            Label b = new Label();
           
            b.Name = "lab" + b.ToString();
            b.ForeColor = Color.Black;
            b.BackColor = Color.Silver;
            b.Font = new Font("Serif", 12, FontStyle.Bold);
            b.Width = 112;
            b.Height = 23;
            lab = b.Text;
            o = 3;
            b.Location = new Point(o, n + 3);
            n += 30;
            b.Margin = new Padding(5);
            b.BorderStyle = BorderStyle.Fixed3D;
            b.Click += new EventHandler(b_Click);
            return b;
        }

        private void b_Click(object sender, EventArgs e)
        {
            foreach (Control c in flptype1.Controls) 
            {
                if (c is Label)
                {
                    Label b = c as Label;
                    lab = b.Text;

                }            
            
            
            }
            flpcar.Controls.Clear();
            String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            car.Clear();
            string query = "SELECT *FROM car_inf WHERE make ='" + lab + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                carclass c = new carclass
                {
                    car_id = reader.GetInt32(0),
                    makke = reader.GetString(1),
                    price = reader.GetString(2),
                    pic = (byte[])reader["picture"],
                    car_model = reader.GetString(4),
                    engine = reader.GetString(5),
                    weight = reader.GetString(6),
                    manufacturedstate = reader.GetString(7),
                    yearestablished = reader.GetString(8),
                    maxspeed = reader.GetString(9),
                    tank = reader.GetString(11),
                    details = reader.GetString(12)
                    // color = reader.GetString(12),


                };
                car.Add(c);

            }
            ADDCAR(car);

        }

        Label Addlabel2(int r)
        {
            Label j = new Label();
            j.Name = "lab" + j.ToString();
            j.ForeColor = Color.Black;
            j.BackColor = Color.Silver;
            j.Font = new Font("Serif", 12, FontStyle.Bold);
            j.Width = 112;
            j.Height = 23;
            
            o = 3;
            j.Location = new Point(o, n + 3);
            n += 30;
            j.Margin = new Padding(5);
            j.BorderStyle = BorderStyle.Fixed3D;
            j.Click +=j_Click;

            return j;
        }

        private void j_Click(object sender, EventArgs e)
        {
           

        }
        Label Addlabel3(int r)
        {
            Label kk = new Label();
            kk.Name = "lab" + kk.ToString();
            kk.ForeColor = Color.Black;
            kk.BackColor = Color.Silver;
            kk.Font = new Font("Serif", 12, FontStyle.Bold);
            kk.Width = 112;
            kk.Height = 23;
            o = 3;
            kk.Location = new Point(o, n + 3);
            n += 30;
            kk.Margin = new Padding(5);
            kk.BorderStyle = BorderStyle.Fixed3D;
            kk.Click +=kk_Click;

            return kk;
        }

        private void kk_Click(object sender, EventArgs e)
        {
         

        }
        private void d_My_click(object sender, EventArgs e)
        {

           //Form9 hh = new Form9(this.car);
            
           // hh.Show();
        }
        private void Form10_Load(object sender, EventArgs e)
        {

            
            headform10.BackColor = Color.FromArgb(100, 0, 0, 0);
            flp1.BackColor = Color.FromArgb(180, 0, 0, 0);
           flpcar.BackColor = Color.FromArgb(180, 0, 0, 0);
              panel1.BackColor = Color.FromArgb(180, 0, 0, 0);
            flppart.BackColor = Color.FromArgb(180, 0, 0, 0);
            //flptype3.BackColor = Color.FromArgb(180, 0, 0, 0);
            //flptype4.BackColor = Color.FromArgb(180, 0, 0, 0);
            flp4.BackColor = Color.FromArgb(180, 0, 0, 0);
            back.BackColor = Color.FromArgb(180, 0, 0, 0);
               //plordershow.BackColor = Color.FromArgb(180, 0, 0, 0);
            //for (int i = 0; i < 10; i++)
            //{
            //    ShowUc t1 = items(1);
            //    flp1.Controls.Add(t1);


            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void carbtn_Click(object sender, EventArgs e)
        {
            flpcar.Controls.Clear();
            if (carpal.Visible == false)
            {
                orderpl.Visible = false;

                hompl.Visible = false;
                plpart.Visible = false;
                carpal.Visible = true;
                plAccessior.Visible = false;
            }
            cardb();
            ADDCAR(car);
            
                //   ShowUc t5 = items(1);
                //   flpcar.Controls.Add(t5);

                // Label h = Addlabel(1);
                //flptype1.Controls.Add(h);

                String sql = "Data Source=DESKTOP-8TO2TNB;Initial Catalog=car_sales;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = "SELECT make FROM car_inf GROUP BY make   ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Label h = Addlabel(1);
                    h.Text = reader.GetString(0);
                    flptype1.Controls.Add(h);

                
            }
        }

        private void partsbtn_Click(object sender, EventArgs e)
        {
            flppart.Controls.Clear();
            if (plpart.Visible == false)
            {
                orderpl.Visible = false;

                hompl.Visible = false;
                plpart.Visible = true;
                carpal.Visible = false;
                plAccessior.Visible = false;
            }
            partdb();
            ADDPART(part);
           



        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void carpal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            flp4.Controls.Clear();
            Accessoriesdb();
            ADDACCESSORIES(accessories);
            

            if (plAccessior.Visible == false)
            {
                orderpl.Visible = false;
                hompl.Visible = false;
                plpart.Visible = false;
                carpal.Visible = false;
                plAccessior.Visible = true;
            }

            for (int i = 0; i < 10; i++)
            {
               // ShowUc t7 = items(1);
             //   flp4.Controls.Add(t7);
                Label ll = Addlabel3(1);
             //   flptype4.Controls.Add(ll);


            }


        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            if (hompl.Visible == false)
            {
                orderpl.Visible = false;
                hompl.Visible = true;
                plpart.Visible = false;
                carpal.Visible = false;
                plAccessior.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (orderpl.Visible == false)
            {
                orderpl.Visible = true;
                hompl.Visible = false;
                plpart.Visible = false;
                carpal.Visible = false;
                plAccessior.Visible = false;




            }
            MessageBox.Show(list2.Count().ToString());
            

        }


        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button100_Click(object sender, EventArgs e)
        {
            WindowsFormsApp7.Form1 f = new WindowsFormsApp7.Form1();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.choice c = new WindowsFormsApplication2.choice();
            c.Show();
        }

        private void headform10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderpl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        }

       


        }

      
      



