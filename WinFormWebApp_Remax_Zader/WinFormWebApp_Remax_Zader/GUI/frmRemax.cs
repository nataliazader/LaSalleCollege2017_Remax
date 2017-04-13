using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWebApp_Remax_Zader.GUI
{
    public partial class frmRemax : Form
    {
        public static string formToManage = "";
        public frmRemax()
        {
            InitializeComponent();
        }

        private void frmRemax_Load(object sender, EventArgs e)
        {
            frmLogin frmL = new frmLogin();
            frmL.MdiParent = this;
            frmL.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((int)dr == 6)
                this.Close();
        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmL = new frmLogin();
            frmL.MdiParent = this;
            frmL.Show();
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToManage = "house";
            OpenManageForm();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToManage = "client";
            OpenManageForm();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToManage = "employee";
            OpenManageForm();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToManage = "sale";
            OpenManageForm();
        }

        private void OpenManageForm()
        {
            frmManage frmM = new frmManage();
            frmM.MdiParent = this;
            frmM.Show();
        }
    }
}
