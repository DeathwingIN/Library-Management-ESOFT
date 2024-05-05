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
    public partial class ADMINUI : Form
    {
        public ADMINUI()
        {
            InitializeComponent();
        }

        //Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //Open Catlog Form
        private void Dashbord_Click(object sender, EventArgs e)
        {
            Catlog cts = new Catlog();
            cts.Show();
        }


        //Open Member Mangement Form
        private void borrowings_Click(object sender, EventArgs e)
        {
            MemberMangement mba = new MemberMangement();
            mba.Show();
        }


        //Open Issue Book Form
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks isa = new IssueBooks();
            isa.Show();
        }


        //Open Return Book Form 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rbt = new ReturnBook();
            rbt.Show();
        }


        //Open Complete Book Form 
        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }


        //Open Calender 
        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calender cal = new Calender();
            cal.Show();
        }


        //Open Fee Payments Form 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FeePayments feen = new FeePayments();
            feen.Show();
        }
    }
}
