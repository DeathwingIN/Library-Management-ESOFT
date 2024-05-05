using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemBL;
using System.Data.Common;
using LM__Bs_Logic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows;


namespace LIB_Original
{   
    public partial class Account : Form
    {
        //Declare Variables
        int userID = 18;

        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            grd_CurrentBorrowing.DataSource = AccountBs.ListOutstandigItems(userID);
            grd_History.DataSource = AccountBs.ListBorrowingHistory(userID);
        }
    }
}
