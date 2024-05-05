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
    public partial class Catlog : Form

    {
        //Define variables
        int currenRowIndex;
        DateTime issuedDate;
        int catalogID;
        string title;
        string author;
        string isbn;
        decimal price;
        string edition;
        string language;
        string catergory;
        string type;
        string description;
        string subject;
        string quentity;
        string bookID;
        int isActive;
        int isBorrowed;


        public Catlog()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Initializing basics of startup
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void Catlog_Load(object sender, EventArgs e)
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
            txt_Title.ReadOnly = true;
            txt_Author.ReadOnly = true;
            txt_ISBN.ReadOnly = true;
            cmb_Catergory.Enabled = false;
            cmb_Edition.Enabled = false;
            cmb_Language.Enabled = false;
            cmb_Quentity.Enabled = false;
            cmb_Subject.Enabled = false;
            cmb_Type.Enabled = false;
            pkr_IssuedDate.Enabled = false;
            txt_Description.ReadOnly = true;
            txt_price.ReadOnly = true;
            txt_BookID.ReadOnly = true;
            btn_Update.Text = "Update";
            btn_AddNew.Text = "Add New";
            grd_CatalogItem.Enabled = true;
            btn_Deactivate.Text = "Deactivate";
            picBox_Waiting.Visible = false;
            lbl_info.Visible = true;
            lbl_catalog.Visible = true;
            picbox_Book.Visible = true;
            picbox_adding.Visible = false;
            picbox_updating.Visible = false;
            picbox_Deactivating.Visible = false;

            // set up control button in form 
            btn_AddNew.Enabled = false;
            btn_Enable.Enabled = true;
            btn_Deactivate.Enabled = false;
            btn_Reset.Enabled = false;
            btn_Update.Enabled = false;
            btn_Help.Enabled = false;

            //populate data gridview with all active catalog items
            grd_CatalogItem.DataSource = cat.DisplayAllCatalogItems();
            PopulateDataControls();                  
        }


        /// <summary>
        /// populate text box controls from selected value
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void PopulateDataControls()
        {
            currenRowIndex = grd_CatalogItem.CurrentCell.RowIndex;
            txt_Author.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[3].Value.ToString();
            txt_BookID.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[1].Value.ToString();
            txt_Description.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[10].Value.ToString();
            txt_ISBN.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[4].Value.ToString();
            txt_price.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[11].Value.ToString();
            txt_Title.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[2].Value.ToString();
            pkr_IssuedDate.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[12].Value.ToString();
            cmb_Catergory.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[7].Value.ToString();
            cmb_Edition.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[5].Value.ToString();
            cmb_Language.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[6].Value.ToString();
            cmb_Quentity.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[15].Value.ToString();
            cmb_Subject.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[8].Value.ToString();
            cmb_Type.Text = grd_CatalogItem.Rows[currenRowIndex].Cells[9].Value.ToString();          
        }


        /// <summary>
        /// Grid Change according to Mouse selection
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void grd_CatalogItem_SelectionChanged(object sender, EventArgs e)
        {
            PopulateDataControls();
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
            btn_Help.Enabled = true;
        }


        /// <summary>
        /// Add New button statement
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            //Enable Adding New Pic Box & Jpeg
            picBox_Waiting.Visible = true;
            lbl_catalog.Visible = false;
            lbl_info.Visible = false;
            picbox_Book.Visible = false;
            picbox_updating.Visible = false;
            picbox_Deactivating.Visible = false;
            picbox_adding.Visible = true;

            //Disable Data Grid Controls
            grd_CatalogItem.Enabled = false;

            if (btn_AddNew.Text == "Add New")
            {
                // Set up data controls
                txt_Author.Text = "";
                txt_BookID.Text = "";
                txt_Description.Text = "";
                txt_ISBN.Text = "";
                txt_price.Text = "";
                txt_Title.Text = "";
                cmb_Catergory.Text = "";
                pkr_IssuedDate.Text = "";
                cmb_Edition.Text = "";
                cmb_Language.Text = "";
                cmb_Quentity.Text = "";
                cmb_Subject.Text = "";
                cmb_Type.Text = "";

                //Enable details for add new catalog item
                txt_Title.ReadOnly = false;
                txt_Description.ReadOnly = false;
                txt_price.ReadOnly = false;
                txt_BookID.ReadOnly = false;
                txt_Author.ReadOnly = false;
                txt_ISBN.ReadOnly = false;
                cmb_Catergory.Enabled = true;
                cmb_Edition.Enabled = true;
                cmb_Language.Enabled = true;
                cmb_Quentity.Enabled = true;
                cmb_Subject.Enabled = true;
                cmb_Type.Enabled = true;
                pkr_IssuedDate.Enabled = true;

                //set up button controls
                btn_Enable.Enabled = false;
                btn_AddNew.Enabled = true;
                btn_Deactivate.Enabled = false;
                btn_Reset.Enabled = true;
                btn_Update.Enabled = false;              
                btn_Help.Enabled = true;
                btn_AddNew.Text = "Save";
            }
            else if (btn_AddNew.Text == "Save")
            {
                //Validating User Inputs 
                bool success = DataValidation();

                if (success == true)
                {
                    issuedDate = Convert.ToDateTime(pkr_IssuedDate.Text);
                    title = txt_Title.Text;
                    author = txt_Author.Text;
                    isbn = txt_ISBN.Text;
                    edition = cmb_Edition.Text;
                    language = cmb_Language.Text;
                    catergory = cmb_Catergory.Text;
                    type = cmb_Type.Text;
                    description = txt_Description.Text;
                    price = Convert.ToDecimal(txt_price.Text);
                    quentity = cmb_Quentity.Text;
                    bookID = txt_BookID.Text;
                    subject = cmb_Subject.Text; 
                    
                    try
                    {
                        cat.AddNewCatlogItems( title,  author,  isbn, edition,  language, catergory,  type, description,  price,  issuedDate,  isBorrowed,  isActive,  quentity, subject,  bookID);
                        //Message Box settings 
                        MessageBox.Show("Add New Catalog Item Successfull", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        //Message Box settings 
                        MessageBox.Show("Add New Catalog Item Unsuccessfull", " Unsuccess ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        FormLoad();
                    }
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
            if (txt_Author.Text == "" || txt_BookID.Text == "" || txt_price.Text == "" || txt_Title.Text == "" || cmb_Language.Text == "" || cmb_Catergory.Text == "" || cmb_Quentity.Text == "" || cmb_Subject.Text == "" || cmb_Type.Text == "")
            {
                // Display Pop Up Error when fields are emphty
                MessageBox.Show("Please !!!  Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set focus to First Name TextBox 
                txt_Author.Focus();
                return false;
            }

            // Author Validation 
            if (!Regex.Match(txt_Author.Text, @"[A-Z][a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]").Success)
            {

                MessageBox.Show("Invalid Author" + Environment.NewLine + "  • First Letter Must Be Capital", "User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_BookID.Focus();
                return false;
            }

            //BookID
            if ((!Regex.Match(txt_BookID.Text, @"[A-Z][a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]").Success))
            {
                MessageBox.Show("Invalid BookID" + Environment.NewLine + "  • Must Have according to format", "User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Price
            //if ((!Regex.Match(txt_BookID.Text, @"^\d{8}$").Success))
           // {
             //   MessageBox.Show("Invalid Price" + Environment.NewLine + "  • Input Only Numeric Values", "User Inputs are Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  return false;
           // }

            return success;
        }


        /// <summary>
        /// Update button statement
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Enable Updte New Pic Box & Jpeg
            picBox_Waiting.Visible = true;
            lbl_catalog.Visible = false;
            lbl_info.Visible = false;
            picbox_Book.Visible = false;
            picbox_updating.Visible = true;
            picbox_Deactivating.Visible = false;
            picbox_adding.Visible = false;

            //Disable Data Grid Controls
            grd_CatalogItem.Enabled = false;

            if (btn_Update.Text == "Update")
            {
                //Enable details for add update catalog item
                txt_Title.ReadOnly = false;
                txt_Description.ReadOnly = false;
                txt_price.ReadOnly = false;
                txt_BookID.ReadOnly = false;
                txt_Author.ReadOnly = false;
                txt_ISBN.ReadOnly = false;
                cmb_Catergory.Enabled = true;
                cmb_Edition.Enabled = true;
                cmb_Language.Enabled = true;
                cmb_Quentity.Enabled = true;
                cmb_Subject.Enabled = true;
                cmb_Type.Enabled = true;
                pkr_IssuedDate.Enabled = true;

                //Button settings for update
                btn_Enable.Enabled = false;
                btn_AddNew.Enabled = false;
                btn_Deactivate.Enabled = false;
                btn_Reset.Enabled = true;
                btn_Update.Text = "Save";
                btn_Help.Enabled = true;
            }
            else if (btn_Update.Text == "Save")
            {
                //Validating User Inputs 
                bool success = DataValidation();

                if (success == true)
                {
                    issuedDate = Convert.ToDateTime(pkr_IssuedDate.Text);
                    title = txt_Title.Text;
                    author = txt_Author.Text;
                    isbn = txt_ISBN.Text;
                    edition = cmb_Edition.Text;
                    language = cmb_Language.Text;
                    catergory = cmb_Catergory.Text;
                    type = cmb_Type.Text;
                    description = txt_Description.Text;
                    price = Convert.ToDecimal(txt_price.Text);
                    quentity = cmb_Quentity.Text;
                    bookID = txt_BookID.Text;
                    subject = cmb_Subject.Text;
                    catalogID = Convert.ToInt32(grd_CatalogItem.Rows[currenRowIndex].Cells[0].Value.ToString());
                    isActive = Convert.ToInt32(grd_CatalogItem.Rows[currenRowIndex].Cells[14].Value.ToString());
                    isBorrowed = Convert.ToInt32(grd_CatalogItem.Rows[currenRowIndex].Cells[13].Value.ToString());

                    try
                    {
                        cat.UpdateCatlogItems(title, author, isbn, edition, language, catergory, type, description, price, issuedDate, isBorrowed, isActive, quentity, subject, bookID,catalogID);
                        //Message Box settings 
                        MessageBox.Show("Update Catalog Item Successfull", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        //Message Box settings 
                        MessageBox.Show("Update Catalog Item Unsuccessfull", " Unsuccess ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        FormLoad();
                    }
                }

            }
        }


        /// <summary>
        /// How to Create Book ID
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Help_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("First 3 Letters of Words in Title" + "-" + Environment.NewLine + "First  Letter in Language" + "-" + Environment.NewLine + "Edition" + "-"+ Environment.NewLine + "" + Environment.NewLine + "Eg:- Title : Methods Of Programming" + Environment.NewLine + "Language : English" + Environment.NewLine + "Edition : 2" + Environment.NewLine + "Subject : Computing"  + Environment.NewLine + "Book Id = MOP-E-02-Com", "How to Create Book ID", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {

            }
        }


        /// <summary>
        ///Deactivate BUtton
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Deactivate_Click(object sender, EventArgs e)
        {
            //Enable Deactivate New Pic Box & Jpeg           
            picBox_Waiting.Visible = true;
            lbl_catalog.Visible = false;
            lbl_info.Visible = false;
            picbox_Book.Visible = false;
            picbox_adding.Visible = false;
            picbox_updating.Visible = false;
            picbox_Deactivating.Visible = true;

            //Disable Data Grid Controls
            grd_CatalogItem.Enabled = false;

            if (btn_Deactivate.Text == "Deactivate")
            {
                //Enable details for Deactivate catalog item
                txt_Title.ReadOnly = false;
                txt_Description.ReadOnly = false;
                txt_price.ReadOnly = false;
                txt_BookID.ReadOnly = false;
                txt_Author.ReadOnly = false;
                txt_ISBN.ReadOnly = false;
                cmb_Catergory.Enabled = true;
                cmb_Edition.Enabled = true;
                cmb_Language.Enabled = true;
                cmb_Quentity.Enabled = true;
                cmb_Subject.Enabled = true;
                cmb_Type.Enabled = true;
                pkr_IssuedDate.Enabled = true;

                //Button settings for deactivate
                btn_Enable.Enabled = false;
                btn_AddNew.Enabled = false;
                btn_Update.Enabled = false;
                btn_Reset.Enabled = true;
                btn_Deactivate.Text = "Ok";
                btn_Help.Enabled = true;
            }
            else if (btn_Deactivate.Text == "OK")
            {
                //Validating User Inputs 
                bool success = DataValidation();

                if (success == true)
                {
                    issuedDate = Convert.ToDateTime(pkr_IssuedDate.Text);
                    title = txt_Title.Text;
                    author = txt_Author.Text;
                    isbn = txt_ISBN.Text;
                    edition = cmb_Edition.Text;
                    language = cmb_Language.Text;
                    catergory = cmb_Catergory.Text;
                    type = cmb_Type.Text;
                    description = txt_Description.Text;
                    price = Convert.ToDecimal(txt_price.Text);
                    quentity = cmb_Quentity.Text;
                    bookID = txt_BookID.Text;
                    subject = cmb_Subject.Text;
                    catalogID = Convert.ToInt32(grd_CatalogItem.Rows[currenRowIndex].Cells[0].Value.ToString());
                    isActive = Convert.ToInt32(grd_CatalogItem.Rows[currenRowIndex].Cells[14].Value.ToString());
                    isBorrowed = Convert.ToInt32(grd_CatalogItem.Rows[currenRowIndex].Cells[13].Value.ToString());

                    try
                    {
                        cat.DeactivateCatlogItems(title, author, isbn, edition, language, catergory, type, description, price, issuedDate, isBorrowed, isActive, quentity, subject, bookID, catalogID);
                        //Message Box settings 
                        MessageBox.Show("Deactivate Catalog Item Successfull", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        //Message Box settings 
                        MessageBox.Show("Deactivate Catalog Item Unsuccessfull", " Unsuccess ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        FormLoad();
                    }
                }

            }
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
        ///Search
        /// </summary>
        /// <Author>Imesh Nirmal</Author>
        /// <DateCreated>23-05-2021</DateCreated>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Variable for BookName
            string bnm = txt_search.Text;

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

            // Data to text Boxes
            if (DS.Tables[0].Rows.Count != 0)
            {
                txt_Title.Text = DS.Tables[0].Rows[0][1].ToString();
                txt_Author.Text = DS.Tables[0].Rows[0][2].ToString();
                cmb_Quentity.Text = DS.Tables[0].Rows[0][13].ToString();
                txt_BookID.Text = DS.Tables[0].Rows[0][15].ToString();
                txt_Description.Text = DS.Tables[0].Rows[0][8].ToString();
                txt_ISBN.Text = DS.Tables[0].Rows[0][3].ToString();
                txt_price.Text = DS.Tables[0].Rows[0][9].ToString();
                cmb_Edition.Text = DS.Tables[0].Rows[0][4].ToString();
                cmb_Language.Text = DS.Tables[0].Rows[0][5].ToString();
                cmb_Subject.Text = DS.Tables[0].Rows[0][14].ToString();
                cmb_Type.Text = DS.Tables[0].Rows[0][7].ToString();
                pkr_IssuedDate.Text = DS.Tables[0].Rows[0][10].ToString();
                cmb_Catergory.Text = DS.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                //Message Box for Invalid User ID
                MessageBox.Show("Invalid Catalog ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Serach Reset Button
        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            FormLoad();
        }
    }


    
}
