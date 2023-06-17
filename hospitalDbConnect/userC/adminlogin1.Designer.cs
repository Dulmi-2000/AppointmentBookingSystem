namespace hospitalDbConnect.userC
{
    partial class adminlogin1
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
            this.adpass = new System.Windows.Forms.TextBox();
            this.aduser = new System.Windows.Forms.TextBox();
            this.adlogclear = new System.Windows.Forms.Button();
            this.ADMINsubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adpass
            // 
            this.adpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adpass.Location = new System.Drawing.Point(205, 240);
            this.adpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adpass.Name = "adpass";
            this.adpass.Size = new System.Drawing.Size(253, 26);
            this.adpass.TabIndex = 64;
            // 
            // aduser
            // 
            this.aduser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aduser.Location = new System.Drawing.Point(205, 171);
            this.aduser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aduser.Name = "aduser";
            this.aduser.Size = new System.Drawing.Size(253, 26);
            this.aduser.TabIndex = 63;
            // 
            // adlogclear
            // 
            this.adlogclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adlogclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adlogclear.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adlogclear.Location = new System.Drawing.Point(399, 362);
            this.adlogclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adlogclear.Name = "adlogclear";
            this.adlogclear.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.adlogclear.Size = new System.Drawing.Size(100, 42);
            this.adlogclear.TabIndex = 62;
            this.adlogclear.Text = "Clear";
            this.adlogclear.UseVisualStyleBackColor = true;
            this.adlogclear.Click += new System.EventHandler(this.adlogclear_Click);
            // 
            // ADMINsubmit
            // 
            this.ADMINsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADMINsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADMINsubmit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMINsubmit.Location = new System.Drawing.Point(276, 362);
            this.ADMINsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ADMINsubmit.Name = "ADMINsubmit";
            this.ADMINsubmit.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ADMINsubmit.Size = new System.Drawing.Size(100, 42);
            this.ADMINsubmit.TabIndex = 61;
            this.ADMINsubmit.Text = "Login";
            this.ADMINsubmit.UseVisualStyleBackColor = true;
            this.ADMINsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 89);
            this.panel1.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 34);
            this.label4.TabIndex = 58;
            this.label4.Text = "Admin Login";
            // 
            // adminlogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adpass);
            this.Controls.Add(this.aduser);
            this.Controls.Add(this.adlogclear);
            this.Controls.Add(this.ADMINsubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminlogin1";
            this.Size = new System.Drawing.Size(555, 459);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adpass;
        private System.Windows.Forms.TextBox aduser;
        private System.Windows.Forms.Button adlogclear;
        private System.Windows.Forms.Button ADMINsubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}
