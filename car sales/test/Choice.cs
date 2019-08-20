using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    public partial class choice : Form
    {
        public choice()
        {
            InitializeComponent();
        }

        private void User_btn_Click(object sender, EventArgs e)
        {
            Form2 userlogin = new Form2();
            userlogin.Show();
         

           
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            admin_lgn adminlogin = new admin_lgn();
            adminlogin.Show();
            
             
        }

        private void choice_Load(object sender, EventArgs e)
        {
           
            choicepl.BackColor = Color.FromArgb(180, 0, 0, 0);
        }
    }
}
