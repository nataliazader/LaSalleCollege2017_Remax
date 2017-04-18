using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormWebApp_Remax_Zader.DATASOURCE;
using ClassLibraryRemax;

namespace WinFormWebApp_Remax_Zader.GUI
{
    public partial class frmClient : Form
    {
        Client client = new Client();
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnCCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            client = frmManage.client;
            cboAgent.DataSource = Remax.TabAgents();
            cboAgent.DisplayMember = "Name";
            cboAgent.ValueMember = "Id";

            if (frmManage.mode == "edit")
            {
                txtCName.Text = client.Name;
                txtCPhone.Text = client.Phone;
                txtCEmail.Text = client.Email;
                txtCComment.Text = client.Comment;
                cboRole.Text = client.Role;
                foreach (DataRow row in Remax.TabAgents())
                    if (row["Id"].ToString() == client.IdAgent)
                        cboAgent.Text = row["Name"].ToString();
            }
        }
    }
}
