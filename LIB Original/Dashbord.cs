using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIB_Original
{
    public partial class Dashbord : Form
    {
        public Dashbord(string UserID)
        {
            InitializeComponent();
            txt_UserID.Text = UserID;
            lbl_UserID.Hide();
            txt_UserID.Hide();
            Basicload();
        }


        //Start UP Load 
        public void Basicload()
        {
            if (txt_UserID.Text != "")
            {           
                //Variable for UserId
                string nic = txt_UserID.Text;

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

                // Data to text Boxes
                if (DS.Tables[0].Rows.Count != 0)
                {
                    txt_UserName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txt_FirstName.Text = DS.Tables[0].Rows[0][3].ToString();
                    txt_LastName.Text = DS.Tables[0].Rows[0][4].ToString();
                    txt_Faculty.Text = DS.Tables[0].Rows[0][9].ToString();
                    txt_NIC.Text = DS.Tables[0].Rows[0][2].ToString();
                    txt_ContactNumber.Text = DS.Tables[0].Rows[0][6].ToString();
                    txt_Role.Text = DS.Tables[0].Rows[0][10].ToString();
                    txt_Fine.Text = DS.Tables[0].Rows[0][12].ToString();
                    txt_Status.Text = DS.Tables[0].Rows[0][13].ToString();
                    pkr_DOB.Text = DS.Tables[0].Rows[0][8].ToString();
                    txt_Email.Text = DS.Tables[0].Rows[0][7].ToString();
                    txt_Password.Text = DS.Tables[0].Rows[0][11].ToString();
                    txt_Address.Text = DS.Tables[0].Rows[0][5].ToString();

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

                txt_Password.ReadOnly = true;
                txt_NewPassword.ReadOnly = true;
            }
        }


        //How To Create Strong Password
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("• At least one upper case english letter" + "" + Environment.NewLine + "• At least one lower case english letter" + "" + Environment.NewLine + "• At least one digit" + "" + Environment.NewLine + "• At least one special character " + Environment.NewLine + "• Minimum 8 in length", "Password Must Contain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        //Reset Password
        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            //Enable Reset Button 
            txt_NewPassword.ReadOnly = false;

            if (btn_ResetPassword.Text == "Reset")
            {
                btn_ResetPassword.Text = "Save";
            }
            else if (btn_ResetPassword.Text == "Save")
            {
                //Validating New Password
                bool success = PasswordValidation();
                if (success == true)
                {
                    //Build Sql Connection
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    //Variables 
                    string newpass = txt_NewPassword.Text;

                    //Sql Command for Update User Table
                    con.Open();
                    cmd.CommandText = "update User_Table set Password = ('" + newpass + "') where User_ID = '" + txt_UserID.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //Message Box if success
                    MessageBox.Show("Update Successfull ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Basicload();
                }
            }

        }


        //Password Validation 
        public bool PasswordValidation()
        {
            bool success = true;

            //Password Validation 
            if ((!Regex.Match(txt_NewPassword.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").Success))
            {
                MessageBox.Show("Invalid Password " + Environment.NewLine + "  • Click ? for Check How to Create Strong Password ", "User Inputs are Invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NewPassword.Focus();
                return false;
            }
            return success;
        }

    }
}
