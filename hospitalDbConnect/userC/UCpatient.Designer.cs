namespace hospitalDbConnect
{
    partial class UCpatient
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
            this.registerBttn = new System.Windows.Forms.Button();
            this.clearBttn = new System.Windows.Forms.Button();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientAgeLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.patientAgeTextBox = new System.Windows.Forms.TextBox();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maleRadioBttn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBttn = new System.Windows.Forms.RadioButton();
            this.patientRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.updateBttn = new System.Windows.Forms.Button();
            this.deleteBttn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerBttn
            // 
            this.registerBttn.Location = new System.Drawing.Point(3, 3);
            this.registerBttn.Name = "registerBttn";
            this.registerBttn.Size = new System.Drawing.Size(117, 37);
            this.registerBttn.TabIndex = 0;
            this.registerBttn.Text = "REGISTER";
            this.registerBttn.UseVisualStyleBackColor = true;
            this.registerBttn.Click += new System.EventHandler(this.registerBttn_Click);
            // 
            // clearBttn
            // 
            this.clearBttn.Location = new System.Drawing.Point(241, 3);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(115, 37);
            this.clearBttn.TabIndex = 1;
            this.clearBttn.Text = "CLEAR";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(3, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(88, 16);
            this.patientNameLabel.TabIndex = 2;
            this.patientNameLabel.Text = "Patient Name";
            this.patientNameLabel.Click += new System.EventHandler(this.patientNameLabel_Click);
            // 
            // patientAgeLabel
            // 
            this.patientAgeLabel.AutoSize = true;
            this.patientAgeLabel.Location = new System.Drawing.Point(3, 105);
            this.patientAgeLabel.Name = "patientAgeLabel";
            this.patientAgeLabel.Size = new System.Drawing.Size(76, 16);
            this.patientAgeLabel.TabIndex = 3;
            this.patientAgeLabel.Text = "Patient Age";
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(3, 210);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(114, 16);
            this.appointmentDateLabel.TabIndex = 4;
            this.appointmentDateLabel.Text = "Appointment Date";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Location = new System.Drawing.Point(3, 315);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(103, 16);
            this.contactNumberLabel.TabIndex = 5;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(3, 420);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(52, 16);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Gender";
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Location = new System.Drawing.Point(3, 525);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(87, 16);
            this.doctorNameLabel.TabIndex = 7;
            this.doctorNameLabel.Text = "Doctor Name";
            this.doctorNameLabel.Click += new System.EventHandler(this.doctorNameLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Patient Registration Form";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(134, 3);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(359, 22);
            this.patientNameTextBox.TabIndex = 10;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(134, 528);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(359, 22);
            this.doctorNameTextBox.TabIndex = 12;
            this.doctorNameTextBox.TextChanged += new System.EventHandler(this.doctorNameTextBox_TextChanged);
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(134, 318);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(359, 22);
            this.contactNumberTextBox.TabIndex = 13;
            // 
            // patientAgeTextBox
            // 
            this.patientAgeTextBox.Location = new System.Drawing.Point(134, 108);
            this.patientAgeTextBox.Name = "patientAgeTextBox";
            this.patientAgeTextBox.Size = new System.Drawing.Size(359, 22);
            this.patientAgeTextBox.TabIndex = 14;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(134, 213);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(359, 22);
            this.appointmentDateTimePicker.TabIndex = 15;
            // 
            // maleRadioBttn
            // 
            this.maleRadioBttn.AutoSize = true;
            this.maleRadioBttn.Location = new System.Drawing.Point(3, 3);
            this.maleRadioBttn.Name = "maleRadioBttn";
            this.maleRadioBttn.Size = new System.Drawing.Size(58, 20);
            this.maleRadioBttn.TabIndex = 16;
            this.maleRadioBttn.TabStop = true;
            this.maleRadioBttn.Text = "Male";
            this.maleRadioBttn.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBttn
            // 
            this.femaleRadioBttn.AutoSize = true;
            this.femaleRadioBttn.Location = new System.Drawing.Point(182, 3);
            this.femaleRadioBttn.Name = "femaleRadioBttn";
            this.femaleRadioBttn.Size = new System.Drawing.Size(74, 20);
            this.femaleRadioBttn.TabIndex = 17;
            this.femaleRadioBttn.TabStop = true;
            this.femaleRadioBttn.Text = "Female";
            this.femaleRadioBttn.UseVisualStyleBackColor = true;
            // 
            // patientRecordDataGridView
            // 
            this.patientRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRecordDataGridView.Location = new System.Drawing.Point(555, 72);
            this.patientRecordDataGridView.Name = "patientRecordDataGridView";
            this.patientRecordDataGridView.RowHeadersWidth = 51;
            this.patientRecordDataGridView.RowTemplate.Height = 24;
            this.patientRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientRecordDataGridView.Size = new System.Drawing.Size(1000, 693);
            this.patientRecordDataGridView.TabIndex = 18;
            this.patientRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientRecordDataGridView_CellClick);
            this.patientRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientRecordDataGridView_CellContentClick);
            // 
            // updateBttn
            // 
            this.updateBttn.Location = new System.Drawing.Point(3, 3);
            this.updateBttn.Name = "updateBttn";
            this.updateBttn.Size = new System.Drawing.Size(104, 37);
            this.updateBttn.TabIndex = 19;
            this.updateBttn.Text = "UPDATE";
            this.updateBttn.UseVisualStyleBackColor = true;
            this.updateBttn.Click += new System.EventHandler(this.updateBttn_Click);
            // 
            // deleteBttn
            // 
            this.deleteBttn.Location = new System.Drawing.Point(122, 3);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.Size = new System.Drawing.Size(113, 37);
            this.deleteBttn.TabIndex = 20;
            this.deleteBttn.Text = "DELETE";
            this.deleteBttn.UseVisualStyleBackColor = true;
            this.deleteBttn.Click += new System.EventHandler(this.deleteBttn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.73737F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.patientAgeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientAgeTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.doctorNameTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.appointmentDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.appointmentDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.doctorNameLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.contactNumberLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.contactNumberTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.genderLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.patientNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientNameTextBox, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.814588F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 693);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.clearBttn, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.updateBttn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.deleteBttn, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(134, 633);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(359, 57);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.registerBttn, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 633);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(124, 57);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.maleRadioBttn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.femaleRadioBttn, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(134, 423);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(359, 57);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(867, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Patient Details\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UCpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.patientRecordDataGridView);
            this.Name = "UCpatient";
            this.Size = new System.Drawing.Size(1660, 836);
            this.Load += new System.EventHandler(this.UCpatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBttn;
        private System.Windows.Forms.Button clearBttn;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientAgeLabel;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox patientAgeTextBox;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.RadioButton maleRadioBttn;
        private System.Windows.Forms.RadioButton femaleRadioBttn;
        private System.Windows.Forms.DataGridView patientRecordDataGridView;
        private System.Windows.Forms.Button updateBttn;
        private System.Windows.Forms.Button deleteBttn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
    }
}
