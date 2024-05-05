using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIB_Original
{
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }


        //Form Load
        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Isuued books 
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where Returnd_Date is null ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            //show data in issued books
            gdr_IssuedBooks.DataSource = DS.Tables[0];

            //return books
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where Returnd_Date is not null ";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);

            //show data in return book
            gdr_ReturnedBooks.DataSource = DS.Tables[0];
        }
    }
}
