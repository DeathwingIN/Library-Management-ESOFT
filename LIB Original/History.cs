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
    public partial class History : Form
    {
        //Variables
        int count;
        string bkname;
        string redate;
        Int64 rowid;
        string brdate;


        public History(string UserID)
        {
            InitializeComponent();
            txt_UserID.Text = UserID;
            lbl_UserID.Hide();
            txt_UserID.Hide();
            datagridview();
        }


        //Data Grid View
        private void datagridview()
        {
            //Variable for UserId
            string nic = txt_UserID.Text;

            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Search for Borowing data
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where User_ID = '" + nic + "' and Returnd_Date IS NOT NULL  and Borrowed_Date  IS NOT NULL ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            //Count All Borrowing Books
            cmd.Connection = con;
            cmd.CommandText = "select  count (User_ID) FROM Borrowing_Table Where User_ID = '" + nic + "' and Returnd_Date IS NOT NULL  and Borrowed_Date  IS NOT NULL ";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);
            count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

            if (DS.Tables[0].Rows.Count != 0)
            {
                gdr_CompleteBooks.DataSource = DS.Tables[0];
            }

            //Show count in Text box
            txt_total.Text = count.ToString();
        }
        

        //Change Data According To Mouse Click
        private void gdr_CompleteBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdr_CompleteBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(gdr_CompleteBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                bkname = gdr_CompleteBooks.Rows[e.RowIndex].Cells[10].Value.ToString();
                brdate = gdr_CompleteBooks.Rows[e.RowIndex].Cells[6].Value.ToString();
                redate = gdr_CompleteBooks.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            //show Data in Text Boxes
            txt_BookName.Text = bkname;
            txt_ReturnedDate.Text = redate;
            txt_IssueDate.Text = brdate;         
        }
    }
}
