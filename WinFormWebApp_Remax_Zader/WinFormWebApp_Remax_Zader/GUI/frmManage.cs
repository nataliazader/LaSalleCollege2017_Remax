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
        public static string mode;
        public static House house;
        public static Employee employee;
        public static Client client;
        public static Agent agent;
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            mode = "";
            house = null;
            employee = null;
            client = null;
            agent = null;

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
                if (frmLogin.agent != null)
                {
                    if (house.IdAgent != frmLogin.agent.Id)
                        MessageBox.Show("The house added by another agent.You can not edit.");
                    else
                    {
                        frmHouse frmH = new frmHouse();
                        frmH.ShowDialog();
                    }
                }
                else
                {
                    frmHouse frmH = new frmHouse();
                    frmH.ShowDialog();
                }

            }
            else if (frmRemax.formToManage == "client")
            {
                client = ClientDB.getClient(id);
                frmClient frmC = new frmClient();
                frmC.ShowDialog();
            }
            else if (frmRemax.formToManage == "employee")
            {
                agent = EmployeeDB.getAgent(id);
                frmEmployee frmE = new frmEmployee();
                frmE.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvResult.Rows[dgvResult.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DialogResult dr = new DialogResult();         
            dr=MessageBox.Show("Do you really want to delete a record, ID = " + id + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ((int)dr == 6) { 
                if (frmRemax.formToManage == "house")
                {
                    if (frmLogin.admin != null)
                    {
                        frmLogin.admin.Houses = Remax.TabHouses();
                        frmLogin.admin.DeleteHouse(id);
                        HouseDB.UpdateHousesDB(frmLogin.admin.Houses);
                    }
                  
                    if (frmLogin.agent != null)
                    {
                        house = HouseDB.getHouse(id);
                        if (house.IdAgent != frmLogin.agent.Id)
                            MessageBox.Show("The house added by another agent.You can not delete.");
                        else
                        {
                            frmLogin.agent.Houses = Remax.TabHouses();
                            frmLogin.agent.DeleteHouse(id);
                            HouseDB.UpdateHousesDB(frmLogin.agent.Houses);
                        }
                    }                      
                }
                else if (frmRemax.formToManage == "client")
                {
                    if (frmLogin.admin != null)
                    {
                        frmLogin.admin.Clients = Remax.TabClients();
                        frmLogin.admin.DeleteClient(id);
                        ClientDB.UpdateClientsDB(frmLogin.admin.Clients);
                    }
                    else
                    {
                        frmLogin.agent.Clients = Remax.TabClients();
                        frmLogin.agent.DeleteClient(id);
                        ClientDB.UpdateClientsDB(frmLogin.agent.Clients);
                    }
                }
                else if (frmRemax.formToManage == "employee")
                {
                    frmLogin.admin.Employees = Remax.TabEmployees();
                    frmLogin.admin.Languages = Remax.TabLanguages();
                    frmLogin.admin.DeleteEmployee(id);
                    EmployeeDB.UpdateEmployeesDB(frmLogin.admin.Employees,frmLogin.admin.Languages);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (frmRemax.formToManage == "house")
            {
                if (frmLogin.employee == null)
                    dgvResult.DataSource = Remax.ViewHouses("user");
                else
                    dgvResult.DataSource = Remax.ViewHouses();
            }
        }
    }
}
