namespace hospitalDbConnect.userC
{
    partial class UserControlAPPOINTMENT
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ba1 = new System.Windows.Forms.TextBox();
            this.APPdate = new System.Windows.Forms.DateTimePicker();
            this.baclear = new System.Windows.Forms.Button();
            this.Appsubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ba3 = new System.Windows.Forms.TextBox();
            this.APPdoc = new System.Windows.Forms.ComboBox();
            this.ba2 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(85, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 70);
            this.panel2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book Appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ba1);
            this.panel1.Controls.Add(this.APPdate);
            this.panel1.Controls.Add(this.baclear);
            this.panel1.Controls.Add(this.Appsubmit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ba3);
            this.panel1.Controls.Add(this.APPdoc);
            this.panel1.Controls.Add(this.ba2);
            this.panel1.Location = new System.Drawing.Point(85, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 525);
            this.panel1.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paid",
            "Not Paid"});
            this.comboBox1.Location = new System.Drawing.Point(424, 370);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 26);
            this.comboBox1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Patient Name";
            // 
            // ba1
            // 
            this.ba1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba1.Location = new System.Drawing.Point(424, 25);
            this.ba1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ba1.Name = "ba1";
            this.ba1.Size = new System.Drawing.Size(495, 26);
            this.ba1.TabIndex = 32;
            // 
            // APPdate
            // 
            this.APPdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.APPdate.Location = new System.Drawing.Point(424, 163);
            this.APPdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.APPdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.APPdate.Name = "APPdate";
            this.APPdate.Size = new System.Drawing.Size(188, 26);
            this.APPdate.TabIndex = 42;
            // 
            // baclear
            // 
            this.baclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baclear.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baclear.Location = new System.Drawing.Point(873, 448);
            this.baclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baclear.Name = "baclear";
            this.baclear.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.baclear.Size = new System.Drawing.Size(88, 42);
            this.baclear.TabIndex = 41;
            this.baclear.Text = "Clear";
            this.baclear.UseVisualStyleBackColor = true;
            this.baclear.Click += new System.EventHandler(this.baclear_Click);
            // 
            // Appsubmit
            // 
            this.Appsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsubmit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appsubmit.Location = new System.Drawing.Point(728, 448);
            this.Appsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Appsubmit.Name = "Appsubmit";
            this.Appsubmit.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Appsubmit.Size = new System.Drawing.Size(88, 42);
            this.Appsubmit.TabIndex = 40;
            this.Appsubmit.Text = "Book";
            this.Appsubmit.UseVisualStyleBackColor = true;
            this.Appsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Patient Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Docter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Appointment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Date";
            // 
            // ba3
            // 
            this.ba3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba3.Location = new System.Drawing.Point(424, 301);
            this.ba3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ba3.Name = "ba3";
            this.ba3.Size = new System.Drawing.Size(495, 26);
            this.ba3.TabIndex = 33;
            // 
            // APPdoc
            // 
            this.APPdoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdoc.FormattingEnabled = true;
            this.APPdoc.Items.AddRange(new object[] {
            "Dr.WD Kavindya",
            "Dr.Nimal Nanayakkara",
            "Dr.Supun Kalhara",
            "Dr.Kumudu Perera"});
            this.APPdoc.Location = new System.Drawing.Point(424, 232);
            this.APPdoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPdoc.Name = "APPdoc";
            this.APPdoc.Size = new System.Drawing.Size(188, 26);
            this.APPdoc.TabIndex = 43;
            // 
            // ba2
            // 
            this.ba2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba2.Location = new System.Drawing.Point(424, 94);
            this.ba2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ba2.Name = "ba2";
            this.ba2.Size = new System.Drawing.Size(495, 26);
            this.ba2.TabIndex = 30;
            this.ba2.TextChanged += new System.EventHandler(this.APPrequestNO_TextChanged);
            // 
            // UserControlAPPOINTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlAPPOINTMENT";
            this.Size = new System.Drawing.Size(1245, 679);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ba1;
        private System.Windows.Forms.DateTimePicker APPdate;
        private System.Windows.Forms.Button baclear;
        private System.Windows.Forms.Button Appsubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ba3;
        private System.Windows.Forms.ComboBox APPdoc;
        private System.Windows.Forms.TextBox ba2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
