
namespace LIB_Original
{
    partial class History
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
            this.gdr_CompleteBooks = new System.Windows.Forms.DataGridView();
            this.lbl_ICompletedBooks = new System.Windows.Forms.Label();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.lbl_IssueDate = new System.Windows.Forms.Label();
            this.txt_IssueDate = new System.Windows.Forms.TextBox();
            this.txt_ReturnedDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_CompleteBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_CompleteBooks
            // 
            this.gdr_CompleteBooks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdr_CompleteBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_CompleteBooks.Location = new System.Drawing.Point(3, 47);
            this.gdr_CompleteBooks.Name = "gdr_CompleteBooks";
            this.gdr_CompleteBooks.RowHeadersWidth = 51;
            this.gdr_CompleteBooks.RowTemplate.Height = 24;
            this.gdr_CompleteBooks.Size = new System.Drawing.Size(999, 394);
            this.gdr_CompleteBooks.TabIndex = 6;
            this.gdr_CompleteBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_CompleteBooks_CellClick);
            // 
            // lbl_ICompletedBooks
            // 
            this.lbl_ICompletedBooks.AutoSize = true;
            this.lbl_ICompletedBooks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ICompletedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ICompletedBooks.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_ICompletedBooks.Location = new System.Drawing.Point(404, 9);
            this.lbl_ICompletedBooks.Name = "lbl_ICompletedBooks";
            this.lbl_ICompletedBooks.Size = new System.Drawing.Size(237, 32);
            this.lbl_ICompletedBooks.TabIndex = 5;
            this.lbl_ICompletedBooks.Text = "Complete Books";
            // 
            // txt_BookName
            // 
            this.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.Location = new System.Drawing.Point(292, 499);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.ReadOnly = true;
            this.txt_BookName.Size = new System.Drawing.Size(441, 27);
            this.txt_BookName.TabIndex = 14;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.Location = new System.Drawing.Point(111, 499);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(130, 24);
            this.lbl_BookName.TabIndex = 13;
            this.lbl_BookName.Text = "Book Name :";
            // 
            // lbl_IssueDate
            // 
            this.lbl_IssueDate.AutoSize = true;
            this.lbl_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IssueDate.Location = new System.Drawing.Point(111, 552);
            this.lbl_IssueDate.Name = "lbl_IssueDate";
            this.lbl_IssueDate.Size = new System.Drawing.Size(119, 24);
            this.lbl_IssueDate.TabIndex = 23;
            this.lbl_IssueDate.Text = "Issue Date :";
            // 
            // txt_IssueDate
            // 
            this.txt_IssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IssueDate.Location = new System.Drawing.Point(292, 549);
            this.txt_IssueDate.Name = "txt_IssueDate";
            this.txt_IssueDate.ReadOnly = true;
            this.txt_IssueDate.Size = new System.Drawing.Size(441, 27);
            this.txt_IssueDate.TabIndex = 22;
            // 
            // txt_ReturnedDate
            // 
            this.txt_ReturnedDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReturnedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReturnedDate.Location = new System.Drawing.Point(292, 604);
            this.txt_ReturnedDate.Name = "txt_ReturnedDate";
            this.txt_ReturnedDate.ReadOnly = true;
            this.txt_ReturnedDate.Size = new System.Drawing.Size(441, 27);
            this.txt_ReturnedDate.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Returned Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(877, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(854, 537);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(110, 53);
            this.txt_total.TabIndex = 14;
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(51, 466);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(86, 20);
            this.lbl_UserID.TabIndex = 27;
            this.lbl_UserID.Text = "User ID :";
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(143, 461);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(47, 30);
            this.txt_UserID.TabIndex = 26;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_IssueDate);
            this.Controls.Add(this.txt_ReturnedDate);
            this.Controls.Add(this.txt_IssueDate);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.gdr_CompleteBooks);
            this.Controls.Add(this.lbl_ICompletedBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.gdr_CompleteBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_CompleteBooks;
        private System.Windows.Forms.Label lbl_ICompletedBooks;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_IssueDate;
        private System.Windows.Forms.TextBox txt_IssueDate;
        private System.Windows.Forms.TextBox txt_ReturnedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox txt_UserID;
    }
}