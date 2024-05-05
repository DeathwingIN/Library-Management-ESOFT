
namespace LIB_Original
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.picbox_LoginIcon = new System.Windows.Forms.PictureBox();
            this.picbox_Close = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.picbox_UserName = new System.Windows.Forms.PictureBox();
            this.picbox_Password = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_ClearFields = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_LoginIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_LoginIcon
            // 
            this.picbox_LoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("picbox_LoginIcon.Image")));
            this.picbox_LoginIcon.Location = new System.Drawing.Point(166, 60);
            this.picbox_LoginIcon.Name = "picbox_LoginIcon";
            this.picbox_LoginIcon.Size = new System.Drawing.Size(156, 154);
            this.picbox_LoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_LoginIcon.TabIndex = 0;
            this.picbox_LoginIcon.TabStop = false;
            // 
            // picbox_Close
            // 
            this.picbox_Close.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Close.Image")));
            this.picbox_Close.Location = new System.Drawing.Point(480, 7);
            this.picbox_Close.Name = "picbox_Close";
            this.picbox_Close.Size = new System.Drawing.Size(32, 31);
            this.picbox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Close.TabIndex = 1;
            this.picbox_Close.TabStop = false;
            this.picbox_Close.Click += new System.EventHandler(this.picbox_Close_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_Login.Location = new System.Drawing.Point(160, 249);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(166, 54);
            this.lbl_Login.TabIndex = 2;
            this.lbl_Login.Text = "LOG IN";
            // 
            // picbox_UserName
            // 
            this.picbox_UserName.Image = ((System.Drawing.Image)(resources.GetObject("picbox_UserName.Image")));
            this.picbox_UserName.Location = new System.Drawing.Point(80, 391);
            this.picbox_UserName.Name = "picbox_UserName";
            this.picbox_UserName.Size = new System.Drawing.Size(32, 31);
            this.picbox_UserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_UserName.TabIndex = 1;
            this.picbox_UserName.TabStop = false;
            this.picbox_UserName.Click += new System.EventHandler(this.picbox_Close_Click);
            // 
            // picbox_Password
            // 
            this.picbox_Password.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Password.Image")));
            this.picbox_Password.Location = new System.Drawing.Point(80, 476);
            this.picbox_Password.Name = "picbox_Password";
            this.picbox_Password.Size = new System.Drawing.Size(32, 31);
            this.picbox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Password.TabIndex = 1;
            this.picbox_Password.TabStop = false;
            this.picbox_Password.Click += new System.EventHandler(this.picbox_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(79, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 2);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(79, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 2);
            this.panel2.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(104, 600);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(296, 39);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "LOG IN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_ClearFields
            // 
            this.lbl_ClearFields.AutoSize = true;
            this.lbl_ClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClearFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_ClearFields.Location = new System.Drawing.Point(376, 553);
            this.lbl_ClearFields.Name = "lbl_ClearFields";
            this.lbl_ClearFields.Size = new System.Drawing.Size(111, 20);
            this.lbl_ClearFields.TabIndex = 5;
            this.lbl_ClearFields.Text = "Clear Fields";
            this.lbl_ClearFields.Click += new System.EventHandler(this.lbl_ClearFields_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.txt_UserName.Location = new System.Drawing.Point(129, 395);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(262, 29);
            this.txt_UserName.TabIndex = 6;
            this.txt_UserName.Text = "User ID";
            this.txt_UserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_UserName_MouseClick);
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.txt_Password.Location = new System.Drawing.Point(129, 488);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(268, 30);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.Text = "Password";
            this.txt_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Password_MouseClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 677);
            this.Controls.Add(this.lbl_ClearFields);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.picbox_Password);
            this.Controls.Add(this.picbox_UserName);
            this.Controls.Add(this.picbox_Close);
            this.Controls.Add(this.picbox_LoginIcon);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_LoginIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_LoginIcon;
        private System.Windows.Forms.PictureBox picbox_Close;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.PictureBox picbox_UserName;
        private System.Windows.Forms.PictureBox picbox_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_ClearFields;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
    }
}