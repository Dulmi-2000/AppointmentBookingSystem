namespace hospitalDbConnect.userC
{
    partial class ChangeappForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Deletepanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.patientRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.da5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.TextBox();
            this.APPdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.da4 = new System.Windows.Forms.TextBox();
            this.da3 = new System.Windows.Forms.ComboBox();
            this.da2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.APPcancel = new System.Windows.Forms.Button();
            this.Deletepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Deletepanel
            // 
            this.Deletepanel.BackColor = System.Drawing.Color.AliceBlue;
            this.Deletepanel.Controls.Add(this.panel3);
            this.Deletepanel.Controls.Add(this.patientRecordDataGridView);
            this.Deletepanel.Controls.Add(this.panel2);
            this.Deletepanel.Controls.Add(this.panel4);
            this.Deletepanel.Location = new System.Drawing.Point(0, 0);
            this.Deletepanel.Margin = new System.Windows.Forms.Padding(2);
            this.Deletepanel.Name = "Deletepanel";
            this.Deletepanel.Size = new System.Drawing.Size(1244, 678);
            this.Deletepanel.TabIndex = 0;
            this.Deletepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Deletepanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(636, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 70);
            this.panel3.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Appointment Details";
            // 
            // patientRecordDataGridView
            // 
            this.patientRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRecordDataGridView.Location = new System.Drawing.Point(636, 121);
            this.patientRecordDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.patientRecordDataGridView.Name = "patientRecordDataGridView";
            this.patientRecordDataGridView.RowHeadersWidth = 51;
            this.patientRecordDataGridView.RowTemplate.Height = 24;
            this.patientRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientRecordDataGridView.Size = new System.Drawing.Size(567, 525);
            this.patientRecordDataGridView.TabIndex = 41;
            this.patientRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientRecordDataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(40, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 70);
            this.panel2.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(443, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Change or Delete Appointment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.da5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.AppName);
            this.panel4.Controls.Add(this.APPdate);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.da4);
            this.panel4.Controls.Add(this.da3);
            this.panel4.Controls.Add(this.da2);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.APPcancel);
            this.panel4.Location = new System.Drawing.Point(40, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 525);
            this.panel4.TabIndex = 39;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // da5
            // 
            this.da5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da5.FormattingEnabled = true;
            this.da5.Items.AddRange(new object[] {
            "Paid",
            "Not Paid"});
            this.da5.Location = new System.Drawing.Point(306, 375);
            this.da5.Margin = new System.Windows.Forms.Padding(2);
            this.da5.Name = "da5";
            this.da5.Size = new System.Drawing.Size(188, 26);
            this.da5.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Patient Name";
            // 
            // AppName
            // 
            this.AppName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(306, 30);
            this.AppName.Margin = new System.Windows.Forms.Padding(2);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(248, 26);
            this.AppName.TabIndex = 58;
            // 
            // APPdate
            // 
            this.APPdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.APPdate.Location = new System.Drawing.Point(306, 168);
            this.APPdate.Margin = new System.Windows.Forms.Padding(2);
            this.APPdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.APPdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.APPdate.Name = "APPdate";
            this.APPdate.Size = new System.Drawing.Size(188, 26);
            this.APPdate.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 379);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 65;
            this.label6.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 22);
            this.label4.TabIndex = 63;
            this.label4.Text = "Patient Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 62;
            this.label3.Text = "Docter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "Appointment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Date";
            // 
            // da4
            // 
            this.da4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da4.Location = new System.Drawing.Point(306, 306);
            this.da4.Margin = new System.Windows.Forms.Padding(2);
            this.da4.Name = "da4";
            this.da4.Size = new System.Drawing.Size(248, 26);
            this.da4.TabIndex = 59;
            // 
            // da3
            // 
            this.da3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da3.FormattingEnabled = true;
            this.da3.Items.AddRange(new object[] {
            "1 - Jayathissa",
            "2 - Piyathissa",
            "3 - Wijenayaka",
            "4 - Jayarathne",
            "5 - Lasi",
            "6 - Lahiru",
            "7 - Dulmi",
            "8 - Aishu",
            "9 - Kavidu",
            "10 - Wijerathne"});
            this.da3.Location = new System.Drawing.Point(306, 237);
            this.da3.Margin = new System.Windows.Forms.Padding(2);
            this.da3.Name = "da3";
            this.da3.Size = new System.Drawing.Size(188, 26);
            this.da3.TabIndex = 67;
            // 
            // da2
            // 
            this.da2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da2.Location = new System.Drawing.Point(306, 99);
            this.da2.Margin = new System.Windows.Forms.Padding(2);
            this.da2.Name = "da2";
            this.da2.Size = new System.Drawing.Size(248, 26);
            this.da2.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(114, 456);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(88, 42);
            this.button2.TabIndex = 56;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 55;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // APPcancel
            // 
            this.APPcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.APPcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.APPcancel.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPcancel.Location = new System.Drawing.Point(337, 456);
            this.APPcancel.Margin = new System.Windows.Forms.Padding(2);
            this.APPcancel.Name = "APPcancel";
            this.APPcancel.Padding = new System.Windows.Forms.Padding(3);
            this.APPcancel.Size = new System.Drawing.Size(88, 42);
            this.APPcancel.TabIndex = 41;
            this.APPcancel.Text = "Clear";
            this.APPcancel.UseVisualStyleBackColor = true;
            this.APPcancel.Click += new System.EventHandler(this.APPcancel_Click);
            // 
            // ChangeappForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Deletepanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeappForm";
            this.Size = new System.Drawing.Size(1244, 678);
            this.Deletepanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Deletepanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView patientRecordDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox da5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AppName;
        private System.Windows.Forms.DateTimePicker APPdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox da4;
        private System.Windows.Forms.ComboBox da3;
        private System.Windows.Forms.TextBox da2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button APPcancel;
    }
}
