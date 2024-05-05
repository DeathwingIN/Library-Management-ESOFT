
namespace LIB_Original
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.pnl_SerachStudent = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_SerchUser = new System.Windows.Forms.Button();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.pic_Student = new System.Windows.Forms.PictureBox();
            this.gdr_Borrowings = new System.Windows.Forms.DataGridView();
            this.pnl_Details = new System.Windows.Forms.Panel();
            this.btn_fine = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ReturnBook = new System.Windows.Forms.Button();
            this.txt_Fine = new System.Windows.Forms.TextBox();
            this.lbl_Fine = new System.Windows.Forms.Label();
            this.pkr_ReturnBefore = new System.Windows.Forms.DateTimePicker();
            this.pkr_ReturnedDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ReturnedDate = new System.Windows.Forms.Label();
            this.lbl_AcctialReturnDate = new System.Windows.Forms.Label();
            this.lbl_IssueDate = new System.Windows.Forms.Label();
            this.txt_IssueDate = new System.Windows.Forms.TextBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.pnl_SerachStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).BeginInit();
            this.pnl_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_SerachStudent
            // 
            this.pnl_SerachStudent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_SerachStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_SerachStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_SerachStudent.Controls.Add(this.btn_refresh);
            this.pnl_SerachStudent.Controls.Add(this.btn_SerchUser);
            this.pnl_SerachStudent.Controls.Add(this.txt_UserId);
            this.pnl_SerachStudent.Controls.Add(this.lbl_UserId);
            this.pnl_SerachStudent.Controls.Add(this.pic_Student);
            this.pnl_SerachStudent.Location = new System.Drawing.Point(3, 1);
            this.pnl_SerachStudent.Name = "pnl_SerachStudent";
            this.pnl_SerachStudent.Size = new System.Drawing.Size(997, 116);
            this.pnl_SerachStudent.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Honeydew;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(856, 29);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(113, 46);
            this.btn_refresh.TabIndex = 20;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_SerchUser
            // 
            this.btn_SerchUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SerchUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SerchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SerchUser.Location = new System.Drawing.Point(660, 35);
            this.btn_SerchUser.Name = "btn_SerchUser";
            this.btn_SerchUser.Size = new System.Drawing.Size(145, 37);
            this.btn_SerchUser.TabIndex = 3;
            this.btn_SerchUser.Text = "Search User";
            this.btn_SerchUser.UseVisualStyleBackColor = false;
            this.btn_SerchUser.Click += new System.EventHandler(this.btn_SerchUser_Click);
            // 
            // txt_UserId
            // 
            this.txt_UserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserId.Location = new System.Drawing.Point(322, 42);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(287, 30);
            this.txt_UserId.TabIndex = 2;
            this.txt_UserId.TextChanged += new System.EventHandler(this.txt_UserId_TextChanged);
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserId.Location = new System.Drawing.Point(122, 43);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(180, 29);
            this.lbl_UserId.TabIndex = 1;
            this.lbl_UserId.Text = "User ID / NIC :";
            // 
            // pic_Student
            // 
            this.pic_Student.Image = ((System.Drawing.Image)(resources.GetObject("pic_Student.Image")));
            this.pic_Student.Location = new System.Drawing.Point(7, 10);
            this.pic_Student.Name = "pic_Student";
            this.pic_Student.Size = new System.Drawing.Size(104, 92);
            this.pic_Student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Student.TabIndex = 0;
            this.pic_Student.TabStop = false;
            // 
            // gdr_Borrowings
            // 
            this.gdr_Borrowings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdr_Borrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Borrowings.Location = new System.Drawing.Point(3, 123);
            this.gdr_Borrowings.Name = "gdr_Borrowings";
            this.gdr_Borrowings.RowHeadersWidth = 51;
            this.gdr_Borrowings.RowTemplate.Height = 24;
            this.gdr_Borrowings.Size = new System.Drawing.Size(997, 228);
            this.gdr_Borrowings.TabIndex = 2;
            this.gdr_Borrowings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Borrowings_CellClick);
            // 
            // pnl_Details
            // 
            this.pnl_Details.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Details.Controls.Add(this.btn_fine);
            this.pnl_Details.Controls.Add(this.btn_Exit);
            this.pnl_Details.Controls.Add(this.btn_ReturnBook);
            this.pnl_Details.Controls.Add(this.txt_Fine);
            this.pnl_Details.Controls.Add(this.lbl_Fine);
            this.pnl_Details.Controls.Add(this.pkr_ReturnBefore);
            this.pnl_Details.Controls.Add(this.pkr_ReturnedDate);
            this.pnl_Details.Controls.Add(this.lbl_ReturnedDate);
            this.pnl_Details.Controls.Add(this.lbl_AcctialReturnDate);
            this.pnl_Details.Controls.Add(this.lbl_IssueDate);
            this.pnl_Details.Controls.Add(this.txt_IssueDate);
            this.pnl_Details.Controls.Add(this.txt_BookID);
            this.pnl_Details.Controls.Add(this.txt_BookName);
            this.pnl_Details.Controls.Add(this.lbl_BookName);
            this.pnl_Details.Location = new System.Drawing.Point(3, 357);
            this.pnl_Details.Name = "pnl_Details";
            this.pnl_Details.Size = new System.Drawing.Size(997, 189);
            this.pnl_Details.TabIndex = 3;
            // 
            // btn_fine
            // 
            this.btn_fine.BackColor = System.Drawing.Color.Honeydew;
            this.btn_fine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fine.Location = new System.Drawing.Point(681, 99);
            this.btn_fine.Name = "btn_fine";
            this.btn_fine.Size = new System.Drawing.Size(77, 37);
            this.btn_fine.TabIndex = 20;
            this.btn_fine.Text = "Fine";
            this.btn_fine.UseVisualStyleBackColor = false;
            this.btn_fine.Click += new System.EventHandler(this.btn_fine_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(851, 117);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(113, 46);
            this.btn_Exit.TabIndex = 20;
            this.btn_Exit.Text = "Cancel";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ReturnBook
            // 
            this.btn_ReturnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_ReturnBook.Location = new System.Drawing.Point(835, 48);
            this.btn_ReturnBook.Name = "btn_ReturnBook";
            this.btn_ReturnBook.Size = new System.Drawing.Size(143, 54);
            this.btn_ReturnBook.TabIndex = 19;
            this.btn_ReturnBook.Text = "Return";
            this.btn_ReturnBook.UseVisualStyleBackColor = false;
            this.btn_ReturnBook.Click += new System.EventHandler(this.btn_ReturnBook_Click);
            // 
            // txt_Fine
            // 
            this.txt_Fine.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_Fine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fine.ForeColor = System.Drawing.Color.Red;
            this.txt_Fine.Location = new System.Drawing.Point(702, 38);
            this.txt_Fine.Name = "txt_Fine";
            this.txt_Fine.ReadOnly = true;
            this.txt_Fine.Size = new System.Drawing.Size(87, 38);
            this.txt_Fine.TabIndex = 18;
            // 
            // lbl_Fine
            // 
            this.lbl_Fine.AutoSize = true;
            this.lbl_Fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fine.Location = new System.Drawing.Point(621, 45);
            this.lbl_Fine.Name = "lbl_Fine";
            this.lbl_Fine.Size = new System.Drawing.Size(64, 24);
            this.lbl_Fine.TabIndex = 17;
            this.lbl_Fine.Text = "Fine :";
            // 
            // pkr_ReturnBefore
            // 
            this.pkr_ReturnBefore.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_ReturnBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_ReturnBefore.Location = new System.Drawing.Point(141, 99);
            this.pkr_ReturnBefore.Name = "pkr_ReturnBefore";
            this.pkr_ReturnBefore.Size = new System.Drawing.Size(396, 27);
            this.pkr_ReturnBefore.TabIndex = 16;
            // 
            // pkr_ReturnedDate
            // 
            this.pkr_ReturnedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_ReturnedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_ReturnedDate.Location = new System.Drawing.Point(141, 150);
            this.pkr_ReturnedDate.Name = "pkr_ReturnedDate";
            this.pkr_ReturnedDate.Size = new System.Drawing.Size(396, 27);
            this.pkr_ReturnedDate.TabIndex = 16;
            // 
            // lbl_ReturnedDate
            // 
            this.lbl_ReturnedDate.AutoSize = true;
            this.lbl_ReturnedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnedDate.Location = new System.Drawing.Point(6, 150);
            this.lbl_ReturnedDate.Name = "lbl_ReturnedDate";
            this.lbl_ReturnedDate.Size = new System.Drawing.Size(156, 24);
            this.lbl_ReturnedDate.TabIndex = 15;
            this.lbl_ReturnedDate.Text = "Returned Date :";
            // 
            // lbl_AcctialReturnDate
            // 
            this.lbl_AcctialReturnDate.AutoSize = true;
            this.lbl_AcctialReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AcctialReturnDate.Location = new System.Drawing.Point(6, 101);
            this.lbl_AcctialReturnDate.Name = "lbl_AcctialReturnDate";
            this.lbl_AcctialReturnDate.Size = new System.Drawing.Size(151, 24);
            this.lbl_AcctialReturnDate.TabIndex = 15;
            this.lbl_AcctialReturnDate.Text = "Return Before :";
            // 
            // lbl_IssueDate
            // 
            this.lbl_IssueDate.AutoSize = true;
            this.lbl_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IssueDate.Location = new System.Drawing.Point(6, 58);
            this.lbl_IssueDate.Name = "lbl_IssueDate";
            this.lbl_IssueDate.Size = new System.Drawing.Size(119, 24);
            this.lbl_IssueDate.TabIndex = 15;
            this.lbl_IssueDate.Text = "Issue Date :";
            // 
            // txt_IssueDate
            // 
            this.txt_IssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IssueDate.Location = new System.Drawing.Point(141, 58);
            this.txt_IssueDate.Name = "txt_IssueDate";
            this.txt_IssueDate.ReadOnly = true;
            this.txt_IssueDate.Size = new System.Drawing.Size(379, 27);
            this.txt_IssueDate.TabIndex = 14;
            // 
            // txt_BookName
            // 
            this.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.Location = new System.Drawing.Point(141, 11);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.ReadOnly = true;
            this.txt_BookName.Size = new System.Drawing.Size(379, 27);
            this.txt_BookName.TabIndex = 14;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.Location = new System.Drawing.Point(5, 14);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(130, 24);
            this.lbl_BookName.TabIndex = 13;
            this.lbl_BookName.Text = "Book Name :";
            // 
            // txt_BookID
            // 
            this.txt_BookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookID.Location = new System.Drawing.Point(625, 147);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.ReadOnly = true;
            this.txt_BookID.Size = new System.Drawing.Size(143, 27);
            this.txt_BookID.TabIndex = 14;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1002, 549);
            this.Controls.Add(this.pnl_Details);
            this.Controls.Add(this.gdr_Borrowings);
            this.Controls.Add(this.pnl_SerachStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.pnl_SerachStudent.ResumeLayout(false);
            this.pnl_SerachStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).EndInit();
            this.pnl_Details.ResumeLayout(false);
            this.pnl_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SerachStudent;
        private System.Windows.Forms.Button btn_SerchUser;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.PictureBox pic_Student;
        private System.Windows.Forms.DataGridView gdr_Borrowings;
        private System.Windows.Forms.Panel pnl_Details;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_ReturnedDate;
        private System.Windows.Forms.Label lbl_AcctialReturnDate;
        private System.Windows.Forms.Label lbl_IssueDate;
        private System.Windows.Forms.TextBox txt_IssueDate;
        private System.Windows.Forms.DateTimePicker pkr_ReturnedDate;
        private System.Windows.Forms.TextBox txt_Fine;
        private System.Windows.Forms.Label lbl_Fine;
        private System.Windows.Forms.Button btn_ReturnBook;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DateTimePicker pkr_ReturnBefore;
        private System.Windows.Forms.Button btn_fine;
        private System.Windows.Forms.TextBox txt_BookID;
    }
}