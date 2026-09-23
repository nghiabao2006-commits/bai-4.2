namespace bai_4._2
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.chkNewsletter = new System.Windows.Forms.CheckBox();
            this.chkMaterials = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 55);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(97, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone number:";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(198, 52);
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(220, 22);
            this.mtxtPhone.TabIndex = 3;
            this.mtxtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPhone_MaskInputRejected);
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(24, 90);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(62, 16);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "Birth day:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(198, 85);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(220, 22);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(24, 125);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 16);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course:";
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.Location = new System.Drawing.Point(198, 117);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(220, 24);
            this.cboCourse.TabIndex = 7;
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rdoMale);
            this.groupGender.Controls.Add(this.rdoFemale);
            this.groupGender.Location = new System.Drawing.Point(27, 160);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(313, 55);
            this.groupGender.TabIndex = 8;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(18, 22);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(100, 22);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // chkNewsletter
            // 
            this.chkNewsletter.AutoSize = true;
            this.chkNewsletter.Location = new System.Drawing.Point(27, 230);
            this.chkNewsletter.Name = "chkNewsletter";
            this.chkNewsletter.Size = new System.Drawing.Size(143, 20);
            this.chkNewsletter.TabIndex = 9;
            this.chkNewsletter.Text = "Receive newsletter";
            this.chkNewsletter.UseVisualStyleBackColor = true;
            // 
            // chkMaterials
            // 
            this.chkMaterials.AutoSize = true;
            this.chkMaterials.Location = new System.Drawing.Point(198, 230);
            this.chkMaterials.Name = "chkMaterials";
            this.chkMaterials.Size = new System.Drawing.Size(121, 20);
            this.chkMaterials.TabIndex = 10;
            this.chkMaterials.Text = "Need materials";
            this.chkMaterials.UseVisualStyleBackColor = true;
            this.chkMaterials.CheckedChanged += new System.EventHandler(this.chkMaterials_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(120, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 30);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Sign up";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 417);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.chkNewsletter);
            this.Controls.Add(this.chkMaterials);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Đăng ký học viên";
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.CheckBox chkNewsletter;
        private System.Windows.Forms.CheckBox chkMaterials;
        private System.Windows.Forms.Button btnRegister;

        #endregion
    }
}

