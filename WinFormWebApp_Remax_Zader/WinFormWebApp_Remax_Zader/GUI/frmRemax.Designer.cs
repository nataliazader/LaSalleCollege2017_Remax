namespace WinFormWebApp_Remax_Zader.GUI
{
    partial class frmRemax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemax));
            this.menuStripRemax = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.housesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripRemax.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripRemax
            // 
            this.menuStripRemax.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStripRemax.Location = new System.Drawing.Point(0, 0);
            this.menuStripRemax.Name = "menuStripRemax";
            this.menuStripRemax.Size = new System.Drawing.Size(884, 24);
            this.menuStripRemax.TabIndex = 1;
            this.menuStripRemax.Text = "menuStripRemax";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Log &In";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Log &Out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.housesToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.agentsToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.managementToolStripMenuItem.Text = "Manage";
            // 
            // housesToolStripMenuItem
            // 
            this.housesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("housesToolStripMenuItem.Image")));
            this.housesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.housesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.housesToolStripMenuItem.Name = "housesToolStripMenuItem";
            this.housesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.housesToolStripMenuItem.Text = "&Houses";
            this.housesToolStripMenuItem.Click += new System.EventHandler(this.housesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsToolStripMenuItem.Image")));
            this.clientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientsToolStripMenuItem.Text = "&Clients";
            this.clientsToolStripMenuItem.Visible = false;
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesToolStripMenuItem.Image")));
            this.employeesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.employeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeesToolStripMenuItem.Text = "&Employees";
            this.employeesToolStripMenuItem.Visible = false;
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesToolStripMenuItem.Image")));
            this.salesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.salesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesToolStripMenuItem.Text = "&Sales";
            this.salesToolStripMenuItem.Visible = false;
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // agentsToolStripMenuItem
            // 
            this.agentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agentsToolStripMenuItem.Image")));
            this.agentsToolStripMenuItem.Name = "agentsToolStripMenuItem";
            this.agentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agentsToolStripMenuItem.Text = "Agents";
            this.agentsToolStripMenuItem.Click += new System.EventHandler(this.agentsToolStripMenuItem_Click);
            // 
            // frmRemax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.menuStripRemax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripRemax;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remax";
            this.Load += new System.EventHandler(this.frmRemax_Load);
            this.menuStripRemax.ResumeLayout(false);
            this.menuStripRemax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripRemax;
        public System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem housesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem agentsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

