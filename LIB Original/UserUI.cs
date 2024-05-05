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
    public partial class UserUI : Form
    {
        public UserUI(string UserID)
        {
            InitializeComponent();
            txt_UserID.Text = UserID;
            panel1.Hide();      
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }      
        }


        //Calender
        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calender cal = new Calender();
            cal.Show();
        }


        //Dashbord
        private void Dashbord_Click(object sender, EventArgs e)
        {
            Dashbord dash = new Dashbord(txt_UserID.Text);
            dash.Show();
        }


        //Borrowings
        private void borrowings_Click(object sender, EventArgs e)
        {
            UserBorrowings uborr = new UserBorrowings(txt_UserID.Text);
            uborr.Show();
        }

        
        //Reservations
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserReservation res = new UserReservation(txt_UserID.Text);
            res.Show();
        }


        //ReserveNew
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveNew resnew = new ReserveNew(txt_UserID.Text);
            resnew.Show();
        }


        //History
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History his = new History(txt_UserID.Text);
            his.Show();
        }
    }
}
