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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
            lbl_Active.Visible = false;
            lbl_Deactive.Visible = false;
        }


        //Variables
        int count;
        int countb;

        /// <summary>
        ///Search User
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_SerchUser_Click(object sender, EventArgs e)
        {
            if(txt_UserId.Text != "")
            {
                //Variable for UserId
                string nic = txt_UserId.Text;

                //Build Sql Connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //Sql Command 
                cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[User_Table] Where User_ID = '" + nic + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //---------------------------------------------------------------------------------------------------------
                // check whether reach the max ammount of book issued for id 

                cmd.CommandText = "select  count (User_ID) FROM Borrowing_Table Where User_ID = '" + nic + "' and Returnd_Date is null ";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);
                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                //---------------------------------------------------------------------------------------------------------

                // Data to text Boxes
                if (DS.Tables[0].Rows.Count != 0 )
                {
                    txt_UserName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txt_FirstName.Text = DS.Tables[0].Rows[0][3].ToString();
                    txt_LastName.Text = DS.Tables[0].Rows[0][4].ToString();
                    txt_Faculty.Text = DS.Tables[0].Rows[0][9].ToString();
                    txt_NIC.Text = DS.Tables[0].Rows[0][2].ToString();
                    txt_telephoneNumber.Text = DS.Tables[0].Rows[0][6].ToString();
                    txt_Role.Text = DS.Tables[0].Rows[0][10].ToString();
                    txt_Fine.Text = DS.Tables[0].Rows[0][12].ToString();
                    txt_Status.Text  = DS.Tables[0].Rows[0][13].ToString();

                    // Show Active Or Deactive 
                    if (txt_Status.Text == "1")
                    {
                        txt_Status.Visible = false;
                        lbl_Active.Visible = true;
                        lbl_Deactive.Visible = false;
                    }
                    else
                    {
                        txt_Status.Visible = false;
                        lbl_Active.Visible = false;
                        lbl_Deactive.Visible = true;
                    }
                }
                else
                {
                    //Clear Text Boxes if User enter invali Id
                    txt_UserName.Clear();
                    txt_FirstName.Clear();
                    txt_LastName.Clear();
                    txt_Faculty.Clear();
                    txt_NIC.Clear();
                    txt_telephoneNumber.Clear();
                    txt_Role.Clear();
                    txt_Fine.Clear();
                    txt_Status.Clear();
                    lbl_Active.Visible = false;
                    lbl_Deactive.Visible = false;
                    txt_Status.Visible = true;

                    //Message Box for Invalid User ID
                    MessageBox.Show("Invalid User ID ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

     
        /// <summary>
        ///Search Book
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_SerchBook_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                //Variable for BookName
                string bnm = textBox1.Text;

                //Build Sql Connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //Sql Command
                cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Catalog_Table] Where Catalog_ID = '" + bnm + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //---------------------------------------------------------------------------------------------------------
                // check whether reach the max ammount of book Quantity

                cmd.CommandText = "select  count (Catlog_ID) FROM [LIB Managemnt].[dbo].[Borrowing_Table] Where Catlog_ID = '" + bnm + "' and Returnd_Date is null ";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                countb = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                //---------------------------------------------------------------------------------------------------------

                // Data to text Boxes
                if (DS.Tables[0].Rows.Count != 0)
                {
                    txt_BookName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txt_Author.Text = DS.Tables[0].Rows[0][7].ToString();
                    txt_Quantity.Text = DS.Tables[0].Rows[0][13].ToString();
                }
                else
                {
                    //Clear Text Boxes if User enter invali Id
                    txt_Quantity.Clear();
                    txt_BookName.Clear();
                    txt_Author.Clear();

                    //Message Box for Invalid User ID
                    MessageBox.Show("Invalid Catalog ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Issue Book Button 
        private void btn_IssueBook_Click(object sender, EventArgs e)
        {
            // Check User Details entered
            if (txt_UserName.Text != "")
            {
                //cleck book mdetails entered
                if (txt_BookName.Text != "")
                {
                    //If all data Entered Check counts
                    if(count <= 3)
                    {
                        int bookq = Convert.ToInt32(txt_Quantity.Text);
                        if (bookq >= countb)
                        {                                                       
                                /// <summary>
                                ///Issue Book
                                /// </summary>
                                /// <Author>Imesh Nirmal</Author>
                                /// <DateCreated>23-05-2021</DateCreated>

                                DateTime issuedate = Convert.ToDateTime(pkr_IssueDate.Text);
                                string uid = txt_UserId.Text;
                                string bid = textBox1.Text;
                                string bkname = txt_BookName.Text;

                                // Return Before Code
                                string dateInString = pkr_IssueDate.Text;
                                DateTime startDate = DateTime.Parse(dateInString);
                                DateTime expiryDate = startDate.AddDays(14);

                                //Build Sql Connection
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = con;

                                //Write in Borrowing Table
                                con.Open();
                                cmd.CommandText = "insert into Borrowing_Table (User_ID,Catlog_ID,Borrowed_Date,Actual_ReturnDate,Book_Name) values ('" + uid + "', '" + bid + "','" + issuedate + "','" + expiryDate + "','" + bkname + "')";
                                cmd.ExecuteNonQuery();
                                con.Close();

                                //Write in Catlog Table
                                con.Open();                            
                                cmd.CommandText = "update Catalog_Table set Quentity = Quentity - 1 where Catalog_ID = ('" + bid + "') ";
                                cmd.ExecuteNonQuery();
                                con.Close();

                                //Issued Book Successfull
                                MessageBox.Show("Book Issued ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Clear Book Details
                                textBox1.Clear();
                                txt_UserId.Clear();                                                                             
                        }
                        else
                        {
                            //Max Amount of books  Quantity Reached
                            MessageBox.Show("Not Available ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Max Amount of books Reached
                        MessageBox.Show("User Max Amount Reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                     
                }
                else
                {
                    //error for emphty book details
                    MessageBox.Show("Enter Book Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // error for emphty user details
                MessageBox.Show("Enter User Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Clear Data If user ID Emphty
        private void txt_UserId_TextChanged(object sender, EventArgs e)
        {
            if(txt_UserId.Text == "")
            {
                txt_UserName.Clear();
                txt_FirstName.Clear();
                txt_LastName.Clear();
                txt_NIC.Clear();
                txt_telephoneNumber.Clear();
                txt_Status.Clear();
                txt_Role.Clear();
                txt_Faculty.Clear();
                txt_Fine.Clear();
            }          
        }


        //Clear Data if Book Id emphty 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                txt_Author.Clear();
                txt_BookName.Clear();
                txt_Quantity.Clear();
            }
        }


        //Refresh Buton
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_UserId.Clear();
            textBox1.Clear();
        }


        //Exit Button
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure ? ","Confirmation ",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }

        }
    }
}
 