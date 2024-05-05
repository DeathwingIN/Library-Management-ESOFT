
namespace LIB_Original
{
    partial class BookList
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
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.lbl_BookID = new System.Windows.Forms.Label();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_Borrowings
            // 
            this.gdr_Borrowings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdr_Borrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Borrowings.Location = new System.Drawing.Point(3, 2);
            this.gdr_Borrowings.MultiSelect = false;
            this.gdr_Borrowings.Name = "gdr_Borrowings";
            this.gdr_Borrowings.ReadOnly = true;
            this.gdr_Borrowings.RowHeadersWidth = 51;
            this.gdr_Borrowings.RowTemplate.Height = 24;
            this.gdr_Borrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdr_Borrowings.Size = new System.Drawing.Size(1004, 443);
            this.gdr_Borrowings.TabIndex = 5;
            this.gdr_Borrowings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Borrowings_CellClick);
            // 
            // txt_BookName
            // 
            this.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.Location = new System.Drawing.Point(252, 469);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.ReadOnly = true;
            this.txt_BookName.Size = new System.Drawing.Size(426, 30);
            this.txt_BookName.TabIndex = 23;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.Location = new System.Drawing.Point(88, 472);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(130, 24);
            this.lbl_BookName.TabIndex = 22;
            this.lbl_BookName.Text = "Book Name :";
            // 
            // lbl_BookID
            // 
            this.lbl_BookID.AutoSize = true;
            this.lbl_BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookID.Location = new System.Drawing.Point(88, 518);
            this.lbl_BookID.Name = "lbl_BookID";
            this.lbl_BookID.Size = new System.Drawing.Size(94, 24);
            this.lbl_BookID.TabIndex = 22;
            this.lbl_BookID.Text = "Book ID :";
            // 
            // txt_BookID
            // 
            this.txt_BookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookID.Location = new System.Drawing.Point(252, 512);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.ReadOnly = true;
            this.txt_BookID.Size = new System.Drawing.Size(426, 30);
            this.txt_BookID.TabIndex = 23;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.txt_BookID);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.lbl_BookID);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.gdr_Borrowings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book List";
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_Borrowings;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_BookID;
        private System.Windows.Forms.TextBox txt_BookID;
    }
}