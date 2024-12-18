namespace resorthub
{
    partial class CALENDAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CALENDAR));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.CONFIRMBTN = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelstart = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.endbtn = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(62, 184);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // CONFIRMBTN
            // 
            this.CONFIRMBTN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CONFIRMBTN.Location = new System.Drawing.Point(614, 425);
            this.CONFIRMBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CONFIRMBTN.Name = "CONFIRMBTN";
            this.CONFIRMBTN.Size = new System.Drawing.Size(141, 32);
            this.CONFIRMBTN.TabIndex = 12;
            this.CONFIRMBTN.Text = "CONTINUE";
            this.CONFIRMBTN.UseVisualStyleBackColor = false;
            this.CONFIRMBTN.Click += new System.EventHandler(this.CONFIRMBTN_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CLEAR.Location = new System.Drawing.Point(129, 409);
            this.CLEAR.Margin = new System.Windows.Forms.Padding(2);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(92, 33);
            this.CLEAR.TabIndex = 15;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(575, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 17;
            // 
            // labelstart
            // 
            this.labelstart.AutoSize = true;
            this.labelstart.BackColor = System.Drawing.Color.Transparent;
            this.labelstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstart.Location = new System.Drawing.Point(572, 204);
            this.labelstart.Name = "labelstart";
            this.labelstart.Size = new System.Drawing.Size(62, 16);
            this.labelstart.TabIndex = 16;
            this.labelstart.Text = "date start";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(575, 307);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // endbtn
            // 
            this.endbtn.AutoSize = true;
            this.endbtn.BackColor = System.Drawing.Color.Transparent;
            this.endbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endbtn.Location = new System.Drawing.Point(572, 288);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(60, 16);
            this.endbtn.TabIndex = 18;
            this.endbtn.Text = "date end";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(319, 184);
            this.monthCalendar2.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 20;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged_1);
            // 
            // CALENDAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 488);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelstart);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.CONFIRMBTN);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CALENDAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALENDAR";
            this.Load += new System.EventHandler(this.CALENDAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button CONFIRMBTN;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelstart;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label endbtn;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}