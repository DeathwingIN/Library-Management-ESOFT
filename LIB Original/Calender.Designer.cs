
namespace LIB_Original
{
    partial class Calender
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.grpbox_Month = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_Member = new System.Windows.Forms.Label();
            this.grpbox_Month.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(172, 81);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(318, 30);
            this.txt_Search.TabIndex = 3;
            // 
            // grpbox_Month
            // 
            this.grpbox_Month.Controls.Add(this.monthCalendar1);
            this.grpbox_Month.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_Month.Location = new System.Drawing.Point(107, 168);
            this.grpbox_Month.Name = "grpbox_Month";
            this.grpbox_Month.Size = new System.Drawing.Size(340, 287);
            this.grpbox_Month.TabIndex = 4;
            this.grpbox_Month.TabStop = false;
            this.grpbox_Month.Text = "Month";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(430, 482);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 43);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(20, 52);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbl_Member
            // 
            this.lbl_Member.AutoSize = true;
            this.lbl_Member.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Member.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Member.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Member.Location = new System.Drawing.Point(34, 79);
            this.lbl_Member.Name = "lbl_Member";
            this.lbl_Member.Size = new System.Drawing.Size(96, 32);
            this.lbl_Member.TabIndex = 5;
            this.lbl_Member.Text = "Date :";
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(580, 553);
            this.Controls.Add(this.lbl_Member);
            this.Controls.Add(this.grpbox_Month);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Exit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(598, 600);
            this.Name = "Calender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calender";
            this.grpbox_Month.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.GroupBox grpbox_Month;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Member;
    }
}