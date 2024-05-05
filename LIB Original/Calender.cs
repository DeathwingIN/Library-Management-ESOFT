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
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
        }


        //Date to Text Box
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_Search.Text = monthCalendar1.SelectionStart.ToString();
        }


        //Close Button 
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
