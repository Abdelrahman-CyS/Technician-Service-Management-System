namespace Technician Service Management System
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newpasstextBox3 = new System.Windows.Forms.TextBox();
            this.CnfnewpasstextBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 201);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset \r\nYour \r\nPassword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "_____________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(75, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your New Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(75, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confirm New Password :";
            // 
            // newpasstextBox3
            // 
            this.newpasstextBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpasstextBox3.Location = new System.Drawing.Point(75, 522);
            this.newpasstextBox3.Name = "newpasstextBox3";
            this.newpasstextBox3.Size = new System.Drawing.Size(425, 34);
            this.newpasstextBox3.TabIndex = 7;
            // 
            // CnfnewpasstextBox4
            // 
            this.CnfnewpasstextBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CnfnewpasstextBox4.Location = new System.Drawing.Point(75, 676);
            this.CnfnewpasstextBox4.Name = "CnfnewpasstextBox4";
            this.CnfnewpasstextBox4.Size = new System.Drawing.Size(425, 34);
            this.CnfnewpasstextBox4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(110, 900);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(678, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 792);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 67F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CnfnewpasstextBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newpasstextBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox newpasstextBox3;
        private TextBox CnfnewpasstextBox4;
        private Button button1;
        private PictureBox pictureBox1;
    }
}