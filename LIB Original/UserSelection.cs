using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIB_Original
{
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
        }


        //Close Button
        private void lbl_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //User Login Form
        private void btn_User_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }


        //User Login Form
        private void PicBox_User_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }


        //Admin Login Form 
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }


        //Admin Login Form 
        private void picBox_Admin_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
