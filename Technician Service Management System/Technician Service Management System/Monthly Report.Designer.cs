namespace Technician Service Management System
{
    partial class Monthly_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monthly_Report));
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lisReport = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerYears = new System.Windows.Forms.DateTimePicker();
            this.lblTotalincom = new System.Windows.Forms.Label();
            this.dateTimePickerMonths = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(427, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Report";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(14, 355);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(165, 49);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(14, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lisReport
            // 
            this.lisReport.BackColor = System.Drawing.Color.Silver;
            this.lisReport.FormattingEnabled = true;
            this.lisReport.ItemHeight = 15;
            this.lisReport.Location = new System.Drawing.Point(283, 87);
            this.lisReport.Name = "lisReport";
            this.lisReport.Size = new System.Drawing.Size(544, 454);
            this.lisReport.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL INCOME : ";
            // 
            // dateTimePickerYears
            // 
            this.dateTimePickerYears.Location = new System.Drawing.Point(12, 250);
            this.dateTimePickerYears.Name = "dateTimePickerYears";
            this.dateTimePickerYears.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerYears.TabIndex = 6;
            this.dateTimePickerYears.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTotalincom
            // 
            this.lblTotalincom.AutoSize = true;
            this.lblTotalincom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalincom.Location = new System.Drawing.Point(401, 569);
            this.lblTotalincom.Name = "lblTotalincom";
            this.lblTotalincom.Size = new System.Drawing.Size(2, 17);
            this.lblTotalincom.TabIndex = 7;
            // 
            // dateTimePickerMonths
            // 
            this.dateTimePickerMonths.Location = new System.Drawing.Point(12, 314);
            this.dateTimePickerMonths.Name = "dateTimePickerMonths";
            this.dateTimePickerMonths.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerMonths.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please Select The Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Please Select The Month :";
            // 
            // Monthly_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerMonths);
            this.Controls.Add(this.lblTotalincom);
            this.Controls.Add(this.dateTimePickerYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lisReport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Monthly_Report";
            this.Text = "Monthly Report";
            this.Load += new System.EventHandler(this.Monthly_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnView;
        private Button button2;
        private ListBox lisReport;
        private Label label2;
        private DateTimePicker dateTimePickerYears;
        private Label lblTotalincom;
        private DateTimePicker dateTimePickerMonths;
        private Label label3;
        private Label label4;
    }
}