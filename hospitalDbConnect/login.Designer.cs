namespace hospitalDbConnect
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receptbutt = new System.Windows.Forms.Button();
            this.Appsubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.AliceBlue;
            this.loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginpanel.Controls.Add(this.pictureBox2);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Location = new System.Drawing.Point(257, 12);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(742, 567);
            this.loginpanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 73);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.receptbutt);
            this.panel1.Controls.Add(this.Appsubmit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 567);
            this.panel1.TabIndex = 2;
            // 
            // receptbutt
            // 
            this.receptbutt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.receptbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receptbutt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receptbutt.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receptbutt.Location = new System.Drawing.Point(24, 153);
            this.receptbutt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receptbutt.Name = "receptbutt";
            this.receptbutt.Padding = new System.Windows.Forms.Padding(4);
            this.receptbutt.Size = new System.Drawing.Size(183, 52);
            this.receptbutt.TabIndex = 42;
            this.receptbutt.Text = "Receptionist ";
            this.receptbutt.UseVisualStyleBackColor = false;
            this.receptbutt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Appsubmit
            // 
            this.Appsubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Appsubmit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsubmit.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appsubmit.Location = new System.Drawing.Point(24, 314);
            this.Appsubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appsubmit.Name = "Appsubmit";
            this.Appsubmit.Padding = new System.Windows.Forms.Padding(4);
            this.Appsubmit.Size = new System.Drawing.Size(183, 52);
            this.Appsubmit.TabIndex = 41;
            this.Appsubmit.Text = "Admin";
            this.Appsubmit.UseVisualStyleBackColor = false;
            this.Appsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 1282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button receptbutt;
        private System.Windows.Forms.Button Appsubmit;
    }
}