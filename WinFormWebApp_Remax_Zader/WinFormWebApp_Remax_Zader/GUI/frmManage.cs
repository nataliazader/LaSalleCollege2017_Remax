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
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            if (frmLogin.employee.Role == "user")
                User();
            if (frmRemax.formToManage == "house")
            { }
            else if (frmRemax.formToManage == "client")
            { }
            else if (frmRemax.formToManage == "employee")
            { }
            else if (frmRemax.formToManage == "sale")
            { }
        }

        private void User()
        {
            btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = false;
        }
    }
}
