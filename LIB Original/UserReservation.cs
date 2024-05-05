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
    public partial class UserReservation : Form
    {
        //define variables for show data in text boxes
        string bkname;
        string redate;
        Int64 rowid;
        string bkid;

        public UserReservation(string UserID)
        {
            InitializeComponent();
            txt_UserID.Text = UserID;
            lbl_UserID.Hide();
            txt_UserID.Hide();
            datagridview();
            txt_GetBefore.Enabled = false;
            pkr_ResrvedDate.Enabled = false;
            txt_BookId.Hide();
        }


        //DataGridView
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
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where User_ID = '" + nic + "' and Rserved_Date IS NOT NULL ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                gdr_Borrowings.DataSource = DS.Tables[0];              
            }           
        }


        //Cell Click
        private void gdr_Borrowings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdr_Borrowings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(gdr_Borrowings.Rows[e.RowIndex].Cells[0].Value.ToString());
                bkname = gdr_Borrowings.Rows[e.RowIndex].Cells[10].Value.ToString();           
                redate = gdr_Borrowings.Rows[e.RowIndex].Cells[7].Value.ToString();  
                bkid = gdr_Borrowings.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            txt_BookName.Text = bkname;
            pkr_ResrvedDate.Text = redate;
            txt_BookId.Text = bkid;

            // Get Before Date Settings
            string retdate = pkr_ResrvedDate.Text;
            DateTime dt = Convert.ToDateTime(retdate);
            DateTime newDate = dt.AddDays(7);
            txt_GetBefore.Text = newDate.ToString();
        }


        //Cancel Button
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (txt_BookName.Text != "")
            {
                    //Build Sql Connection
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    //Update User Table
                    con.Open();
                    cmd.CommandText = "update Borrowing_Table set Rserved_Date = NULL where User_ID = ('" + txt_UserID.Text + "') and Entry_ID = " + rowid + " ";
                    cmd.ExecuteNonQuery();
                    con.Close();

                   //Quantity Update
                    string bid = txt_BookId.Text;
                    con.Open();
                    cmd.CommandText = "update Catalog_Table set Quentity = Quentity + 1 where Book_Name = '" + bid + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //Message Box if success
                    MessageBox.Show("Cancel Successfull ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datagridview();
                    txt_BookName.Clear();
                    txt_GetBefore.Clear();
                    txt_BookId.Clear();
            }
            else
            {
                MessageBox.Show("Select the Book ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //////////////////////////////////////////////////////////
    }
}
