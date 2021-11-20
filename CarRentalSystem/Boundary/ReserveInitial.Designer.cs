namespace CarRentalSystem.Boundary
{
    partial class ReserveInitial
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_car2 = new System.Windows.Forms.Button();
            this.btn_car1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_logout);
            this.groupBox1.Controls.Add(this.btn_view);
            this.groupBox1.Controls.Add(this.btn_car2);
            this.groupBox1.Controls.Add(this.btn_car1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(582, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select a vehicle and click view to see more information.";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(490, 18);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(88, 32);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(258, 266);
            this.btn_view.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(67, 40);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_car2
            // 
            this.btn_car2.Image = global::CarRentalSystem.Properties.Resources._2021_Subaru_Outback;
            this.btn_car2.Location = new System.Drawing.Point(204, 45);
            this.btn_car2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_car2.Name = "btn_car2";
            this.btn_car2.Size = new System.Drawing.Size(165, 114);
            this.btn_car2.TabIndex = 1;
            this.btn_car2.UseVisualStyleBackColor = true;
            this.btn_car2.Click += new System.EventHandler(this.btn_car2_Click);
            // 
            // btn_car1
            // 
            this.btn_car1.Image = global::CarRentalSystem.Properties.Resources._2021_Honda_Civic;
            this.btn_car1.Location = new System.Drawing.Point(11, 45);
            this.btn_car1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_car1.Name = "btn_car1";
            this.btn_car1.Size = new System.Drawing.Size(165, 114);
            this.btn_car1.TabIndex = 0;
            this.btn_car1.UseVisualStyleBackColor = true;
            this.btn_car1.Click += new System.EventHandler(this.btn_car1_Click);
            // 
            // ReserveInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReserveInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReserveInitial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReserveInitial_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_car1;
        private System.Windows.Forms.Button btn_car2;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_logout;
    }
}