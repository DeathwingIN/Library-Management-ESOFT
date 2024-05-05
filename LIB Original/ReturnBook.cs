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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            txt_BookID.Hide();
        }


        //Serach Button
        private void btn_SerchUser_Click(object sender, EventArgs e)
        {
            datagridview(); 
        }


        //define variables for show data in text boxes
        string bkname;
        string isdate;
        string acredate;
        string fine;
        Int64 rowid;
        string bkid;


        //Borrowing Button
        private void gdr_Borrowings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (gdr_Borrowings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(gdr_Borrowings.Rows[e.RowIndex].Cells[0].Value.ToString());
                bkname = gdr_Borrowings.Rows[e.RowIndex].Cells[10].Value.ToString();
                isdate = gdr_Borrowings.Rows[e.RowIndex].Cells[6].Value.ToString();
                acredate = gdr_Borrowings.Rows[e.RowIndex].Cells[7].Value.ToString();
                fine = gdr_Borrowings.Rows[e.RowIndex].Cells[3].Value.ToString();
                bkid = gdr_Borrowings.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            txt_BookName.Text = bkname;
            pkr_ReturnBefore.Text = acredate;
            txt_IssueDate.Text = isdate;
            txt_Fine.Text = fine;
            txt_BookID.Text = bkid;
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            pkr_ReturnBefore.Enabled = false;
        }


        //Fine Calculate
        private void FineCalculting()
        {
            string nic = txt_UserId.Text;

            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

           // cmd.CommandText = "select Actual_ReturnDate FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where User_ID = '" + nic + "'";
           // SqlDataAdapter DA = new SqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
             //DA.Fill(DS);

            //date difference
            DateTime d1 = Convert.ToDateTime(pkr_ReturnedDate.Text);
            DateTime d2 = Convert.ToDateTime(pkr_ReturnBefore.Text);

            double NrOfDays;

            TimeSpan t = d1 - d2;
           Convert.ToInt32 ( NrOfDays = t.TotalDays);
            double fine1;
             if( NrOfDays > 0)
            {
                fine1 = NrOfDays * 5.00;

                //Write in borrowing table
                con.Open();
                cmd.CommandText = "update Borrowing_Table set Fine = ('" + fine1 + "') where User_ID = ('" + nic + "')  and Entry_ID = ('" + rowid + "') ";
                cmd.ExecuteNonQuery();
                con.Close();

                //Write in User table
                con.Open();
                cmd.CommandText = "UPDATE T1 SET T1.Cumilative_Fine = Cumilative_Fine + (SELECT SUM(T2.Fine) FROM Borrowing_Table T2 WHERE T2.User_ID = T1.User_ID AND Entry_ID = ('" + rowid + "'))FROM User_Table T1 where User_ID =  ('" + nic + "') ";
                con.Close();
            }         
        }

        //Fine Button
        private void btn_fine_Click(object sender, EventArgs e)
        {
            FineCalculting();
            datagridview();
        }


        //DataGrid View
        private void datagridview()
        {
            //Variable for UserId
            string nic = txt_UserId.Text;

            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Search for borowing data
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where User_ID = '" + nic + "' and Returnd_Date IS NULL ";
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

        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Variables 
            DateTime redate = Convert.ToDateTime(pkr_ReturnedDate.Text);

            //Write in borrowing table
            con.Open();
            cmd.CommandText = "update Borrowing_Table set Returnd_Date = ('" + redate + "') where User_ID = ('" + txt_UserId.Text + "') and Entry_ID = "+rowid+" ";
            cmd.ExecuteNonQuery();
            con.Close();

            //Add Reurn Book Quantity
            string bid = txt_BookID.Text;
            con.Open();
            cmd.CommandText = "update Catalog_Table set Quentity = Quentity + 1 where Book_Name = '" + bid + "' ";
            cmd.ExecuteNonQuery();
            con.Close(); 

           //Message Box if success
             MessageBox.Show("Book Reurned Successfull ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
            FineCalculting();
            datagridview();
        }

        
        //Clear Data 
        private void txt_UserId_TextChanged(object sender, EventArgs e)
        {
            if(txt_UserId.Text == "")
            {
                txt_BookName.Clear();
                txt_IssueDate.Clear();
                pkr_ReturnBefore.ResetText();
                gdr_Borrowings.DataSource = null;
                txt_BookID.Clear();
            }
        }

        
        //Clear Data
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_UserId.Clear();
        }


        //close Button
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
