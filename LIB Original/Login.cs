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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //Close Button
        private void picbox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        //Clear Fields 
        private void lbl_ClearFields_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
            txt_UserName.Clear();
            txt_UserName.Focus();
        }


        //Clear UserName Text Box
        private void txt_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_UserName.Text == "User ID")
            {
                txt_UserName.Clear();
            }
        }


        //Clear Password Text Box
        private void txt_Password_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Clear();
            }
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
            cmd.CommandText = "SELECT * FROM [LIB Managemnt].[dbo].[User_Table] Where User_ID ='" + txt_UserName.Text + "' and Password = '" + txt_Password.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //Open Main User UI
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                UserUI dsa = new UserUI(txt_UserName.Text);
                dsa.Show();
            }
            else
            {
                //Message Box For Wrong Inputs 
                MessageBox.Show("Wrong User ID or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
