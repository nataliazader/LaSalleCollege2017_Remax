using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryRemax;
using WinFormWebApp_Remax_Zader.DATASOURCE;

namespace WinFormWebApp_Remax_Zader.GUI
{
    public partial class frmLogin : Form
    {
        Employee employee = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (email == "")
                labelEmailErr.Text = "*Required email";
            if (password == "")
                labelPasswordErr.Text = "*Required password";
            else
            {
                employee = EmployeeDB.getEmployee(email, password);
                if (employee != null)
                {
                    MessageBox.Show(employee.Id);
                    if (employee.Role == "user")
                    {
                        MenuRemax(true,false);
                    }
                    else if (employee.Role == "admin")
                    {
                        MenuRemax(true, true);
                    }
                    else if (employee.Role == "agent")
                    {
                        MenuRemax(true, true);
                    }
                    frmRemax.frmLoginOpen = false;
                    this.Close();
                }
                else
                {
                   labelLoginErr.Text="*Ivalid email or password.";

                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            labelEmailErr.Text = "";
            labelLoginErr.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            labelPasswordErr.Text = "";
            labelLoginErr.Text = "";
        }

        private void MenuRemax(bool enabled, bool visible) {
            ((frmRemax)this.MdiParent).applicationToolStripMenuItem.Enabled = ((frmRemax)this.MdiParent).managementToolStripMenuItem.Enabled = enabled;
            ((frmRemax)this.MdiParent).employeesToolStripMenuItem.Visible = ((frmRemax)this.MdiParent).salesToolStripMenuItem.Visible = visible;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MenuRemax(false,false);
        }
    }
}
