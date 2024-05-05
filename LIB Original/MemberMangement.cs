using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemBL;
using System.Data.Common;
using LM__Bs_Logic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows;
using System.Data.SqlClient;

namespace LIB_Original
{
    public partial class MemberMangement : Form
    
    {
        //Define variables
        string userName;
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        string address;
        string email;
        string contactNumber;
        string faculty;
        string role;
        string nic;
        string password;
        int isActive;
        int isBlocked;
        decimal cumilativeFine;
        int userId;
        int currenRowIndex;
        public MemberMangement()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Initializing basics of startup
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void MemberMangement_Load(object sender, EventArgs e)
        {
           FormLoad();
        }


        /// <summary>
        /// Reload Form to Initial Stage
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void FormLoad()
        {
            //Intializing load properties
            txt_Address.ReadOnly = true;
            txt_ContactNumber.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_FirstName.ReadOnly = true;
            txt_LastName.ReadOnly = true;
            txt_NIC.ReadOnly = true;
            txt_Password.ReadOnly = true;
            txt_UserName.ReadOnly = true;
            pkr_DOB.Enabled = false;
            cmb_Faculty.Enabled = false;
            cmb_Role.Enabled = false;
            btn_Update.Text = "Update";
            btn_AddNew.Text = "Add New";
            grd_MemberDetails.Enabled = true;
            btn_Deactivate.Text = "Deactivate";

            // set up control button in form 
            btn_AddNew.Enabled = false;
            btn_Enable.Enabled = true;
            btn_Deactivate.Enabled = false;
            btn_Reset.Enabled = false;
            btn_Update.Enabled = false;


            //populate data gridview with all active members 
            grd_MemberDetails.DataSource = Member.ListMembers();
            PopulateDataControls();

            // Disable Non Startup Pic Box and labesl
            lbl_AddingNew.Visible = false;
            picBox_AddingNewMember.Visible = false;
            picBox_Waiting.Visible = false;
            picbox_UserPannel.Visible = true;
            picBox_Updating.Visible = false;
            lbl_UpdateMember.Visible = false;
            lbl_Member.Visible = true;
            lbl_Info.Visible = true;
            picbox_Function.Visible = true;
            lbl_Deactivate.Visible = false;
            picbox_Deactivating.Visible = false;

        }


        /// <summary>
        /// populate text box controls from selected value
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void PopulateDataControls()
        {               
            currenRowIndex=grd_MemberDetails.CurrentCell.RowIndex;
            txt_UserName.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[1].Value.ToString();
            txt_Address.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[8].Value.ToString();
            txt_ContactNumber.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[9].Value.ToString();
            txt_Email.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[10].Value.ToString();
            txt_FirstName.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[2].Value.ToString();
            txt_LastName.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[3].Value.ToString();
            txt_NIC.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[4].Value.ToString();
            txt_Password.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[11].Value.ToString();
            pkr_DOB.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[7].Value.ToString();
            cmb_Role.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[6].Value.ToString();
            cmb_Faculty.Text = grd_MemberDetails.Rows[currenRowIndex].Cells[5].Value.ToString();
        }


        /// <summary>
        /// Enable Button Statement
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            //Enable Butoon Actions 
            btn_Enable.Enabled = false;
            btn_AddNew.Enabled = true;
            btn_Deactivate.Enabled = true;
            btn_Reset.Enabled = true;
            btn_Update.Enabled = true;
        }


