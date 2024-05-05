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
    public partial class UserBorrowings : Form
    {
        //define variables for show data in text boxes
        string bkname;
        string isdate;
        string redate;
        string rcount;
        Int64 rowid;

        public UserBorrowings(string UserID)
        {
            InitializeComponent();
            txt_UserID.Text = UserID;
            lbl_UserID.Hide();
            txt_UserID.Hide();
            datagridview();
        }


        //DataGrid View
        private void datagridview()
        {
            //Variable for UserId
            string nic = txt_UserID.Text;

            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Search for borowing data
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where User_ID = '" + nic + "' and Returnd_Date IS NULL and Borrowed_Date IS NOT NULL ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                gdr_Borrowings.DataSource = DS.Tables[0];
            }
            else
            {
                //Message Box for Invalid User ID
                MessageBox.Show("Invalid User ID OR No Information Found  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       //Cell Click
        private void gdr_Borrowings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdr_Borrowings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(gdr_Borrowings.Rows[e.RowIndex].Cells[0].Value.ToString());
                bkname = gdr_Borrowings.Rows[e.RowIndex].Cells[10].Value.ToString();
                isdate = gdr_Borrowings.Rows[e.RowIndex].Cells[6].Value.ToString();
                redate = gdr_Borrowings.Rows[e.RowIndex].Cells[7].Value.ToString();
                rcount = gdr_Borrowings.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            txt_BookName.Text = bkname;
            txt_IssueDate.Text = isdate;
            txt_Renewcount.Text = rcount;
            txt_Returndate.Text = redate;
        }

        
        //Renew 3 more days
        private void btn_Renew3Days_Click(object sender, EventArgs e)
        {
            if (txt_BookName.Text != "")
            {
                int num = int.Parse(this.txt_Renewcount.Text);
                if (num<=2)
                {
                    //Build Sql Connection
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                  
                    DateTime returndate = Convert.ToDateTime(txt_Returndate.Text);
                    string dateInString = txt_Returndate.Text;
                    DateTime startDate = DateTime.Parse(dateInString);
                    DateTime expiryDate = startDate.AddDays(3);

                    //Update User Table
                    con.Open();
                    cmd.CommandText = "update Borrowing_Table set Renew_Count = Renew_Count + 1,Actual_ReturnDate = '" + expiryDate + "' where User_ID = ('" + txt_UserID.Text + "') and Entry_ID = " + rowid + " ";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //Message Box if success
                    MessageBox.Show("Renew Successfull ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datagridview();
                    txt_BookName.Clear();
                    txt_IssueDate.Clear();
                    txt_Renewcount.Clear();
                    txt_Returndate.Clear();
                }

                else
                {
                    MessageBox.Show("Renew Unsuccessfull , Max Limit Reached !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select the Book ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
