namespace WinFormWebApp_Remax_Zader.GUI
{
    partial class frmClient
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
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.txtCComment = new System.Windows.Forms.RichTextBox();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.lblCComments = new System.Windows.Forms.Label();
            this.lblCAgent = new System.Windows.Forms.Label();
            this.lblCRole = new System.Windows.Forms.Label();
            this.btnCSave = new System.Windows.Forms.Button();
            this.btnCCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(85, 25);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(140, 21);
            this.txtCName.TabIndex = 0;
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(85, 55);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(140, 21);
            this.txtCPhone.TabIndex = 1;
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(85, 85);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(140, 21);
            this.txtCEmail.TabIndex = 2;
            // 
            // txtCComment
            // 
            this.txtCComment.Location = new System.Drawing.Point(260, 55);
            this.txtCComment.Name = "txtCComment";
            this.txtCComment.Size = new System.Drawing.Size(144, 100);
            this.txtCComment.TabIndex = 3;
            this.txtCComment.Text = "";
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(85, 115);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(140, 21);
            this.cboAgent.TabIndex = 4;
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Seller",
            "Buyer"});
            this.cboRole.Location = new System.Drawing.Point(85, 145);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(140, 21);
            this.cboRole.TabIndex = 5;
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(15, 25);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(40, 13);
            this.lblCName.TabIndex = 6;
            this.lblCName.Text = "Name";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(15, 55);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(42, 13);
            this.lblCPhone.TabIndex = 7;
            this.lblCPhone.Text = "Phone";
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.Location = new System.Drawing.Point(15, 85);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(38, 13);
            this.lblCEmail.TabIndex = 8;
            this.lblCEmail.Text = "Email";
            // 
            // lblCComments
            // 
            this.lblCComments.AutoSize = true;
            this.lblCComments.Location = new System.Drawing.Point(260, 25);
            this.lblCComments.Name = "lblCComments";
            this.lblCComments.Size = new System.Drawing.Size(69, 13);
            this.lblCComments.TabIndex = 9;
            this.lblCComments.Text = "Comments";
            // 
            // lblCAgent
            // 
            this.lblCAgent.AutoSize = true;
            this.lblCAgent.Location = new System.Drawing.Point(15, 115);
            this.lblCAgent.Name = "lblCAgent";
            this.lblCAgent.Size = new System.Drawing.Size(40, 13);
            this.lblCAgent.TabIndex = 10;
            this.lblCAgent.Text = "Agent";
            // 
            // lblCRole
            // 
            this.lblCRole.AutoSize = true;
            this.lblCRole.Location = new System.Drawing.Point(15, 140);
            this.lblCRole.Name = "lblCRole";
            this.lblCRole.Size = new System.Drawing.Size(34, 13);
            this.lblCRole.TabIndex = 11;
            this.lblCRole.Text = "Type";
            // 
            // btnCSave
            // 
            this.btnCSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSave.Location = new System.Drawing.Point(15, 185);
            this.btnCSave.Name = "btnCSave";
            this.btnCSave.Size = new System.Drawing.Size(75, 23);
            this.btnCSave.TabIndex = 12;
            this.btnCSave.Text = "SAVE";
            this.btnCSave.UseVisualStyleBackColor = true;
            this.btnCSave.Click += new System.EventHandler(this.btnCSave_Click);
            // 
            // btnCCancel
            // 
            this.btnCCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCancel.Location = new System.Drawing.Point(320, 185);
            this.btnCCancel.Name = "btnCCancel";
            this.btnCCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCCancel.TabIndex = 13;
            this.btnCCancel.Text = "CANCEL";
            this.btnCCancel.UseVisualStyleBackColor = true;
            this.btnCCancel.Click += new System.EventHandler(this.btnCCancel_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 224);
            this.ControlBox = false;
            this.Controls.Add(this.btnCCancel);
            this.Controls.Add(this.btnCSave);
            this.Controls.Add(this.lblCRole);
            this.Controls.Add(this.lblCAgent);
            this.Controls.Add(this.lblCComments);
            this.Controls.Add(this.lblCEmail);
            this.Controls.Add(this.lblCPhone);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.cboAgent);
            this.Controls.Add(this.txtCComment);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtCName);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.RichTextBox txtCComment;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.Label lblCComments;
        private System.Windows.Forms.Label lblCAgent;
        private System.Windows.Forms.Label lblCRole;
        private System.Windows.Forms.Button btnCSave;
        private System.Windows.Forms.Button btnCCancel;
    }
}