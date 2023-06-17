namespace hospitalDbConnect.userC
{
    partial class searchdoc
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
            this.sdpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Appsearch = new System.Windows.Forms.Button();
            this.APPdoc = new System.Windows.Forms.ComboBox();
            this.sdpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdpanel
            // 
            this.sdpanel.Controls.Add(this.panel2);
            this.sdpanel.Controls.Add(this.panel3);
            this.sdpanel.Location = new System.Drawing.Point(0, 0);
            this.sdpanel.Margin = new System.Windows.Forms.Padding(2);
            this.sdpanel.Name = "sdpanel";
            this.sdpanel.Size = new System.Drawing.Size(1244, 678);
            this.sdpanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(91, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 70);
            this.panel2.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search For a Doctor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Appsearch);
            this.panel3.Controls.Add(this.APPdoc);
            this.panel3.Location = new System.Drawing.Point(91, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 365);
            this.panel3.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label5.Size = new System.Drawing.Size(208, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Doctor Name";
            // 
            // Appsearch
            // 
            this.Appsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsearch.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appsearch.Location = new System.Drawing.Point(406, 235);
            this.Appsearch.Margin = new System.Windows.Forms.Padding(2);
            this.Appsearch.Name = "Appsearch";
            this.Appsearch.Padding = new System.Windows.Forms.Padding(3);
            this.Appsearch.Size = new System.Drawing.Size(275, 42);
            this.Appsearch.TabIndex = 40;
            this.Appsearch.Text = "Search the Doctor";
            this.Appsearch.UseVisualStyleBackColor = true;
            this.Appsearch.Click += new System.EventHandler(this.Appsearch_Click_1);
            // 
            // APPdoc
            // 
            this.APPdoc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdoc.FormattingEnabled = true;
            this.APPdoc.Items.AddRange(new object[] {
            "Dr.MRLM Jayarathne",
            "Dr.WD Kavindya",
            "Dr.MDL Rangashan",
            "Dr.Iresha Konara"});
            this.APPdoc.Location = new System.Drawing.Point(526, 96);
            this.APPdoc.Margin = new System.Windows.Forms.Padding(2);
            this.APPdoc.Name = "APPdoc";
            this.APPdoc.Size = new System.Drawing.Size(258, 32);
            this.APPdoc.TabIndex = 43;
            // 
            // searchdoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.sdpanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchdoc";
            this.Size = new System.Drawing.Size(1244, 678);
            this.sdpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sdpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Appsearch;
        private System.Windows.Forms.ComboBox APPdoc;
    }
}
