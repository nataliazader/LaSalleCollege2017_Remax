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
            if (frmLogin.agent != null)
                cboAgent.Visible = lblCAgent.Visible = false;
            else {     
                cboAgent.DataSource = Remax.TabAgents();
                cboAgent.DisplayMember = "Name";
                cboAgent.ValueMember = "Id";
            }
            if (frmManage.mode == "edit")
            {
                client = frmManage.client;
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

        private void btnCSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (frmManage.mode == "edit")
                client.Id = frmManage.client.Id;
            client.Name = txtCName.Text;
            client.Phone = txtCPhone.Text;
            client.Email = txtCEmail.Text;
            client.Comment = txtCComment.Text;
            client.IdAgent = (frmLogin.agent != null) ? frmLogin.agent.Id : cboAgent.SelectedValue.ToString();
            client.Role = cboRole.Text;

            if (frmManage.mode == "add" && frmLogin.admin != null)
            {
                frmLogin.admin.Clients = Remax.TabClients();
                frmLogin.admin.AddClient(client);
                ClientDB.UpdateClientsDB(frmLogin.admin.Clients);
            }

            if (frmManage.mode == "add" && frmLogin.agent != null)
            {
                frmLogin.agent.Clients = Remax.TabClients();
                frmLogin.agent.AddClient(client);
                ClientDB.UpdateClientsDB(frmLogin.agent.Clients);
            }

            if (frmManage.mode == "edit" && frmLogin.admin != null)
            {
                client.Id = frmManage.client.Id;
                frmLogin.admin.Clients = Remax.TabClients();
                frmLogin.admin.EditClient(client);
                ClientDB.UpdateClientsDB(frmLogin.admin.Clients);
            }

            if (frmManage.mode == "edit" && frmLogin.agent != null)
            {
                client.Id = frmManage.client.Id;
                frmLogin.agent.Clients = Remax.TabClients();
                frmLogin.agent.EditClient(client);
                ClientDB.UpdateClientsDB(frmLogin.agent.Clients);
            }


        }
    }
}
