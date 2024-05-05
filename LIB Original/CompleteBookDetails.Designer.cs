
namespace LIB_Original
{
    partial class CompleteBookDetails
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
            this.lbl_IssuedBooks = new System.Windows.Forms.Label();
            this.gdr_IssuedBooks = new System.Windows.Forms.DataGridView();
            this.lbl_ReturnedBooks = new System.Windows.Forms.Label();
            this.gdr_ReturnedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_IssuedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_ReturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IssuedBooks
            // 
            this.lbl_IssuedBooks.AutoSize = true;
            this.lbl_IssuedBooks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IssuedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IssuedBooks.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_IssuedBooks.Location = new System.Drawing.Point(452, 4);
            this.lbl_IssuedBooks.Name = "lbl_IssuedBooks";
            this.lbl_IssuedBooks.Size = new System.Drawing.Size(196, 32);
            this.lbl_IssuedBooks.TabIndex = 3;
            this.lbl_IssuedBooks.Text = "Issued Books";
            // 
            // gdr_IssuedBooks
            // 
            this.gdr_IssuedBooks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdr_IssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_IssuedBooks.Location = new System.Drawing.Point(6, 43);
            this.gdr_IssuedBooks.Name = "gdr_IssuedBooks";
            this.gdr_IssuedBooks.RowHeadersWidth = 51;
            this.gdr_IssuedBooks.RowTemplate.Height = 24;
            this.gdr_IssuedBooks.Size = new System.Drawing.Size(999, 233);
            this.gdr_IssuedBooks.TabIndex = 4;
            // 
            // lbl_ReturnedBooks
            // 
            this.lbl_ReturnedBooks.AutoSize = true;
            this.lbl_ReturnedBooks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReturnedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnedBooks.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_ReturnedBooks.Location = new System.Drawing.Point(452, 295);
            this.lbl_ReturnedBooks.Name = "lbl_ReturnedBooks";
            this.lbl_ReturnedBooks.Size = new System.Drawing.Size(232, 32);
            this.lbl_ReturnedBooks.TabIndex = 3;
            this.lbl_ReturnedBooks.Text = "Returned Books";
            // 
            // gdr_ReturnedBooks
            // 
            this.gdr_ReturnedBooks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdr_ReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_ReturnedBooks.Location = new System.Drawing.Point(6, 342);
            this.gdr_ReturnedBooks.Name = "gdr_ReturnedBooks";
            this.gdr_ReturnedBooks.RowHeadersWidth = 51;
            this.gdr_ReturnedBooks.RowTemplate.Height = 24;
            this.gdr_ReturnedBooks.Size = new System.Drawing.Size(999, 228);
            this.gdr_ReturnedBooks.TabIndex = 4;
            // 
            // CompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1006, 577);
            this.Controls.Add(this.gdr_ReturnedBooks);
            this.Controls.Add(this.gdr_IssuedBooks);
            this.Controls.Add(this.lbl_ReturnedBooks);
            this.Controls.Add(this.lbl_IssuedBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 624);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 624);
            this.Name = "CompleteBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Book Details";
            this.Load += new System.EventHandler(this.CompleteBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_IssuedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_ReturnedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IssuedBooks;
        private System.Windows.Forms.DataGridView gdr_IssuedBooks;
        private System.Windows.Forms.Label lbl_ReturnedBooks;
        private System.Windows.Forms.DataGridView gdr_ReturnedBooks;
    }
}