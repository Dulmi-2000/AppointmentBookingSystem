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
            this.APPdate = new System.Windows.Forms.DateTimePicker();
            this.APPcancel = new System.Windows.Forms.Button();
            this.Appsubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.APPpay = new System.Windows.Forms.TextBox();
            this.APPname = new System.Windows.Forms.TextBox();
            this.APPnumber = new System.Windows.Forms.TextBox();
            this.APPrequestNO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.APPdoc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // APPdate
            // 
            this.APPdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.APPdate.Location = new System.Drawing.Point(524, 237);
            this.APPdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.APPdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.APPdate.Name = "APPdate";
            this.APPdate.Size = new System.Drawing.Size(189, 30);
            this.APPdate.TabIndex = 28;
            // 
            // APPcancel
            // 
            this.APPcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.APPcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.APPcancel.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPcancel.Location = new System.Drawing.Point(1204, 704);
            this.APPcancel.Name = "APPcancel";
            this.APPcancel.Padding = new System.Windows.Forms.Padding(3);
            this.APPcancel.Size = new System.Drawing.Size(116, 43);
            this.APPcancel.TabIndex = 27;
            this.APPcancel.Text = "Cancel";
            this.APPcancel.UseVisualStyleBackColor = true;
            // 
            // Appsubmit
            // 
            this.Appsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsubmit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appsubmit.Location = new System.Drawing.Point(1013, 704);
            this.Appsubmit.Name = "Appsubmit";
            this.Appsubmit.Padding = new System.Windows.Forms.Padding(3);
            this.Appsubmit.Size = new System.Drawing.Size(116, 43);
            this.Appsubmit.TabIndex = 26;
            this.Appsubmit.Text = "Submit";
            this.Appsubmit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 58);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.label5.Size = new System.Drawing.Size(249, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Patient Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Docter ID and Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Appointment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 241);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date";
            // 
            // APPpay
            // 
            this.APPpay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPpay.Location = new System.Drawing.Point(524, 510);
            this.APPpay.Name = "APPpay";
            this.APPpay.Size = new System.Drawing.Size(663, 30);
            this.APPpay.TabIndex = 19;
            // 
            // APPname
            // 
            this.APPname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPname.Location = new System.Drawing.Point(524, 57);
            this.APPname.Name = "APPname";
            this.APPname.Size = new System.Drawing.Size(663, 30);
            this.APPname.TabIndex = 18;
            // 
            // APPnumber
            // 
            this.APPnumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPnumber.Location = new System.Drawing.Point(524, 413);
            this.APPnumber.Name = "APPnumber";
            this.APPnumber.Size = new System.Drawing.Size(663, 30);
            this.APPnumber.TabIndex = 17;
            this.APPnumber.TextChanged += new System.EventHandler(this.APPnumber_TextChanged);
            // 
            // APPrequestNO
            // 
            this.APPrequestNO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPrequestNO.Location = new System.Drawing.Point(524, 143);
            this.APPrequestNO.Name = "APPrequestNO";
            this.APPrequestNO.Size = new System.Drawing.Size(663, 30);
            this.APPrequestNO.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.APPdoc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.APPcancel);
            this.panel1.Controls.Add(this.APPdate);
            this.panel1.Controls.Add(this.Appsubmit);
            this.panel1.Controls.Add(this.APPrequestNO);
            this.panel1.Controls.Add(this.APPnumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.APPname);
            this.panel1.Controls.Add(this.APPpay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(46, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 814);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(46, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1448, 70);
            this.panel2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 43);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book Appointment";
            // 
            // APPdoc
            // 
            this.APPdoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdoc.FormattingEnabled = true;
            this.APPdoc.Items.AddRange(new object[] {
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
            this.APPdoc.Location = new System.Drawing.Point(524, 324);
            this.APPdoc.Name = "APPdoc";
            this.APPdoc.Size = new System.Drawing.Size(313, 31);
            this.APPdoc.TabIndex = 29;
            // 
            // UserControlAPPOINTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlAPPOINTMENT";
            this.Size = new System.Drawing.Size(1541, 945);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker APPdate;
        private System.Windows.Forms.Button APPcancel;
        private System.Windows.Forms.Button Appsubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox APPpay;
        private System.Windows.Forms.TextBox APPname;
        private System.Windows.Forms.TextBox APPnumber;
        private System.Windows.Forms.TextBox APPrequestNO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox APPdoc;
    }
}
