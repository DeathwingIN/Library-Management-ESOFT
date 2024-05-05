
namespace LIB_Original
{
    partial class UserBorrowings
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
            this.gdr_Borrowings = new System.Windows.Forms.DataGridView();
            this.lbl_AcctialReturnDate = new System.Windows.Forms.Label();
            this.lbl_IssueDate = new System.Windows.Forms.Label();
            this.txt_IssueDate = new System.Windows.Forms.TextBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.btn_Renew3Days = new System.Windows.Forms.Button();
            this.txt_Renewcount = new System.Windows.Forms.TextBox();
            this.lbl_RenewCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.txt_Returndate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_Borrowings
            // 
            this.gdr_Borrowings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdr_Borrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Borrowings.Location = new System.Drawing.Point(3, 7);
            this.gdr_Borrowings.Name = "gdr_Borrowings";
            this.gdr_Borrowings.RowHeadersWidth = 51;
            this.gdr_Borrowings.RowTemplate.Height = 24;
            this.gdr_Borrowings.Size = new System.Drawing.Size(1001, 301);
            this.gdr_Borrowings.TabIndex = 3;
            this.gdr_Borrowings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Borrowings_CellClick);
            // 
            // lbl_AcctialReturnDate
            // 
            this.lbl_AcctialReturnDate.AutoSize = true;
            this.lbl_AcctialReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AcctialReturnDate.Location = new System.Drawing.Point(29, 437);
            this.lbl_AcctialReturnDate.Name = "lbl_AcctialReturnDate";
            this.lbl_AcctialReturnDate.Size = new System.Drawing.Size(151, 24);
            this.lbl_AcctialReturnDate.TabIndex = 20;
            this.lbl_AcctialReturnDate.Text = "Return Before :";
            // 
            // lbl_IssueDate
            // 
            this.lbl_IssueDate.AutoSize = true;
            this.lbl_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IssueDate.Location = new System.Drawing.Point(29, 394);
            this.lbl_IssueDate.Name = "lbl_IssueDate";
            this.lbl_IssueDate.Size = new System.Drawing.Size(119, 24);
            this.lbl_IssueDate.TabIndex = 21;
            this.lbl_IssueDate.Text = "Issue Date :";
            // 
            // txt_IssueDate
            // 
            this.txt_IssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IssueDate.Location = new System.Drawing.Point(181, 394);
            this.txt_IssueDate.Name = "txt_IssueDate";
            this.txt_IssueDate.ReadOnly = true;
            this.txt_IssueDate.Size = new System.Drawing.Size(426, 27);
            this.txt_IssueDate.TabIndex = 18;
            // 
            // txt_BookName
            // 
            this.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.Location = new System.Drawing.Point(181, 347);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.ReadOnly = true;
            this.txt_BookName.Size = new System.Drawing.Size(426, 27);
            this.txt_BookName.TabIndex = 19;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.Location = new System.Drawing.Point(28, 350);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(130, 24);
            this.lbl_BookName.TabIndex = 17;
            this.lbl_BookName.Text = "Book Name :";
            // 
            // btn_Renew3Days
            // 
            this.btn_Renew3Days.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Renew3Days.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Renew3Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Renew3Days.Location = new System.Drawing.Point(768, 383);
            this.btn_Renew3Days.Name = "btn_Renew3Days";
            this.btn_Renew3Days.Size = new System.Drawing.Size(141, 45);
            this.btn_Renew3Days.TabIndex = 23;
            this.btn_Renew3Days.Text = "Renew";
            this.btn_Renew3Days.UseVisualStyleBackColor = false;
            this.btn_Renew3Days.Click += new System.EventHandler(this.btn_Renew3Days_Click);
            // 
            // txt_Renewcount
            // 
            this.txt_Renewcount.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Renewcount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Renewcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Renewcount.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_Renewcount.Location = new System.Drawing.Point(856, 334);
            this.txt_Renewcount.Name = "txt_Renewcount";
            this.txt_Renewcount.ReadOnly = true;
            this.txt_Renewcount.Size = new System.Drawing.Size(61, 31);
            this.txt_Renewcount.TabIndex = 18;
            // 
            // lbl_RenewCount
            // 
            this.lbl_RenewCount.AutoSize = true;
            this.lbl_RenewCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RenewCount.Location = new System.Drawing.Point(708, 337);
            this.lbl_RenewCount.Name = "lbl_RenewCount";
            this.lbl_RenewCount.Size = new System.Drawing.Size(148, 24);
            this.lbl_RenewCount.TabIndex = 17;
            this.lbl_RenewCount.Text = "Renew Count :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(734, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Max 3 Times Only !!!";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(28, 321);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(86, 20);
            this.lbl_UserID.TabIndex = 25;
            this.lbl_UserID.Text = "User ID :";
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(120, 316);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(47, 30);
            this.txt_UserID.TabIndex = 24;
            // 
            // txt_Returndate
            // 
            this.txt_Returndate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Returndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Returndate.Location = new System.Drawing.Point(181, 437);
            this.txt_Returndate.Name = "txt_Returndate";
            this.txt_Returndate.ReadOnly = true;
            this.txt_Returndate.Size = new System.Drawing.Size(426, 27);
            this.txt_Returndate.TabIndex = 18;
            // 
            // UserBorrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1006, 490);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.btn_Renew3Days);
            this.Controls.Add(this.lbl_AcctialReturnDate);
            this.Controls.Add(this.lbl_IssueDate);
            this.Controls.Add(this.txt_Renewcount);
            this.Controls.Add(this.txt_Returndate);
            this.Controls.Add(this.txt_IssueDate);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_RenewCount);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.gdr_Borrowings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 537);
            this.Name = "UserBorrowings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Borrowings";
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_Borrowings;
        private System.Windows.Forms.Label lbl_AcctialReturnDate;
        private System.Windows.Forms.Label lbl_IssueDate;
        private System.Windows.Forms.TextBox txt_IssueDate;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Button btn_Renew3Days;
        private System.Windows.Forms.TextBox txt_Renewcount;
        private System.Windows.Forms.Label lbl_RenewCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.TextBox txt_Returndate;
    }
}