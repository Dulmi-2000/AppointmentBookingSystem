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
            this.APPdoc = new System.Windows.Forms.TextBox();
            this.APPrequestNO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // APPdate
            // 
            this.APPdate.Location = new System.Drawing.Point(247, 191);
            this.APPdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.APPdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.APPdate.Name = "APPdate";
            this.APPdate.Size = new System.Drawing.Size(151, 20);
            this.APPdate.TabIndex = 28;
            // 
            // APPcancel
            // 
            this.APPcancel.Location = new System.Drawing.Point(770, 442);
            this.APPcancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPcancel.Name = "APPcancel";
            this.APPcancel.Size = new System.Drawing.Size(56, 19);
            this.APPcancel.TabIndex = 27;
            this.APPcancel.Text = "Cancel";
            this.APPcancel.UseVisualStyleBackColor = true;
            // 
            // Appsubmit
            // 
            this.Appsubmit.Location = new System.Drawing.Point(653, 442);
            this.Appsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Appsubmit.Name = "Appsubmit";
            this.Appsubmit.Size = new System.Drawing.Size(56, 19);
            this.Appsubmit.TabIndex = 26;
            this.Appsubmit.Text = "Submit";
            this.Appsubmit.UseVisualStyleBackColor = true;
            this.Appsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(99, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(99, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(99, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Patient Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(99, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Docter ID and Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(99, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Appointment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(99, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date";
            // 
            // APPpay
            // 
            this.APPpay.Location = new System.Drawing.Point(247, 350);
            this.APPpay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPpay.Name = "APPpay";
            this.APPpay.Size = new System.Drawing.Size(151, 20);
            this.APPpay.TabIndex = 19;
            // 
            // APPname
            // 
            this.APPname.Location = new System.Drawing.Point(254, 74);
            this.APPname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPname.Name = "APPname";
            this.APPname.Size = new System.Drawing.Size(144, 20);
            this.APPname.TabIndex = 18;
            // 
            // APPnumber
            // 
            this.APPnumber.Location = new System.Drawing.Point(247, 292);
            this.APPnumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPnumber.Name = "APPnumber";
            this.APPnumber.Size = new System.Drawing.Size(151, 20);
            this.APPnumber.TabIndex = 17;
            // 
            // APPdoc
            // 
            this.APPdoc.Location = new System.Drawing.Point(247, 241);
            this.APPdoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPdoc.Name = "APPdoc";
            this.APPdoc.Size = new System.Drawing.Size(151, 20);
            this.APPdoc.TabIndex = 16;
            // 
            // APPrequestNO
            // 
            this.APPrequestNO.Location = new System.Drawing.Point(254, 132);
            this.APPrequestNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPrequestNO.Name = "APPrequestNO";
            this.APPrequestNO.Size = new System.Drawing.Size(144, 20);
            this.APPrequestNO.TabIndex = 15;
            // 
            // UserControlAPPOINTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.APPdate);
            this.Controls.Add(this.APPcancel);
            this.Controls.Add(this.Appsubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APPpay);
            this.Controls.Add(this.APPname);
            this.Controls.Add(this.APPnumber);
            this.Controls.Add(this.APPdoc);
            this.Controls.Add(this.APPrequestNO);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlAPPOINTMENT";
            this.Size = new System.Drawing.Size(925, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox APPdoc;
        private System.Windows.Forms.TextBox APPrequestNO;
    }
}
