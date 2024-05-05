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
    public partial class FeePayments : Form
    {
        public FeePayments()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Variables
            string nic = txt_search.Text;
            string fine = txt_Payments.Text;

            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Sql Command For Search User 
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[User_Table] Where User_ID = '" + nic + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            // Data to text Boxes
            if (DS.Tables[0].Rows.Count != 0)
            {
                txt_FirstNAme.Text = DS.Tables[0].Rows[0][3].ToString();
                txt_LastName.Text = DS.Tables[0].Rows[0][4].ToString();
                txt_Nic.Text = DS.Tables[0].Rows[0][2].ToString();
                textBox4.Text = DS.Tables[0].Rows[0][12].ToString();               
            }
            else
            {
                //Clear Text Boxes if User enter invali Id
                textBox4.Clear();
                txt_FirstNAme.Clear();
                txt_LastName.Clear();
                txt_Nic.Clear();
                textBox5.Clear();

                //Message Box for Invalid User ID
                MessageBox.Show("Invalid User ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //If Search Box Emphty
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                textBox4.Clear();
                txt_FirstNAme.Clear();
                txt_LastName.Clear();
                txt_Nic.Clear();
                textBox5.Clear();
            }
        }


        //Reset Button
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_Result.Clear();
        }


        //Generate Recipt
        private void btn_receipt_Click(object sender, EventArgs e)
        {
            txt_Result.Clear();
            txt_Result.Text += "******************************\n";
            txt_Result.Text += "****  Fees Receipt System  ****\n";
            txt_Result.Text += "*******************************\n\n";
            txt_Result.Text += " Date : "+ DateTime.Now+"\n\n";
            txt_Result.Text += "Student Name : " + txt_FirstNAme.Text + "" + txt_LastName.Text + "\n\n";
            txt_Result.Text += "NIC :" + txt_Nic.Text + "\n\n";
            txt_Result.Text += "Fee  :" + textBox4.Text + "\n\n";
            txt_Result.Text += "Paid Amount :" + textBox5.Text + "\n\n";
            txt_Result.Text += "\n                  Signature" ;

            //Variable for Fine 
            decimal fine = Convert.ToDecimal(textBox5.Text);
            
            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Sql Command for reduce fees
            con.Open();
            cmd.CommandText = "update User_Table set Cumilative_Fine = Cumilative_Fine -('" + fine + "') where User_ID = '" + txt_search.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //Print Settings
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txt_Result.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }


        //Print Button 
        private void btn_Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
