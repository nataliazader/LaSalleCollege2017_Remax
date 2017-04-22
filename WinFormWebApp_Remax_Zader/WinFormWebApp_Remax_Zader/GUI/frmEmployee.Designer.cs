namespace WinFormWebApp_Remax_Zader.GUI
{
    partial class frmEmployee
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
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtEPhone = new System.Windows.Forms.TextBox();
            this.txtEEmail = new System.Windows.Forms.TextBox();
            this.radEFemale = new System.Windows.Forms.RadioButton();
            this.radEMale = new System.Windows.Forms.RadioButton();
            this.txtEPassword = new System.Windows.Forms.TextBox();
            this.cboERole = new System.Windows.Forms.ComboBox();
            this.lblEName = new System.Windows.Forms.Label();
            this.lblEPhone = new System.Windows.Forms.Label();
            this.lblEEmail = new System.Windows.Forms.Label();
            this.lblEGender = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnESave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboLanguages = new System.Windows.Forms.ComboBox();
            this.lboLanguages = new System.Windows.Forms.ListBox();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEAddress = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(95, 25);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(140, 21);
            this.txtEName.TabIndex = 0;
            // 
            // txtEPhone
            // 
            this.txtEPhone.Location = new System.Drawing.Point(95, 55);
            this.txtEPhone.Name = "txtEPhone";
            this.txtEPhone.Size = new System.Drawing.Size(140, 21);
            this.txtEPhone.TabIndex = 1;
            // 
            // txtEEmail
            // 
            this.txtEEmail.Location = new System.Drawing.Point(95, 85);
            this.txtEEmail.Name = "txtEEmail";
            this.txtEEmail.Size = new System.Drawing.Size(140, 21);
            this.txtEEmail.TabIndex = 2;
            // 
            // radEFemale
            // 
            this.radEFemale.AutoSize = true;
            this.radEFemale.Location = new System.Drawing.Point(95, 271);
            this.radEFemale.Name = "radEFemale";
            this.radEFemale.Size = new System.Drawing.Size(66, 17);
            this.radEFemale.TabIndex = 3;
            this.radEFemale.Text = "Female";
            this.radEFemale.UseVisualStyleBackColor = true;
            // 
            // radEMale
            // 
            this.radEMale.AutoSize = true;
            this.radEMale.Location = new System.Drawing.Point(95, 248);
            this.radEMale.Name = "radEMale";
            this.radEMale.Size = new System.Drawing.Size(51, 17);
            this.radEMale.TabIndex = 4;
            this.radEMale.Text = "Male";
            this.radEMale.UseVisualStyleBackColor = true;
            // 
            // txtEPassword
            // 
            this.txtEPassword.Location = new System.Drawing.Point(95, 141);
            this.txtEPassword.Name = "txtEPassword";
            this.txtEPassword.Size = new System.Drawing.Size(140, 21);
            this.txtEPassword.TabIndex = 5;
            // 
            // cboERole
            // 
            this.cboERole.FormattingEnabled = true;
            this.cboERole.Location = new System.Drawing.Point(95, 114);
            this.cboERole.Name = "cboERole";
            this.cboERole.Size = new System.Drawing.Size(140, 21);
            this.cboERole.TabIndex = 7;
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Location = new System.Drawing.Point(15, 25);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(40, 13);
            this.lblEName.TabIndex = 8;
            this.lblEName.Text = "Name";
            // 
            // lblEPhone
            // 
            this.lblEPhone.AutoSize = true;
            this.lblEPhone.Location = new System.Drawing.Point(15, 55);
            this.lblEPhone.Name = "lblEPhone";
            this.lblEPhone.Size = new System.Drawing.Size(42, 13);
            this.lblEPhone.TabIndex = 9;
            this.lblEPhone.Text = "Phone";
            // 
            // lblEEmail
            // 
            this.lblEEmail.AutoSize = true;
            this.lblEEmail.Location = new System.Drawing.Point(15, 85);
            this.lblEEmail.Name = "lblEEmail";
            this.lblEEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEEmail.TabIndex = 10;
            this.lblEEmail.Text = "Email";
            // 
            // lblEGender
            // 
            this.lblEGender.AutoSize = true;
            this.lblEGender.Location = new System.Drawing.Point(15, 252);
            this.lblEGender.Name = "lblEGender";
            this.lblEGender.Size = new System.Drawing.Size(49, 13);
            this.lblEGender.TabIndex = 11;
            this.lblEGender.Text = "Gender";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblEAddress
            // 
            this.lblEAddress.AutoSize = true;
            this.lblEAddress.Location = new System.Drawing.Point(15, 176);
            this.lblEAddress.Name = "lblEAddress";
            this.lblEAddress.Size = new System.Drawing.Size(53, 13);
            this.lblEAddress.TabIndex = 13;
            this.lblEAddress.Text = "Address";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(15, 112);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(34, 13);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Type";
            // 
            // btnESave
            // 
            this.btnESave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESave.Location = new System.Drawing.Point(12, 311);
            this.btnESave.Name = "btnESave";
            this.btnESave.Size = new System.Drawing.Size(87, 23);
            this.btnESave.TabIndex = 15;
            this.btnESave.Text = "SAVE";
            this.btnESave.UseVisualStyleBackColor = true;
            this.btnESave.Click += new System.EventHandler(this.btnESave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(330, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboLanguages
            // 
            this.cboLanguages.FormattingEnabled = true;
            this.cboLanguages.Location = new System.Drawing.Point(270, 45);
            this.cboLanguages.Name = "cboLanguages";
            this.cboLanguages.Size = new System.Drawing.Size(140, 21);
            this.cboLanguages.TabIndex = 17;
            // 
            // lboLanguages
            // 
            this.lboLanguages.FormattingEnabled = true;
            this.lboLanguages.Location = new System.Drawing.Point(270, 103);
            this.lboLanguages.Name = "lboLanguages";
            this.lboLanguages.Size = new System.Drawing.Size(140, 108);
            this.lboLanguages.TabIndex = 18;
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Location = new System.Drawing.Point(267, 25);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(68, 13);
            this.lblLanguages.TabIndex = 19;
            this.lblLanguages.Text = "Languages";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(270, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // txtEAddress
            // 
            this.txtEAddress.Location = new System.Drawing.Point(95, 173);
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.Size = new System.Drawing.Size(140, 69);
            this.txtEAddress.TabIndex = 27;
            this.txtEAddress.Text = "";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 346);
            this.ControlBox = false;
            this.Controls.Add(this.txtEAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblLanguages);
            this.Controls.Add(this.lboLanguages);
            this.Controls.Add(this.cboLanguages);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnESave);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblEAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEGender);
            this.Controls.Add(this.lblEEmail);
            this.Controls.Add(this.lblEPhone);
            this.Controls.Add(this.lblEName);
            this.Controls.Add(this.cboERole);
            this.Controls.Add(this.txtEPassword);
            this.Controls.Add(this.radEMale);
            this.Controls.Add(this.radEFemale);
            this.Controls.Add(this.txtEEmail);
            this.Controls.Add(this.txtEPhone);
            this.Controls.Add(this.txtEName);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtEPhone;
        private System.Windows.Forms.TextBox txtEEmail;
        private System.Windows.Forms.RadioButton radEFemale;
        private System.Windows.Forms.RadioButton radEMale;
        private System.Windows.Forms.TextBox txtEPassword;
        private System.Windows.Forms.ComboBox cboERole;
        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.Label lblEPhone;
        private System.Windows.Forms.Label lblEEmail;
        private System.Windows.Forms.Label lblEGender;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnESave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboLanguages;
        private System.Windows.Forms.ListBox lboLanguages;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtEAddress;
    }
}