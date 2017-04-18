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
    public partial class frmManage : Form
    {
        public static string mode="";
        public static House house = null;
        //Employee employee = null;
        public static Client client =null;
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            if (frmLogin.employee == null)
            {
                User();
                User user = new User();
            }
            if (frmRemax.formToManage == "house")
            {
                if (frmLogin.employee == null)
                    dgvResult.DataSource = Remax.ViewHouses("user");
                else
                    dgvResult.DataSource = Remax.ViewHouses();
            }
            else if (frmRemax.formToManage == "client")
            {
                if (frmLogin.agent != null)
                {
                    dgvResult.DataSource = Remax.ViewClients(frmLogin.agent.Name);
                }
                else
                   dgvResult.DataSource = Remax.ViewClients();
            }
            else if (frmRemax.formToManage == "employee")
            {
                dgvResult.DataSource = Remax.ViewEmployees();
            }
            else if (frmRemax.formToManage == "agent")
            {
                dgvResult.DataSource = Remax.TabAgents();
            }
        }

        private void User()
        {
            btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            if (frmRemax.formToManage == "house")
            {
                frmHouse frmH = new frmHouse();
                frmH.ShowDialog();
            }
            else if (frmRemax.formToManage == "client")
            {
                frmClient frmC = new frmClient();
                frmC.ShowDialog();
            }
            else if (frmRemax.formToManage == "employee")
            {
                frmEmployee frmE = new frmEmployee();
                frmE.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            string id = dgvResult.Rows[dgvResult.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (frmRemax.formToManage == "house")
            {
                house = HouseDB.getHouse(id);
                frmHouse frmH = new frmHouse();
                frmH.ShowDialog();
            }
            else if (frmRemax.formToManage == "client")
            {
                client = ClientDB.getClient(id);
                frmClient frmC = new frmClient();
                frmC.ShowDialog();
            }
            else if (frmRemax.formToManage == "employee")
            {
                frmEmployee frmE = new frmEmployee();
                frmE.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvResult.Rows[dgvResult.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (frmRemax.formToManage == "house")
            {

            }
            else if (frmRemax.formToManage == "client")
            {

            }
            else if (frmRemax.formToManage == "employee")
            {

            }
        }
    }
}
