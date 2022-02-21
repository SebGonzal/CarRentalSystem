namespace CarRentalSystem.Boundary
{
    partial class ViewAvailability
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
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.Startdate = new System.Windows.Forms.DateTimePicker();
            this.Enddate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AvailList = new System.Windows.Forms.ListBox();
            this.Message = new System.Windows.Forms.Label();
            this.daterange = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Location = new System.Drawing.Point(661, 26);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 26);
            this.Logoutbtn.TabIndex = 0;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Viewbtn
            // 
            this.Viewbtn.Location = new System.Drawing.Point(661, 387);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(75, 23);
            this.Viewbtn.TabIndex = 1;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // Startdate
            // 
            this.Startdate.Location = new System.Drawing.Point(102, 94);
            this.Startdate.MinDate = new System.DateTime(2021, 11, 18, 0, 0, 0, 0);
            this.Startdate.Name = "Startdate";
            this.Startdate.Size = new System.Drawing.Size(262, 22);
            this.Startdate.TabIndex = 2;
            // 
            // Enddate
            // 
            this.Enddate.Location = new System.Drawing.Point(384, 94);
            this.Enddate.MinDate = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            this.Enddate.Name = "Enddate";
            this.Enddate.Size = new System.Drawing.Size(263, 22);
            this.Enddate.TabIndex = 3;
            this.Enddate.Value = new System.DateTime(2021, 11, 19, 22, 50, 9, 0);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(64, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 15);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Car Rental System";
            // 
            // AvailList
            // 
            this.AvailList.FormattingEnabled = true;
            this.AvailList.ItemHeight = 16;
            this.AvailList.Location = new System.Drawing.Point(263, 142);
            this.AvailList.Name = "AvailList";
            this.AvailList.Size = new System.Drawing.Size(241, 180);
            this.AvailList.TabIndex = 5;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(329, 53);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 17);
            this.Message.TabIndex = 11;
            // 
            // daterange
            // 
            this.daterange.AutoSize = true;
            this.daterange.Location = new System.Drawing.Point(270, 123);
            this.daterange.Name = "daterange";
            this.daterange.Size = new System.Drawing.Size(0, 17);
            this.daterange.TabIndex = 12;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(102, 71);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(72, 17);
            this.Start.TabIndex = 13;
            this.Start.Text = "Start Date";
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Location = new System.Drawing.Point(381, 71);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(67, 17);
            this.End.TabIndex = 14;
            this.End.Text = "End Date";
            // 
            // ViewAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.daterange);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.AvailList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enddate);
            this.Controls.Add(this.Startdate);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.Logoutbtn);
            this.Name = "ViewAvailability";
            this.Text = "ViewAvailability";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAvailability_FormClosed);
            this.Load += new System.EventHandler(this.ViewAvailability_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.DateTimePicker Startdate;
        private System.Windows.Forms.DateTimePicker Enddate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox AvailList;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label daterange;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label End;
    }
}