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
            this.SuspendLayout();
            // 
            // registerBttn
            // 
            this.registerBttn.Location = new System.Drawing.Point(82, 385);
            this.registerBttn.Name = "registerBttn";
            this.registerBttn.Size = new System.Drawing.Size(100, 23);
            this.registerBttn.TabIndex = 0;
            this.registerBttn.Text = "REGISTER";
            this.registerBttn.UseVisualStyleBackColor = true;
            // 
            // clearBttn
            // 
            this.clearBttn.Location = new System.Drawing.Point(231, 385);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(94, 23);
            this.clearBttn.TabIndex = 1;
            this.clearBttn.Text = "CLEAR";
            this.clearBttn.UseVisualStyleBackColor = true;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(39, 83);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(88, 16);
            this.patientNameLabel.TabIndex = 2;
            this.patientNameLabel.Text = "Patient Name";
            // 
            // patientAgeLabel
            // 
            this.patientAgeLabel.AutoSize = true;
            this.patientAgeLabel.Location = new System.Drawing.Point(39, 134);
            this.patientAgeLabel.Name = "patientAgeLabel";
            this.patientAgeLabel.Size = new System.Drawing.Size(76, 16);
            this.patientAgeLabel.TabIndex = 3;
            this.patientAgeLabel.Text = "Patient Age";
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(39, 181);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(114, 16);
            this.appointmentDateLabel.TabIndex = 4;
            this.appointmentDateLabel.Text = "Appointment Date";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Location = new System.Drawing.Point(39, 227);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(103, 16);
            this.contactNumberLabel.TabIndex = 5;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(39, 277);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(52, 16);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Gender";
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Location = new System.Drawing.Point(40, 323);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(87, 16);
            this.doctorNameLabel.TabIndex = 7;
            this.doctorNameLabel.Text = "Doctor Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Patient Registration Form";
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(209, 83);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.patientNameTextBox.TabIndex = 10;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(209, 323);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.doctorNameTextBox.TabIndex = 12;
            this.doctorNameTextBox.TextChanged += new System.EventHandler(this.doctorNameTextBox_TextChanged);
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(209, 221);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(200, 22);
            this.contactNumberTextBox.TabIndex = 13;
            // 
            // patientAgeTextBox
            // 
            this.patientAgeTextBox.Location = new System.Drawing.Point(209, 134);
            this.patientAgeTextBox.Name = "patientAgeTextBox";
            this.patientAgeTextBox.Size = new System.Drawing.Size(200, 22);
            this.patientAgeTextBox.TabIndex = 14;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(209, 181);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.appointmentDateTimePicker.TabIndex = 15;
            // 
            // maleRadioBttn
            // 
            this.maleRadioBttn.AutoSize = true;
            this.maleRadioBttn.Location = new System.Drawing.Point(209, 275);
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
            this.femaleRadioBttn.Location = new System.Drawing.Point(329, 275);
            this.femaleRadioBttn.Name = "femaleRadioBttn";
            this.femaleRadioBttn.Size = new System.Drawing.Size(74, 20);
            this.femaleRadioBttn.TabIndex = 17;
            this.femaleRadioBttn.TabStop = true;
            this.femaleRadioBttn.Text = "Female";
            this.femaleRadioBttn.UseVisualStyleBackColor = true;
            // 
            // UCpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.femaleRadioBttn);
            this.Controls.Add(this.maleRadioBttn);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.patientAgeTextBox);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.contactNumberLabel);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.patientAgeLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.registerBttn);
            this.Name = "UCpatient";
            this.Size = new System.Drawing.Size(1541, 945);
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
    }
}