        /// <summary>
        /// Add New button statement
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_AddNew_Click(object sender, EventArgs e)
        {               
            //Enable Adding New Pic Box & Jpeg
            lbl_AddingNew.Visible = true;
            picBox_AddingNewMember.Visible = true;
            lbl_Info.Visible = false;
            picbox_Function.Visible = false;
            lbl_Member.Visible = false;
            picbox_UserPannel.Visible = false;
            picBox_Waiting.Visible = true;
            picBox_Updating.Visible = false;
            lbl_UpdateMember.Visible = false;

            //Disable Data Grid Controls
            grd_MemberDetails.Enabled = false;

            if (btn_AddNew.Text == "Add New")
            { 
            // Set up data controls
            txt_UserName.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_NIC.Text = "";
            txt_Address.Text = "";
            txt_ContactNumber.Text = "";
            txt_Email.Text = "";
            txt_Password.Text = "";
            pkr_DOB.Text = "";
            cmb_Faculty.Text = "";
            cmb_Role.Text = "";

            //Enable details for add new member
            txt_Address.ReadOnly = false;
            txt_ContactNumber.ReadOnly = false;
            txt_Email.ReadOnly = false;
            txt_LastName.ReadOnly = false;
            txt_FirstName.ReadOnly = false;
            txt_NIC.ReadOnly = false;
            txt_Password.ReadOnly = false;
            txt_UserName.ReadOnly = false;
            pkr_DOB.Enabled = true;
            cmb_Faculty.Enabled = true;
            cmb_Role.Enabled = true;
            
            //set up button controls
            btn_Enable.Enabled = false;
            btn_AddNew.Enabled = true;
            btn_Deactivate.Enabled = false;
            btn_Reset.Enabled = true;
            btn_Update.Enabled = false;
            btn_AddNew.Text = "Save";
            }
            else if (btn_AddNew.Text == "Save")
            {
                //Validating User Inputs 
                bool success = DataValidation();

                if (success==true)
                {
                    userName = txt_UserName.Text;
                    firstName = txt_FirstName.Text;
                    lastName = txt_LastName.Text;
                    dateOfBirth = Convert.ToDateTime(pkr_DOB.Text);
                    address = txt_Address.Text;
                    email = txt_Email.Text;
                    contactNumber = txt_ContactNumber.Text;
                    faculty = cmb_Faculty.Text;
                    role = cmb_Role.Text;
                    nic = txt_NIC.Text;
                    password = txt_Password.Text;

                    try
                    {
                        Member.AddNewMembers(userName, firstName, lastName, dateOfBirth, address, email, contactNumber, faculty, role, nic, password, isActive, isBlocked, cumilativeFine);
                        //Message Box settings 
                         MessageBox.Show("Add New User Successfull", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        //Message Box settings 
                        MessageBox.Show("Add New User Unsuccessfull", " Unsuccess ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        FormLoad();
                    } 
                }
            }
        }


        /// <summary>
        /// Grid Change according to Mouse selection
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void grd_MemberDetails_SelectionChanged(object sender, EventArgs e)
        {
            PopulateDataControls();                    
        }


        /// <summary>
        /// Update button statement
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(btn_Update.Text=="Update")
            {
                //Enable Adding New Pic Box & Jpeg
                lbl_AddingNew.Visible = false;
                picBox_AddingNewMember.Visible = false;
                lbl_Info.Visible = false;
                picbox_Function.Visible = false;
                lbl_Member.Visible = false;
                picbox_UserPannel.Visible = false;
                picBox_Waiting.Visible = true;
                picBox_Updating.Visible = true;
                lbl_UpdateMember.Visible = true;

                //Enable inputs
                txt_Address.ReadOnly = false;
                txt_ContactNumber.ReadOnly = false;
                txt_Email.ReadOnly = false;
                txt_LastName.ReadOnly = false;
                txt_FirstName.ReadOnly = false;
                txt_NIC.ReadOnly = false;               
                pkr_DOB.Enabled = true;
                cmb_Faculty.Enabled = true;
                cmb_Role.Enabled = true;

                //Button settings for update
                btn_Enable.Enabled = false;
                btn_AddNew.Enabled = false;
                btn_Deactivate.Enabled = false;
                btn_Reset.Enabled = true;
                btn_Update.Text = "Save";

                //Disable Data Grid Controls
                grd_MemberDetails.Enabled = false;
            }
            else if (btn_Update.Text=="Save")
            {
                //Setting Up Data Variable to Pass to Bs Logic
                userName = txt_UserName.Text;
                firstName = txt_FirstName.Text;
                lastName = txt_LastName.Text;
                dateOfBirth = Convert.ToDateTime(pkr_DOB.Text);
                address = txt_Address.Text;
                email = txt_Email.Text;
                contactNumber = txt_ContactNumber.Text;
                faculty = cmb_Faculty.Text;
                role = cmb_Role.Text;
                nic = txt_NIC.Text;
                password = grd_MemberDetails.Rows[currenRowIndex].Cells[11].Value.ToString();
                currenRowIndex = grd_MemberDetails.CurrentCell.RowIndex;
                userId =Convert.ToInt32(grd_MemberDetails.Rows[currenRowIndex].Cells[0].Value.ToString());
                cumilativeFine = Convert.ToDecimal(grd_MemberDetails.Rows[currenRowIndex].Cells[12].Value.ToString());
                isActive = Convert.ToInt32(grd_MemberDetails.Rows[currenRowIndex].Cells[13].Value.ToString());
                isBlocked = Convert.ToInt32(grd_MemberDetails.Rows[currenRowIndex].Cells[14].Value.ToString());

                try
                {
                    Member.UpdateMemberDetails(userName, firstName, lastName, dateOfBirth, address, email, contactNumber, faculty, role, nic, password, isActive, isBlocked, cumilativeFine, userId);
                    //Message Box settings 
                    MessageBox.Show("User Updation Successfull", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    //Message Box settings 
                    MessageBox.Show(" User Update Unsuccessfull", " Unsuccess ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    FormLoad();
                }
            }
        }


        /// <summary>
        ///Data Validation 
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>  
        private bool DataValidation()
        {
            bool success = true;

            // Ensures TextBoxes are Not Empty  
            if (txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_Address.Text == "" || txt_Email.Text == "" || txt_ContactNumber.Text == "" || txt_NIC.Text == "" || txt_Password.Text == "" || txt_UserName.Text == "" || txt_Email.Text == "" || cmb_Faculty.Text == "" || cmb_Role.Text == "")
            {
                // Display Pop Up Error when fields are emphty
                MessageBox.Show("Please !!!  Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set focus to First Name TextBox 
                txt_FirstName.Focus();
                return false;
            }

            // First Name Validation 
            if (!Regex.Match(txt_FirstName.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid First Name"+ Environment.NewLine + "  • First Letter Must Be Capital", "User Inputs are Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_FirstName.Focus();
                return false;
            }

            // Last Name Validation 
            if (!Regex.Match(txt_LastName.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid Last Name" + Environment.NewLine + "  • First Letter Must Be Capital", " User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LastName.Focus();
                return false;
            }

            // Address Validation 
            if (!Regex.Match(txt_Address.Text, @"[A-Z][a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]").Success)
            {
                MessageBox.Show("Invalid Address" + Environment.NewLine + "  • First Letter Must Be Capital", "User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Address.Focus();
                return false;
            }

            //Mobile Number Validation 
            if ((!Regex.Match(txt_ContactNumber.Text, @"^(\+[0-9])$").Success) & (txt_ContactNumber.Text.Length != 10))
            {
                MessageBox.Show("Invalid Contact Number" + Environment.NewLine + "  • Only Numbers" + Environment.NewLine + "  • Must Have Only 10 Digits", "User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ContactNumber.Focus();
                return false;
            }

            //NIC Validation 
            if ((!Regex.Match(txt_NIC.Text, @"^[0-9]*$").Success))
            {
                MessageBox.Show("Invalid NIC Number" + Environment.NewLine + "  • Only Numbers", "User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NIC.Focus();
                return false;
            }

            //E-Mail Validation 
            if ((!Regex.Match(txt_Email.Text, @"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$").Success))
            {
                MessageBox.Show("Invalid E-mail " + Environment.NewLine + "  • Eg --> Yourmail@exaple.com ", "User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
                return false;
            }

            //Password Validation 
            if ((!Regex.Match(txt_Password.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").Success))
            {
                MessageBox.Show("Invalid Password " + Environment.NewLine + "  • Click ? for Check How to Create Strong Password ", "User Inputs are Invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Password.Focus();
                return false;
            }                     
            return success;       
        }


        /// <summary>
        ///? Mark Details for password
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("• At least one upper case english letter" + "" + Environment.NewLine + "• At least one lower case english letter" + "" + Environment.NewLine + "• At least one digit" + "" + Environment.NewLine + "• At least one special character " + Environment.NewLine + "• Minimum 8 in length", "Password Must Contain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        /// <summary>
        ///Reset Button
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            FormLoad();
        }


        /// <summary>
        ///Deactivate BUtton
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Deactivate_Click(object sender, EventArgs e)
        {
            if (btn_Deactivate.Text == "Deactivate")
            {
                //Enable Adding New Pic Box & Jpeg
                lbl_AddingNew.Visible = false;
                picBox_AddingNewMember.Visible = false;
                lbl_Info.Visible = false;
                picbox_Function.Visible = false;
                lbl_Member.Visible = false;
                picbox_UserPannel.Visible = false;
                picBox_Waiting.Visible = true;
                picBox_Updating.Visible = false;
                lbl_UpdateMember.Visible = false;
                lbl_Deactivate.Visible = true;
                picbox_Deactivating.Visible = true;

                //Enable inputs
                txt_Address.ReadOnly = true;
                txt_ContactNumber.ReadOnly = true;
                txt_Email.ReadOnly = true;
                txt_LastName.ReadOnly = true;
                txt_FirstName.ReadOnly = true;
                txt_NIC.ReadOnly = true;
                pkr_DOB.Enabled = false;
                cmb_Faculty.Enabled = false;
                cmb_Role.Enabled = false;

                //Button settings for Deactivate
                btn_Enable.Enabled = false;
                btn_AddNew.Enabled = false;
                btn_Deactivate.Enabled = true;
                btn_Reset.Enabled = true;
                btn_Update.Enabled = false;
                btn_Deactivate.Text = "OK";

                //Disable Data Grid Controls
                grd_MemberDetails.Enabled = false;
            }
            else if (btn_Deactivate.Text == "OK")
            {
                //Setting Up Data Variable to Pass to Bs Logic
                userName = txt_UserName.Text;
                firstName = txt_FirstName.Text;
                lastName = txt_LastName.Text;
                dateOfBirth = Convert.ToDateTime(pkr_DOB.Text);
                address = txt_Address.Text;
                email = txt_Email.Text;
                contactNumber = txt_ContactNumber.Text;
                faculty = cmb_Faculty.Text;
                role = cmb_Role.Text;
                nic = txt_NIC.Text;
                password = grd_MemberDetails.Rows[currenRowIndex].Cells[11].Value.ToString();
                currenRowIndex = grd_MemberDetails.CurrentCell.RowIndex;
                userId = Convert.ToInt32(grd_MemberDetails.Rows[currenRowIndex].Cells[0].Value.ToString());
                cumilativeFine = Convert.ToDecimal(grd_MemberDetails.Rows[currenRowIndex].Cells[12].Value.ToString());
                isActive = Convert.ToInt32(grd_MemberDetails.Rows[currenRowIndex].Cells[13].Value.ToString());
                isBlocked = Convert.ToInt32(grd_MemberDetails.Rows[currenRowIndex].Cells[14].Value.ToString());
                try
                {
                    Member.DeactivateMemberDetails(userName, firstName, lastName, dateOfBirth, address, email, contactNumber, faculty, role, nic, password, isActive, isBlocked, cumilativeFine, userId);
                    //Message Box settings 
                    MessageBox.Show("User Deactivation Successfull", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    //Message Box settings 
                    MessageBox.Show(" User Deactivation Unsuccessfull", " Unsuccess ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    FormLoad();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Variable for BookName
            string uid = txt_search.Text;

            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Sql Command
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[User_Table] Where User_ID = '" + uid + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            // Data to text Boxes
            if (DS.Tables[0].Rows.Count != 0)
            {
                txt_UserName.Text = DS.Tables[0].Rows[0][1].ToString();
                txt_FirstName.Text = DS.Tables[0].Rows[0][3].ToString();
                txt_LastName.Text = DS.Tables[0].Rows[0][4].ToString();
                txt_NIC.Text = DS.Tables[0].Rows[0][2].ToString();
                txt_Address.Text = DS.Tables[0].Rows[0][5].ToString();
                txt_ContactNumber.Text = DS.Tables[0].Rows[0][6].ToString();
                txt_Email.Text = DS.Tables[0].Rows[0][7].ToString();
                txt_Password.Text = DS.Tables[0].Rows[0][11].ToString();
                pkr_DOB.Text = DS.Tables[0].Rows[0][8].ToString();
                cmb_Faculty.Text = DS.Tables[0].Rows[0][9].ToString();
                cmb_Role.Text = DS.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                //Message Box for Invalid User ID
                MessageBox.Show("Invalid Member ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Rest Serch Box 
        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            FormLoad();
        }

        ///////////////////////////////////////////END
    }
}
