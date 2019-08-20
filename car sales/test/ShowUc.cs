using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class ShowUc : UserControl
    {
        List<carclass> temp = new List<carclass>();

        public ShowUc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
    if(this.My_click !=null)
   {
    this.My_click(this,e);
    carclass c = new carclass {car_id=Int32.Parse(label3.Text),makke=label4.Text,customer_id=Int32.Parse(label5.Text) };
    temp.Clear();
    temp.Add(c);

       Form9 hh = new Form9(this.temp);

        hh.Show();
        
     }
   


        }
        public event EventHandler My_click;
  
        private List<carclass> car;

        public void addd(carclass s)
        {
            label1.Text = s.makke;
            label2.Text = s.price;
            label3.Text = s.car_id.ToString() ;
            MemoryStream mem = new MemoryStream(s.pic);
            mem.Seek(0, SeekOrigin.Begin);
            pictureBox1.Image = Image.FromStream(mem);
            label4.Text = "car";
            label5.Text = s.customer_id.ToString();
        }

        public void addaccess(Accessories_Class a)
        {
            label1.Text = a.accessories_name;
            label2.Text = a.accessories_price;
            label3.Text = a.accessories_id.ToString() ;
            MemoryStream mem = new MemoryStream(a.accessories_picture);
            mem.Seek(0, SeekOrigin.Begin);
            pictureBox1.Image = Image.FromStream(mem);
            label4.Text = "access";
            label5.Text = a.customer_id.ToString();
        }
        public void adddpart(partclass p)
        {
            label1.Text = p.partname;
            label2.Text = p.price;
            label3.Text = p.part_id.ToString();
            MemoryStream mem = new MemoryStream(p.pic);
            mem.Seek(0, SeekOrigin.Begin);
            pictureBox1.Image = Image.FromStream(mem);
            label4.Text = "part";
            label5.Text = p.customer_id.ToString();
        }
        private void ShowUc_Load(object sender, EventArgs e)
        {




        }
       
    }
}
