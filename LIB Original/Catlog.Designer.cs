
namespace LIB_Original
{
    partial class Catlog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catlog));
            this.grd_CatalogItem = new System.Windows.Forms.DataGridView();
            this.pnl_Function = new System.Windows.Forms.Panel();
            this.btn_Deactivate = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_catalog = new System.Windows.Forms.Label();
            this.btn_Enable = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.picBox_Waiting = new System.Windows.Forms.PictureBox();
            this.picBox_Faunction = new System.Windows.Forms.PictureBox();
            this.pnl_Details = new System.Windows.Forms.Panel();
            this.lbl_BookID = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.pkr_IssuedDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_Quentity = new System.Windows.Forms.ComboBox();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.cmb_Catergory = new System.Windows.Forms.ComboBox();
            this.cmb_Language = new System.Windows.Forms.ComboBox();
            this.cmb_Edition = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_IssuedDate = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.lbl_Edition = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Quentity = new System.Windows.Forms.Label();
            this.lbl_D = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox_Deactivating = new System.Windows.Forms.PictureBox();
            this.picbox_updating = new System.Windows.Forms.PictureBox();
            this.picbox_Book = new System.Windows.Forms.PictureBox();
            this.picbox_adding = new System.Windows.Forms.PictureBox();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_Title = new System.Windows.Forms.PictureBox();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.lbl_CatalogID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ResetSearch = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_CatalogItem)).BeginInit();
            this.pnl_Function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Waiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Faunction)).BeginInit();
            this.pnl_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Deactivating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_updating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_adding)).BeginInit();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Title)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_CatalogItem
            // 
            this.grd_CatalogItem.AllowUserToAddRows = false;
            this.grd_CatalogItem.AllowUserToDeleteRows = false;
            this.grd_CatalogItem.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_CatalogItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_CatalogItem.Location = new System.Drawing.Point(3, 445);
            this.grd_CatalogItem.MultiSelect = false;
            this.grd_CatalogItem.Name = "grd_CatalogItem";
            this.grd_CatalogItem.ReadOnly = true;
            this.grd_CatalogItem.RowHeadersWidth = 51;
            this.grd_CatalogItem.RowTemplate.Height = 24;
            this.grd_CatalogItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_CatalogItem.Size = new System.Drawing.Size(1000, 202);
            this.grd_CatalogItem.TabIndex = 10;
            this.grd_CatalogItem.SelectionChanged += new System.EventHandler(this.grd_CatalogItem_SelectionChanged);
            // 
            // pnl_Function
            // 
            this.pnl_Function.BackColor = System.Drawing.Color.White;
            this.pnl_Function.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Function.Controls.Add(this.btn_Deactivate);
            this.pnl_Function.Controls.Add(this.lbl_info);
            this.pnl_Function.Controls.Add(this.btn_Reset);
            this.pnl_Function.Controls.Add(this.lbl_catalog);
            this.pnl_Function.Controls.Add(this.btn_Enable);
            this.pnl_Function.Controls.Add(this.btn_Update);
            this.pnl_Function.Controls.Add(this.btn_AddNew);
            this.pnl_Function.Controls.Add(this.picBox_Waiting);
            this.pnl_Function.Controls.Add(this.picBox_Faunction);
            this.pnl_Function.Location = new System.Drawing.Point(703, 44);
            this.pnl_Function.Name = "pnl_Function";
            this.pnl_Function.Size = new System.Drawing.Size(300, 228);
            this.pnl_Function.TabIndex = 8;
            // 
            // btn_Deactivate
            // 
            this.btn_Deactivate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Deactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deactivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Deactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deactivate.Location = new System.Drawing.Point(8, 136);
            this.btn_Deactivate.Name = "btn_Deactivate";
            this.btn_Deactivate.Size = new System.Drawing.Size(120, 32);
            this.btn_Deactivate.TabIndex = 0;
            this.btn_Deactivate.Text = "Deactivate";
            this.btn_Deactivate.UseVisualStyleBackColor = false;
            this.btn_Deactivate.Click += new System.EventHandler(this.btn_Deactivate_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.White;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_info.Location = new System.Drawing.Point(189, 52);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(66, 32);
            this.lbl_info.TabIndex = 5;
            this.lbl_info.Text = "info";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(8, 187);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(120, 26);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_catalog
            // 
            this.lbl_catalog.AutoSize = true;
            this.lbl_catalog.BackColor = System.Drawing.Color.White;
            this.lbl_catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_catalog.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_catalog.Location = new System.Drawing.Point(148, 14);
            this.lbl_catalog.Name = "lbl_catalog";
            this.lbl_catalog.Size = new System.Drawing.Size(163, 32);
            this.lbl_catalog.TabIndex = 4;
            this.lbl_catalog.Text = "Catalogue ";
            // 
            // btn_Enable
            // 
            this.btn_Enable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enable.Location = new System.Drawing.Point(8, 3);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(120, 27);
            this.btn_Enable.TabIndex = 0;
            this.btn_Enable.Text = "Enable";
            this.btn_Enable.UseVisualStyleBackColor = false;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Enable_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(8, 85);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(120, 35);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNew.Location = new System.Drawing.Point(8, 45);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(120, 23);
            this.btn_AddNew.TabIndex = 0;
            this.btn_AddNew.Text = "Add New";
            this.btn_AddNew.UseVisualStyleBackColor = false;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // picBox_Waiting
            // 
            this.picBox_Waiting.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Waiting.Image")));
            this.picBox_Waiting.Location = new System.Drawing.Point(141, 43);
            this.picBox_Waiting.Name = "picBox_Waiting";
            this.picBox_Waiting.Size = new System.Drawing.Size(157, 146);
            this.picBox_Waiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Waiting.TabIndex = 0;
            this.picBox_Waiting.TabStop = false;
            // 
            // picBox_Faunction
            // 
            this.picBox_Faunction.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Faunction.Image")));
            this.picBox_Faunction.Location = new System.Drawing.Point(141, 88);
            this.picBox_Faunction.Name = "picBox_Faunction";
            this.picBox_Faunction.Size = new System.Drawing.Size(157, 125);
            this.picBox_Faunction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Faunction.TabIndex = 0;
            this.picBox_Faunction.TabStop = false;
            // 
            // pnl_Details
            // 
            this.pnl_Details.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Details.Controls.Add(this.lbl_BookID);
            this.pnl_Details.Controls.Add(this.btn_Help);
            this.pnl_Details.Controls.Add(this.pkr_IssuedDate);
            this.pnl_Details.Controls.Add(this.cmb_Quentity);
            this.pnl_Details.Controls.Add(this.txt_BookID);
            this.pnl_Details.Controls.Add(this.cmb_Subject);
            this.pnl_Details.Controls.Add(this.cmb_Type);
            this.pnl_Details.Controls.Add(this.cmb_Catergory);
            this.pnl_Details.Controls.Add(this.cmb_Language);
            this.pnl_Details.Controls.Add(this.cmb_Edition);
            this.pnl_Details.Controls.Add(this.txt_price);
            this.pnl_Details.Controls.Add(this.txt_ISBN);
            this.pnl_Details.Controls.Add(this.txt_Author);
            this.pnl_Details.Controls.Add(this.txt_Title);
            this.pnl_Details.Controls.Add(this.lbl_IssuedDate);
            this.pnl_Details.Controls.Add(this.lbl_Subject);
            this.pnl_Details.Controls.Add(this.lbl_Price);
            this.pnl_Details.Controls.Add(this.lbl_Type);
            this.pnl_Details.Controls.Add(this.lbl_Category);
            this.pnl_Details.Controls.Add(this.lbl_Language);
            this.pnl_Details.Controls.Add(this.lbl_Edition);
            this.pnl_Details.Controls.Add(this.lbl_ISBN);
            this.pnl_Details.Controls.Add(this.lbl_Author);
            this.pnl_Details.Controls.Add(this.lbl_BookTitle);
            this.pnl_Details.Controls.Add(this.txt_Description);
            this.pnl_Details.Controls.Add(this.lbl_Quentity);
            this.pnl_Details.Controls.Add(this.lbl_D);
            this.pnl_Details.Controls.Add(this.panel1);
            this.pnl_Details.Location = new System.Drawing.Point(3, 44);
            this.pnl_Details.Name = "pnl_Details";
            this.pnl_Details.Size = new System.Drawing.Size(704, 396);
            this.pnl_Details.TabIndex = 7;
            // 
            // lbl_BookID
            // 
            this.lbl_BookID.AutoSize = true;
            this.lbl_BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookID.Location = new System.Drawing.Point(542, 219);
            this.lbl_BookID.Name = "lbl_BookID";
            this.lbl_BookID.Size = new System.Drawing.Size(79, 20);
            this.lbl_BookID.TabIndex = 10;
            this.lbl_BookID.Text = "Book ID :";
            // 
            // btn_Help
            // 
            this.btn_Help.AccessibleDescription = "";
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Help.BackgroundImage")));
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Help.Location = new System.Drawing.Point(660, 257);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(25, 25);
            this.btn_Help.TabIndex = 22;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // pkr_IssuedDate
            // 
            this.pkr_IssuedDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_IssuedDate.Location = new System.Drawing.Point(115, 260);
            this.pkr_IssuedDate.Name = "pkr_IssuedDate";
            this.pkr_IssuedDate.Size = new System.Drawing.Size(318, 29);
            this.pkr_IssuedDate.TabIndex = 27;
            // 
            // cmb_Quentity
            // 
            this.cmb_Quentity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Quentity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Quentity.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Quentity.FormattingEnabled = true;
            this.cmb_Quentity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "10 ++",
            "Not Available"});
            this.cmb_Quentity.Location = new System.Drawing.Point(564, 353);
            this.cmb_Quentity.Name = "cmb_Quentity";
            this.cmb_Quentity.Size = new System.Drawing.Size(104, 27);
            this.cmb_Quentity.TabIndex = 26;
            // 
            // txt_BookID
            // 
            this.txt_BookID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookID.Location = new System.Drawing.Point(493, 256);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(153, 30);
            this.txt_BookID.TabIndex = 21;
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Subject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Subject.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Items.AddRange(new object[] {
            "Arts",
            "Animals",
            "Computing",
            "Fiction",
            "Science & Mathematics",
            "Business & Finance",
            "Children\'s",
            "History",
            "Health & Wellness",
            "Biography",
            "Social Sciences",
            "Places",
            "Textbooks",
            "Language"});
            this.cmb_Subject.Location = new System.Drawing.Point(546, 302);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(139, 27);
            this.cmb_Subject.TabIndex = 26;
            // 
            // cmb_Type
            // 
            this.cmb_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "Borrow Only",
            "Read Only",
            "Read/Borrow",
            "E-Book"});
            this.cmb_Type.Location = new System.Drawing.Point(352, 207);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(140, 27);
            this.cmb_Type.TabIndex = 26;
            // 
            // cmb_Catergory
            // 
            this.cmb_Catergory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Catergory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Catergory.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catergory.FormattingEnabled = true;
            this.cmb_Catergory.Items.AddRange(new object[] {
            "Book",
            "E-Book",
            "Magazine",
            "Journal",
            "Papers"});
            this.cmb_Catergory.Location = new System.Drawing.Point(91, 212);
            this.cmb_Catergory.Name = "cmb_Catergory";
            this.cmb_Catergory.Size = new System.Drawing.Size(149, 27);
            this.cmb_Catergory.TabIndex = 25;
            // 
            // cmb_Language
            // 
            this.cmb_Language.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Language.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Language.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Language.FormattingEnabled = true;
            this.cmb_Language.Items.AddRange(new object[] {
            "Sinhala",
            "English",
            "Tamil",
            "German / Deutsch ",
            "French / français ",
            "Spanish / español ",
            "Russian / Русский ",
            "Italian ",
            "Chinese ",
            "Japanese ",
            "Portuguese ",
            "Arabic ",
            "Polish ",
            "Hebrew ",
            "Dutch ",
            "Korean ",
            "Indonesian ",
            "Latin ",
            "Undetermined ",
            "Mandarin ",
            "Swedish ",
            "Hindi ",
            "Danish ",
            "Urdu ",
            "Hungarian ",
            "Czech ",
            "Turkish ",
            "Ukrainian ",
            "Greek ",
            "Vietnamese ",
            "Bulgarian ",
            "Romanian ",
            "Bengali ",
            "Catalan ",
            "Thai ",
            "Norwegian ",
            "Persian ",
            "Multiple languages ",
            "Finnish ",
            "Croatian ",
            "Gujarati ",
            "Marathi ",
            "Serbian ",
            "Yiddish ",
            "Panjabi ",
            "Welsh ",
            "Telugu ",
            "Kannada ",
            "Slovak ",
            "Sanskrit ",
            "Malay ",
            "Armenian ",
            "Malayalam ",
            "Burmese ",
            "Slovenian ",
            "Tibetan ",
            "Lithuanian ",
            "Estonian ",
            "Latvian ",
            "Nepali ",
            "Albanian ",
            "Mongolian ",
            "Afrikaans ",
            "Irish ",
            "Oriya ",
            "Georgian ",
            "Serbian ",
            "Ancient Greek ",
            "Macedonian ",
            "Icelandic ",
            "Belarusian ",
            "Sindhi ",
            "Sinhalese ",
            "Turkish, Ottoman ",
            "Kurdish ",
            "Croatian "});
            this.cmb_Language.Location = new System.Drawing.Point(352, 160);
            this.cmb_Language.Name = "cmb_Language";
            this.cmb_Language.Size = new System.Drawing.Size(126, 27);
            this.cmb_Language.TabIndex = 24;
            // 
            // cmb_Edition
            // 
            this.cmb_Edition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Edition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Edition.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Edition.FormattingEnabled = true;
            this.cmb_Edition.Items.AddRange(new object[] {
            "1st Edition",
            "2nd Edition",
            "3rd Edition",
            "4th Edition",
            "5th Edition",
            "6th Edition",
            "7th Edition",
            "9th Edition",
            "10th Edition",
            "11th Edition",
            "12th Edition",
            "13th Edition",
            "14th Edition",
            "14th Edition +++"});
            this.cmb_Edition.Location = new System.Drawing.Point(75, 158);
            this.cmb_Edition.Name = "cmb_Edition";
            this.cmb_Edition.Size = new System.Drawing.Size(145, 27);
            this.cmb_Edition.TabIndex = 23;
            // 
            // txt_price
            // 
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(352, 109);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(118, 30);
            this.txt_price.TabIndex = 21;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ISBN.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ISBN.Location = new System.Drawing.Point(67, 109);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(173, 30);
            this.txt_ISBN.TabIndex = 20;
            // 
            // txt_Author
            // 
            this.txt_Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Author.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Author.Location = new System.Drawing.Point(67, 59);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(296, 30);
            this.txt_Author.TabIndex = 22;
            // 
            // txt_Title
            // 
            this.txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(67, 12);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(296, 30);
            this.txt_Title.TabIndex = 19;
            // 
            // lbl_IssuedDate
            // 
            this.lbl_IssuedDate.AutoSize = true;
            this.lbl_IssuedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IssuedDate.Location = new System.Drawing.Point(2, 265);
            this.lbl_IssuedDate.Name = "lbl_IssuedDate";
            this.lbl_IssuedDate.Size = new System.Drawing.Size(109, 20);
            this.lbl_IssuedDate.TabIndex = 17;
            this.lbl_IssuedDate.Text = "Issued Date :";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(470, 302);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(75, 20);
            this.lbl_Subject.TabIndex = 15;
            this.lbl_Subject.Text = "Subject :";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(275, 113);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(58, 20);
            this.lbl_Price.TabIndex = 16;
            this.lbl_Price.Text = "Price :";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(291, 212);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(55, 20);
            this.lbl_Type.TabIndex = 15;
            this.lbl_Type.Text = "Type :";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(3, 214);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(86, 20);
            this.lbl_Category.TabIndex = 14;
            this.lbl_Category.Text = "Category :";
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Language.Location = new System.Drawing.Point(254, 161);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(92, 20);
            this.lbl_Language.TabIndex = 13;
            this.lbl_Language.Text = "Language :";
            // 
            // lbl_Edition
            // 
            this.lbl_Edition.AutoSize = true;
            this.lbl_Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edition.Location = new System.Drawing.Point(3, 160);
            this.lbl_Edition.Name = "lbl_Edition";
            this.lbl_Edition.Size = new System.Drawing.Size(70, 20);
            this.lbl_Edition.TabIndex = 12;
            this.lbl_Edition.Text = "Edition :";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ISBN.Location = new System.Drawing.Point(4, 113);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(58, 20);
            this.lbl_ISBN.TabIndex = 11;
            this.lbl_ISBN.Text = "ISBN :";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(0, 64);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(68, 20);
            this.lbl_Author.TabIndex = 18;
            this.lbl_Author.Text = "Author :";
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookTitle.Location = new System.Drawing.Point(4, 14);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(55, 20);
            this.lbl_BookTitle.TabIndex = 10;
            this.lbl_BookTitle.Text = "Tiltle :";
            // 
            // txt_Description
            // 
            this.txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Description.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(110, 309);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(346, 75);
            this.txt_Description.TabIndex = 7;
            // 
            // lbl_Quentity
            // 
            this.lbl_Quentity.AutoSize = true;
            this.lbl_Quentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quentity.Location = new System.Drawing.Point(476, 356);
            this.lbl_Quentity.Name = "lbl_Quentity";
            this.lbl_Quentity.Size = new System.Drawing.Size(81, 20);
            this.lbl_Quentity.TabIndex = 6;
            this.lbl_Quentity.Text = "Quentity :";
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_D.Location = new System.Drawing.Point(6, 334);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(105, 20);
            this.lbl_D.TabIndex = 6;
            this.lbl_D.Text = "Description :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picbox_Deactivating);
            this.panel1.Controls.Add(this.picbox_updating);
            this.panel1.Controls.Add(this.picbox_Book);
            this.panel1.Controls.Add(this.picbox_adding);
            this.panel1.Location = new System.Drawing.Point(499, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 197);
            this.panel1.TabIndex = 28;
            // 
            // picbox_Deactivating
            // 
            this.picbox_Deactivating.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Deactivating.Image")));
            this.picbox_Deactivating.Location = new System.Drawing.Point(12, 8);
            this.picbox_Deactivating.Name = "picbox_Deactivating";
            this.picbox_Deactivating.Size = new System.Drawing.Size(175, 179);
            this.picbox_Deactivating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Deactivating.TabIndex = 0;
            this.picbox_Deactivating.TabStop = false;
            // 
            // picbox_updating
            // 
            this.picbox_updating.Image = ((System.Drawing.Image)(resources.GetObject("picbox_updating.Image")));
            this.picbox_updating.Location = new System.Drawing.Point(12, 12);
            this.picbox_updating.Name = "picbox_updating";
            this.picbox_updating.Size = new System.Drawing.Size(175, 179);
            this.picbox_updating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_updating.TabIndex = 0;
            this.picbox_updating.TabStop = false;
            // 
            // picbox_Book
            // 
            this.picbox_Book.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Book.Image")));
            this.picbox_Book.Location = new System.Drawing.Point(12, 8);
            this.picbox_Book.Name = "picbox_Book";
            this.picbox_Book.Size = new System.Drawing.Size(175, 179);
            this.picbox_Book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Book.TabIndex = 0;
            this.picbox_Book.TabStop = false;
            // 
            // picbox_adding
            // 
            this.picbox_adding.Image = ((System.Drawing.Image)(resources.GetObject("picbox_adding.Image")));
            this.picbox_adding.Location = new System.Drawing.Point(12, 10);
            this.picbox_adding.Name = "picbox_adding";
            this.picbox_adding.Size = new System.Drawing.Size(175, 179);
            this.picbox_adding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_adding.TabIndex = 0;
            this.picbox_adding.TabStop = false;
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.LightCyan;
            this.pnl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Title.Controls.Add(this.lbl_Title);
            this.pnl_Title.Controls.Add(this.pic_Title);
            this.pnl_Title.Location = new System.Drawing.Point(3, 4);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1000, 38);
            this.pnl_Title.TabIndex = 6;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(422, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(322, 32);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Catalogue Mangement";
            // 
            // pic_Title
            // 
            this.pic_Title.Image = ((System.Drawing.Image)(resources.GetObject("pic_Title.Image")));
            this.pic_Title.Location = new System.Drawing.Point(383, -1);
            this.pic_Title.Name = "pic_Title";
            this.pic_Title.Size = new System.Drawing.Size(37, 39);
            this.pic_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Title.TabIndex = 1;
            this.pic_Title.TabStop = false;
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_Search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Search.Controls.Add(this.lbl_CatalogID);
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.btn_ResetSearch);
            this.pnl_Search.Controls.Add(this.txt_search);
            this.pnl_Search.Location = new System.Drawing.Point(703, 265);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(300, 174);
            this.pnl_Search.TabIndex = 9;
            // 
            // lbl_CatalogID
            // 
            this.lbl_CatalogID.AutoSize = true;
            this.lbl_CatalogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CatalogID.Location = new System.Drawing.Point(71, 35);
            this.lbl_CatalogID.Name = "lbl_CatalogID";
            this.lbl_CatalogID.Size = new System.Drawing.Size(164, 29);
            this.lbl_CatalogID.TabIndex = 3;
            this.lbl_CatalogID.Text = "Catalogue  ID ";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(38, 119);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 26);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ResetSearch
            // 
            this.btn_ResetSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetSearch.Location = new System.Drawing.Point(159, 119);
            this.btn_ResetSearch.Name = "btn_ResetSearch";
            this.btn_ResetSearch.Size = new System.Drawing.Size(96, 26);
            this.btn_ResetSearch.TabIndex = 0;
            this.btn_ResetSearch.Text = "Reset";
            this.btn_ResetSearch.UseVisualStyleBackColor = true;
            this.btn_ResetSearch.Click += new System.EventHandler(this.btn_ResetSearch_Click);
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(10, 72);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(280, 30);
            this.txt_search.TabIndex = 2;
            // 
            // Catlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.grd_CatalogItem);
            this.Controls.Add(this.pnl_Function);
            this.Controls.Add(this.pnl_Details);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.pnl_Search);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "Catlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogue Management";
            this.Load += new System.EventHandler(this.Catlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_CatalogItem)).EndInit();
            this.pnl_Function.ResumeLayout(false);
            this.pnl_Function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Waiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Faunction)).EndInit();
            this.pnl_Details.ResumeLayout(false);
            this.pnl_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Deactivating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_updating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_adding)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Title)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_CatalogItem;
        private System.Windows.Forms.Panel pnl_Function;
        private System.Windows.Forms.Button btn_Deactivate;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_catalog;
        private System.Windows.Forms.Button btn_Enable;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.PictureBox picBox_Faunction;
        private System.Windows.Forms.Panel pnl_Details;
        private System.Windows.Forms.Label lbl_BookID;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.DateTimePicker pkr_IssuedDate;
        private System.Windows.Forms.ComboBox cmb_Quentity;
        private System.Windows.Forms.TextBox txt_BookID;
        private System.Windows.Forms.ComboBox cmb_Subject;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.ComboBox cmb_Catergory;
        private System.Windows.Forms.ComboBox cmb_Language;
        private System.Windows.Forms.ComboBox cmb_Edition;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_IssuedDate;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Label lbl_Edition;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_BookTitle;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Quentity;
        private System.Windows.Forms.Label lbl_D;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_Title;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.Label lbl_CatalogID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ResetSearch;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox picBox_Waiting;
        private System.Windows.Forms.PictureBox picbox_Book;
        private System.Windows.Forms.PictureBox picbox_adding;
        private System.Windows.Forms.PictureBox picbox_updating;
        private System.Windows.Forms.PictureBox picbox_Deactivating;
    }
}