
namespace LIB_Original
{
    partial class UserReservation
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
            this.lbl_GetBefore = new System.Windows.Forms.Label();
            this.pkr_ResrvedDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ReservedDate = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.txt_GetBefore = new System.Windows.Forms.TextBox();
            this.txt_BookId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_Borrowings
            // 
            this.gdr_Borrowings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdr_Borrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Borrowings.Location = new System.Drawing.Point(3, 3);
            this.gdr_Borrowings.Name = "gdr_Borrowings";
            this.gdr_Borrowings.RowHeadersWidth = 51;
            this.gdr_Borrowings.RowTemplate.Height = 24;
            this.gdr_Borrowings.Size = new System.Drawing.Size(1001, 301);
            this.gdr_Borrowings.TabIndex = 4;
            this.gdr_Borrowings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Borrowings_CellClick);
            // 
            // txt_BookName
            // 
            this.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookName.Location = new System.Drawing.Point(192, 334);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.ReadOnly = true;
            this.txt_BookName.Size = new System.Drawing.Size(426, 30);
            this.txt_BookName.TabIndex = 21;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.Location = new System.Drawing.Point(28, 337);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(130, 24);
            this.lbl_BookName.TabIndex = 20;
            this.lbl_BookName.Text = "Book Name :";
            // 
            // lbl_GetBefore
            // 
            this.lbl_GetBefore.AutoSize = true;
            this.lbl_GetBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GetBefore.Location = new System.Drawing.Point(28, 437);
            this.lbl_GetBefore.Name = "lbl_GetBefore";
            this.lbl_GetBefore.Size = new System.Drawing.Size(121, 24);
            this.lbl_GetBefore.TabIndex = 23;
            this.lbl_GetBefore.Text = "Get Before :";
            // 
            // pkr_ResrvedDate
            // 
            this.pkr_ResrvedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_ResrvedDate.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.pkr_ResrvedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_ResrvedDate.Location = new System.Drawing.Point(191, 389);
            this.pkr_ResrvedDate.Name = "pkr_ResrvedDate";
            this.pkr_ResrvedDate.Size = new System.Drawing.Size(427, 27);
            this.pkr_ResrvedDate.TabIndex = 26;
            // 
            // lbl_ReservedDate
            // 
            this.lbl_ReservedDate.AutoSize = true;
            this.lbl_ReservedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReservedDate.Location = new System.Drawing.Point(18, 389);
            this.lbl_ReservedDate.Name = "lbl_ReservedDate";
            this.lbl_ReservedDate.Size = new System.Drawing.Size(159, 24);
            this.lbl_ReservedDate.TabIndex = 25;
            this.lbl_ReservedDate.Text = "Reserved Date :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Location = new System.Drawing.Point(749, 385);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(227, 45);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "Cancel Reservation";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(687, 336);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(86, 20);
            this.lbl_UserID.TabIndex = 29;
            this.lbl_UserID.Text = "User ID :";
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(779, 331);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(47, 30);
            this.txt_UserID.TabIndex = 28;
            // 
            // txt_GetBefore
            // 
            this.txt_GetBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GetBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GetBefore.Location = new System.Drawing.Point(189, 437);
            this.txt_GetBefore.Name = "txt_GetBefore";
            this.txt_GetBefore.ReadOnly = true;
            this.txt_GetBefore.Size = new System.Drawing.Size(426, 30);
            this.txt_GetBefore.TabIndex = 21;
            // 
            // txt_BookId
            // 
            this.txt_BookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookId.Location = new System.Drawing.Point(867, 330);
            this.txt_BookId.Name = "txt_BookId";
            this.txt_BookId.ReadOnly = true;
            this.txt_BookId.Size = new System.Drawing.Size(109, 30);
            this.txt_BookId.TabIndex = 21;
            // 
            // UserReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1006, 490);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pkr_ResrvedDate);
            this.Controls.Add(this.lbl_ReservedDate);
            this.Controls.Add(this.lbl_GetBefore);
            this.Controls.Add(this.txt_GetBefore);
            this.Controls.Add(this.txt_BookId);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.gdr_Borrowings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 537);
            this.Name = "UserReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Borrowings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_Borrowings;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_GetBefore;
        private System.Windows.Forms.DateTimePicker pkr_ResrvedDate;
        private System.Windows.Forms.Label lbl_ReservedDate;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.TextBox txt_GetBefore;
        private System.Windows.Forms.TextBox txt_BookId;
    }
}