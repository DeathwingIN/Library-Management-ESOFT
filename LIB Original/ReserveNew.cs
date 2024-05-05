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
    public partial class ReserveNew : Form
    {
        public ReserveNew(string UserID)
        {
            InitializeComponent();
            txt_UserID.Text = UserID;
            lbl_UserID.Hide();
            txt_UserID.Hide();
            pkr_ReservedDate.Enabled = false;
        }


        //Variables
        int count;


        //All Book List
        private void btn_BookiIst_Click(object sender, EventArgs e)
        {
            BookList bklist = new BookList();
            bklist.Show();
        }


        //Serch Book 
        private void btn_SerchBook_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //Variable for BookName
                string bnm = textBox1.Text;

                //Build Sql Connection
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //Sql command
                cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Catalog_Table] Where Catalog_ID = '" + bnm + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                // Data to text Boxes
                if (DS.Tables[0].Rows.Count != 0)
                {
                    txt_BookName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txt_Author.Text = DS.Tables[0].Rows[0][2].ToString();
                    txt_Quantity.Text = DS.Tables[0].Rows[0][13].ToString();
                    txt_Subject.Text = DS.Tables[0].Rows[0][14].ToString();
                    txt_type.Text = DS.Tables[0].Rows[0][7].ToString();
                    txt_Catergory.Text = DS.Tables[0].Rows[0][6].ToString();
                    txt_Language.Text = DS.Tables[0].Rows[0][5].ToString();                    
                }
                else
                {
                    //Clear Text Boxes if User enter invali Id          
                    txt_BookName.Clear();
                    txt_Author.Clear();
                    txt_Quantity.Clear();
                    txt_Subject.Clear();
                    txt_type.Clear();
                    txt_Catergory.Clear();
                    txt_Language.Clear();
                    textBox1.Clear();

                    //Message Box for Invalid User ID
                    MessageBox.Show("Invalid Catalog ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Refresh Button
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_BookName.Clear();
            txt_Author.Clear();
            txt_Quantity.Clear();
            txt_Subject.Clear();
            txt_type.Clear();
            txt_Catergory.Clear();
            txt_Language.Clear();
            textBox1.Clear();

        }


        //Reserve Button
      
        private void btn_Reserve_Click(object sender, EventArgs e)
        {

            //cleck book mdetails entered
            if (txt_BookName.Text != "")
            {
                string nic = txt_UserID.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select  count (User_ID) FROM Borrowing_Table Where User_ID = '" + nic + "' and Returnd_Date is null ";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);
                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                
                //If all data Entered Check counts
                if (count <= 4)

                {
                    int bookq = Convert.ToInt32(txt_Quantity.Text);
                    if (bookq >0)
                    {
                        /// <summary>
                        ///Issue Book
                        /// </summary>
                        /// <Author>Imesh Nirmal</Author>
                        /// <DateCreated>23-05-2021</DateCreated>

                        DateTime redate = Convert.ToDateTime(pkr_ReservedDate.Text);
                        string uid = txt_UserID.Text;
                        string bid = textBox1.Text;
                        string bkname = txt_BookName.Text;                   

                        //Write in data base
                        con.Open();
                        cmd.CommandText = "insert into Borrowing_Table (User_ID,Catlog_ID,Rserved_Date,Book_Name) values ('" + uid + "', '" + bid + "','" + redate + "','" + bkname + "')";
                       // cmd.CommandText = "update Catalog_Table set Quentity = Quentity - 1 where Catalog_ID = ('" + bid + "') ";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //Write in data base
                        con.Open();             
                        cmd.CommandText = "update Catalog_Table set Quentity = Quentity - 1 where Catalog_ID = ('" + bid + "') ";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //Issued Book Successfull
                        MessageBox.Show("Reserved Succesfull  ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Clear Book Details
                        txt_BookName.Clear();
                        txt_Author.Clear();
                        txt_Quantity.Clear();
                        txt_Subject.Clear();
                        txt_type.Clear();
                        txt_Catergory.Clear();
                        txt_Language.Clear();
                        textBox1.Clear();

                    }
                    else
                    {
                        //Max Amount of books  Quantity Reached
                        MessageBox.Show("Book Max Quantity Reached ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
