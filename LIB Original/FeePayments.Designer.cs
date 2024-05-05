
namespace LIB_Original
{
    partial class FeePayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeePayments));
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.txt_Payments = new System.Windows.Forms.Label();
            this.txt_Fine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_Nic = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstNAme = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Result = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnl_Data.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Data
            // 
            this.pnl_Data.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Data.Controls.Add(this.txt_Payments);
            this.pnl_Data.Controls.Add(this.txt_Fine);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Controls.Add(this.lbl_UserID);
            this.pnl_Data.Controls.Add(this.lbl_FirstName);
            this.pnl_Data.Controls.Add(this.btn_Print);
            this.pnl_Data.Controls.Add(this.btn_Reset);
            this.pnl_Data.Controls.Add(this.btn_receipt);
            this.pnl_Data.Controls.Add(this.btn_Search);
            this.pnl_Data.Controls.Add(this.textBox5);
            this.pnl_Data.Controls.Add(this.textBox4);
            this.pnl_Data.Controls.Add(this.txt_Nic);
            this.pnl_Data.Controls.Add(this.txt_LastName);
            this.pnl_Data.Controls.Add(this.txt_FirstNAme);
            this.pnl_Data.Controls.Add(this.txt_search);
            this.pnl_Data.Location = new System.Drawing.Point(5, 5);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(588, 530);
            this.pnl_Data.TabIndex = 0;
            // 
            // txt_Payments
            // 
            this.txt_Payments.AutoSize = true;
            this.txt_Payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Payments.Location = new System.Drawing.Point(25, 354);
            this.txt_Payments.Name = "txt_Payments";
            this.txt_Payments.Size = new System.Drawing.Size(127, 20);
            this.txt_Payments.TabIndex = 7;
            this.txt_Payments.Text = "Paid Amount :";
            // 
            // txt_Fine
            // 
            this.txt_Fine.AutoSize = true;
            this.txt_Fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fine.Location = new System.Drawing.Point(28, 300);
            this.txt_Fine.Name = "txt_Fine";
            this.txt_Fine.Size = new System.Drawing.Size(57, 20);
            this.txt_Fine.TabIndex = 7;
            this.txt_Fine.Text = "Fine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "NIC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name :";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(21, 38);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(114, 29);
            this.lbl_UserID.TabIndex = 5;
            this.lbl_UserID.Text = "User ID :";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(25, 138);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(114, 20);
            this.lbl_FirstName.TabIndex = 5;
            this.lbl_FirstName.Text = "First Name :";
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(399, 448);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(128, 44);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(208, 448);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(128, 44);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_receipt
            // 
            this.btn_receipt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receipt.Location = new System.Drawing.Point(12, 448);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(128, 44);
            this.btn_receipt.TabIndex = 4;
            this.btn_receipt.Text = "Receipt";
            this.btn_receipt.UseVisualStyleBackColor = false;
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(479, 37);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 26);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(196, 351);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(290, 30);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(164, 293);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(270, 37);
            this.textBox4.TabIndex = 3;
            // 
            // txt_Nic
            // 
            this.txt_Nic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nic.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nic.Location = new System.Drawing.Point(165, 242);
            this.txt_Nic.Name = "txt_Nic";
            this.txt_Nic.ReadOnly = true;
            this.txt_Nic.Size = new System.Drawing.Size(290, 30);
            this.txt_Nic.TabIndex = 3;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(164, 187);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.ReadOnly = true;
            this.txt_LastName.Size = new System.Drawing.Size(290, 30);
            this.txt_LastName.TabIndex = 3;
            // 
            // txt_FirstNAme
            // 
            this.txt_FirstNAme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirstNAme.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstNAme.Location = new System.Drawing.Point(164, 134);
            this.txt_FirstNAme.MaxLength = 35;
            this.txt_FirstNAme.Name = "txt_FirstNAme";
            this.txt_FirstNAme.ReadOnly = true;
            this.txt_FirstNAme.Size = new System.Drawing.Size(290, 30);
            this.txt_FirstNAme.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(157, 37);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(290, 30);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_Result);
            this.panel1.Location = new System.Drawing.Point(599, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 530);
            this.panel1.TabIndex = 0;
            // 
            // txt_Result
            // 
            this.txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(3, 5);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(400, 514);
            this.txt_Result.TabIndex = 0;
            this.txt_Result.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FeePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1006, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Data);
            this.Name = "FeePayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fee Payments";
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label txt_Payments;
        private System.Windows.Forms.Label txt_Fine;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_Nic;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstNAme;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.RichTextBox txt_Result;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}