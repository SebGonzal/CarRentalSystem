namespace CarRentalSystem.Boundary
{
    partial class ReservationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_checkDates = new System.Windows.Forms.Button();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.pictureBox_vehicle = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_message);
            this.groupBox1.Controls.Add(this.btn_reserve);
            this.groupBox1.Controls.Add(this.btn_checkDates);
            this.groupBox1.Controls.Add(this.dateTimePicker_End);
            this.groupBox1.Controls.Add(this.dateTimePicker_Start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_model);
            this.groupBox1.Controls.Add(this.lbl_make);
            this.groupBox1.Controls.Add(this.lbl_year);
            this.groupBox1.Controls.Add(this.pictureBox_vehicle);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Information";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(316, 307);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 28);
            this.lbl_message.TabIndex = 11;
            // 
            // btn_reserve
            // 
            this.btn_reserve.Enabled = false;
            this.btn_reserve.Location = new System.Drawing.Point(591, 353);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(178, 66);
            this.btn_reserve.TabIndex = 10;
            this.btn_reserve.Text = "Make reservation";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_checkDates
            // 
            this.btn_checkDates.Location = new System.Drawing.Point(10, 302);
            this.btn_checkDates.Name = "btn_checkDates";
            this.btn_checkDates.Size = new System.Drawing.Size(300, 38);
            this.btn_checkDates.TabIndex = 9;
            this.btn_checkDates.Text = "Check reservation status: ";
            this.btn_checkDates.UseVisualStyleBackColor = true;
            this.btn_checkDates.Click += new System.EventHandler(this.btn_checkDates_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_End.Location = new System.Drawing.Point(110, 390);
            this.dateTimePicker_End.MinDate = new System.DateTime(2021, 11, 18, 0, 0, 0, 0);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_End.TabIndex = 7;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker_Start.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Start.Location = new System.Drawing.Point(110, 354);
            this.dateTimePicker_Start.MinDate = new System.DateTime(2021, 11, 18, 0, 0, 0, 0);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_Start.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "End Date:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(355, 120);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(99, 28);
            this.lbl_model.TabIndex = 3;
            this.lbl_model.Text = "<model>";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Location = new System.Drawing.Point(355, 75);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(91, 28);
            this.lbl_make.TabIndex = 2;
            this.lbl_make.Text = "<make>";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(355, 33);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(81, 28);
            this.lbl_year.TabIndex = 1;
            this.lbl_year.Text = "<year>";
            // 
            // pictureBox_vehicle
            // 
            this.pictureBox_vehicle.Location = new System.Drawing.Point(6, 33);
            this.pictureBox_vehicle.Name = "pictureBox_vehicle";
            this.pictureBox_vehicle.Size = new System.Drawing.Size(320, 180);
            this.pictureBox_vehicle.TabIndex = 0;
            this.pictureBox_vehicle.TabStop = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_checkDates;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.PictureBox pictureBox_vehicle;
        private System.Windows.Forms.Label lbl_message;
    }
}