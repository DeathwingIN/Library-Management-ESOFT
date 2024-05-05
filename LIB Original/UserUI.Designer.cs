
namespace LIB_Original
{
    partial class UserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUI));
            this.strip_Menu = new System.Windows.Forms.MenuStrip();
            this.Dashbord = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowings = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.strip_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // strip_Menu
            // 
            this.strip_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.strip_Menu.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.strip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dashbord,
            this.borrowings,
            this.reservationsToolStripMenuItem,
            this.newToolStripMenuItem,
            this.calenderToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.strip_Menu.Location = new System.Drawing.Point(0, 0);
            this.strip_Menu.Name = "strip_Menu";
            this.strip_Menu.Size = new System.Drawing.Size(1501, 68);
            this.strip_Menu.TabIndex = 0;
            this.strip_Menu.Text = "menuStrip1";
            // 
            // Dashbord
            // 
            this.Dashbord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dashbord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashbord.ForeColor = System.Drawing.Color.White;
            this.Dashbord.Image = ((System.Drawing.Image)(resources.GetObject("Dashbord.Image")));
            this.Dashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashbord.Name = "Dashbord";
            this.Dashbord.Size = new System.Drawing.Size(173, 64);
            this.Dashbord.Text = "Dashbord";
            this.Dashbord.Click += new System.EventHandler(this.Dashbord_Click);
            // 
            // borrowings
            // 
            this.borrowings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.borrowings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowings.ForeColor = System.Drawing.Color.White;
            this.borrowings.Image = ((System.Drawing.Image)(resources.GetObject("borrowings.Image")));
            this.borrowings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowings.Name = "borrowings";
            this.borrowings.Size = new System.Drawing.Size(190, 64);
            this.borrowings.Text = "Borrowings";
            this.borrowings.Click += new System.EventHandler(this.borrowings_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reservationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reservationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservationsToolStripMenuItem.Image")));
            this.reservationsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(199, 64);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(126, 64);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // calenderToolStripMenuItem
            // 
            this.calenderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.calenderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calenderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calenderToolStripMenuItem.Image")));
            this.calenderToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            this.calenderToolStripMenuItem.Size = new System.Drawing.Size(165, 64);
            this.calenderToolStripMenuItem.Text = "Calender";
            this.calenderToolStripMenuItem.Click += new System.EventHandler(this.calenderToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.historyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.Image")));
            this.historyToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 64);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 64);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txt_UserID);
            this.panel1.Controls.Add(this.lbl_UserID);
            this.panel1.Location = new System.Drawing.Point(0, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 128);
            this.panel1.TabIndex = 1;
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.ForeColor = System.Drawing.Color.White;
            this.lbl_UserID.Location = new System.Drawing.Point(12, 13);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(100, 29);
            this.lbl_UserID.TabIndex = 2;
            this.lbl_UserID.Text = "User ID";
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_UserID.Location = new System.Drawing.Point(12, 69);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(100, 30);
            this.txt_UserID.TabIndex = 2;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1501, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.strip_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.strip_Menu.ResumeLayout(false);
            this.strip_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip strip_Menu;
        private System.Windows.Forms.ToolStripMenuItem borrowings;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dashbord;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox txt_UserID;
    }
}