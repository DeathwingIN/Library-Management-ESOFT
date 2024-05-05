
namespace LIB_Original
{
    partial class ADMINUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINUI));
            this.strip_Menu = new System.Windows.Forms.MenuStrip();
            this.Dashbord = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowings = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Menu.SuspendLayout();
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
            this.fineToolStripMenuItem,
            this.toolStripMenuItem1,
            this.calenderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.strip_Menu.Location = new System.Drawing.Point(0, 0);
            this.strip_Menu.Name = "strip_Menu";
            this.strip_Menu.Size = new System.Drawing.Size(1483, 68);
            this.strip_Menu.TabIndex = 1;
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
            this.Dashbord.Size = new System.Drawing.Size(152, 64);
            this.Dashbord.Text = "Catlogs";
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
            this.borrowings.Size = new System.Drawing.Size(169, 64);
            this.borrowings.Text = "Members";
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
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(190, 64);
            this.reservationsToolStripMenuItem.Text = "Issue Books";
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(207, 64);
            this.newToolStripMenuItem.Text = "Return Books";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // fineToolStripMenuItem
            // 
            this.fineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fineToolStripMenuItem.Image")));
            this.fineToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fineToolStripMenuItem.Name = "fineToolStripMenuItem";
            this.fineToolStripMenuItem.Size = new System.Drawing.Size(287, 64);
            this.fineToolStripMenuItem.Text = "Complete Book Details";
            this.fineToolStripMenuItem.Click += new System.EventHandler(this.fineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 64);
            this.toolStripMenuItem1.Text = "Fine";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            // ADMINUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 709);
            this.Controls.Add(this.strip_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADMINUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.strip_Menu.ResumeLayout(false);
            this.strip_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip strip_Menu;
        private System.Windows.Forms.ToolStripMenuItem Dashbord;
        private System.Windows.Forms.ToolStripMenuItem borrowings;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}