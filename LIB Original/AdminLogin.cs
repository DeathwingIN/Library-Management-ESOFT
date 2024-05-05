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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //Close Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }


        //Clear User Name Text Box
        private void txt_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_UserName.Text == "User Name")
            {
                txt_UserName.Clear();
            }
        }
        

        //Clear Password Text Box
        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Clear();
            }
        }


        //Reset Button
        private void button1_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_UserName.Clear();
        }


        //Login Button 
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //SQl commands
            cmd.CommandText = "SELECT [AdminID],[UserName],[Password] FROM [LIB Managemnt].[dbo].[Admins] Where UserName ='" + txt_UserName.Text + "' and Password = '" + txt_password.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //Open Main Admin UI
            if(ds.Tables[0].Rows.Count!=0)
            {
                this.Hide();
                ADMINUI dsa = new ADMINUI();
                dsa.Show();
            }
            else
            {
                // Message Box For Wrong Inputs
                MessageBox.Show("Wrong User Name or Password", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
