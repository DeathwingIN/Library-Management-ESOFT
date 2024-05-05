
namespace LIB_Original
{
    partial class UserSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSelection));
            this.picBox_Admin = new System.Windows.Forms.PictureBox();
            this.PicBox_User = new System.Windows.Forms.PictureBox();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Admin
            // 
            this.picBox_Admin.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Admin.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Admin.Image")));
            this.picBox_Admin.Location = new System.Drawing.Point(71, 140);
            this.picBox_Admin.Name = "picBox_Admin";
            this.picBox_Admin.Size = new System.Drawing.Size(238, 230);
            this.picBox_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Admin.TabIndex = 0;
            this.picBox_Admin.TabStop = false;
            this.picBox_Admin.Click += new System.EventHandler(this.picBox_Admin_Click);
            // 
            // PicBox_User
            // 
            this.PicBox_User.BackColor = System.Drawing.Color.Transparent;
            this.PicBox_User.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_User.Image")));
            this.PicBox_User.Location = new System.Drawing.Point(358, 140);
            this.PicBox_User.Name = "PicBox_User";
            this.PicBox_User.Size = new System.Drawing.Size(312, 230);
            this.PicBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_User.TabIndex = 0;
            this.PicBox_User.TabStop = false;
            this.PicBox_User.Click += new System.EventHandler(this.PicBox_User_Click);
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.ForeColor = System.Drawing.Color.Red;
            this.lbl_Close.Location = new System.Drawing.Point(661, 7);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(31, 29);
            this.lbl_Close.TabIndex = 1;
            this.lbl_Close.Text = "X";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click_1);
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.Black;
            this.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(118, 401);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(127, 36);
            this.btn_Admin.TabIndex = 2;
            this.btn_Admin.Text = "ADMIN";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_User
            // 
            this.btn_User.BackColor = System.Drawing.Color.Black;
            this.btn_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.ForeColor = System.Drawing.Color.White;
            this.btn_User.Location = new System.Drawing.Point(442, 401);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(127, 36);
            this.btn_User.TabIndex = 2;
            this.btn_User.Text = "USER";
            this.btn_User.UseVisualStyleBackColor = false;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select User Type,";
            // 
            // UserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.PicBox_User);
            this.Controls.Add(this.picBox_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSelection";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox_Admin;
        private System.Windows.Forms.PictureBox PicBox_User;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Label label1;
    }
}