
namespace CarRentalSystem
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
            this.btn_car2 = new System.Windows.Forms.Button();
            this.btn_car1 = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_view);
            this.groupBox1.Controls.Add(this.btn_car2);
            this.groupBox1.Controls.Add(this.btn_car1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select a vehicle and click view to see more information.";
            // 
            // btn_car2
            // 
            this.btn_car2.Image = global::CarRentalSystem.Properties.Resources._2021_Subaru_Outback;
            this.btn_car2.Location = new System.Drawing.Point(272, 55);
            this.btn_car2.Name = "btn_car2";
            this.btn_car2.Size = new System.Drawing.Size(220, 140);
            this.btn_car2.TabIndex = 1;
            this.btn_car2.UseVisualStyleBackColor = true;
            this.btn_car2.Click += new System.EventHandler(this.btn_car2_Click);
            // 
            // btn_car1
            // 
            this.btn_car1.Image = global::CarRentalSystem.Properties.Resources._2021_Honda_Civic;
            this.btn_car1.Location = new System.Drawing.Point(15, 55);
            this.btn_car1.Name = "btn_car1";
            this.btn_car1.Size = new System.Drawing.Size(220, 140);
            this.btn_car1.TabIndex = 0;
            this.btn_car1.UseVisualStyleBackColor = true;
            this.btn_car1.Click += new System.EventHandler(this.btn_car1_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(344, 327);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(89, 49);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // ReserveInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReserveInitial";
            this.Text = "ReserveInitial";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_car1;
        private System.Windows.Forms.Button btn_car2;
        private System.Windows.Forms.Button btn_view;
    }
}

