namespace hospitalDbConnect.userC
{
    partial class changeapp
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
            this.ChangeAppPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.APPdate = new System.Windows.Forms.DateTimePicker();
            this.Appsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.APPdoc = new System.Windows.Forms.ComboBox();
            this.ChangeAppPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeAppPanel
            // 
            this.ChangeAppPanel.Controls.Add(this.panel2);
            this.ChangeAppPanel.Controls.Add(this.panel3);
            this.ChangeAppPanel.Location = new System.Drawing.Point(0, 0);
            this.ChangeAppPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeAppPanel.Name = "ChangeAppPanel";
            this.ChangeAppPanel.Size = new System.Drawing.Size(1244, 678);
            this.ChangeAppPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(91, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 70);
            this.panel2.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Change an  Appointment";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.APPdate);
            this.panel3.Controls.Add(this.Appsearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.APPdoc);
            this.panel3.Location = new System.Drawing.Point(91, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 440);
            this.panel3.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label5.Size = new System.Drawing.Size(221, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Appointment No";
            // 
            // APPdate
            // 
            this.APPdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.APPdate.Location = new System.Drawing.Point(526, 182);
            this.APPdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.APPdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.APPdate.Name = "APPdate";
            this.APPdate.Size = new System.Drawing.Size(188, 26);
            this.APPdate.TabIndex = 42;
            // 
            // Appsearch
            // 
            this.Appsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsearch.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appsearch.Location = new System.Drawing.Point(386, 304);
            this.Appsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Appsearch.Name = "Appsearch";
            this.Appsearch.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Appsearch.Size = new System.Drawing.Size(279, 42);
            this.Appsearch.TabIndex = 40;
            this.Appsearch.Text = "Search for Appointment";
            this.Appsearch.UseVisualStyleBackColor = true;
            this.Appsearch.Click += new System.EventHandler(this.Appsubmit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(237, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Appointment Date";
            // 
            // APPdoc
            // 
            this.APPdoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdoc.FormattingEnabled = true;
            this.APPdoc.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.APPdoc.Location = new System.Drawing.Point(526, 96);
            this.APPdoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.APPdoc.Name = "APPdoc";
            this.APPdoc.Size = new System.Drawing.Size(258, 26);
            this.APPdoc.TabIndex = 43;
            // 
            // changeapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.ChangeAppPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "changeapp";
            this.Size = new System.Drawing.Size(1244, 678);
            this.ChangeAppPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChangeAppPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker APPdate;
        private System.Windows.Forms.Button Appsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox APPdoc;
    }
}
