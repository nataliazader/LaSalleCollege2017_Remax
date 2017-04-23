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
                if (frmLogin.admin != null)
                    dgvResult.DataSource = HouseDB.getViewHouses("admin");
                else
                    dgvResult.DataSource = HouseDB.getViewHouses("user or agent");
            }
            else if (frmRemax.formToManage == "client")
            {
                if (frmLogin.agent != null)
                {
                    dgvResult.DataSource = ClientDB.getViewClients(frmLogin.agent.Name);
                }
                else
                    dgvResult.DataSource = ClientDB.getViewClients("");
            }
            else if (frmRemax.formToManage == "employee")
            {
                dgvResult.DataSource = EmployeeDB.getViewEmployees("");
            }
            else if (frmRemax.formToManage == "agent")
            {
                dgvResult.DataSource = EmployeeDB.getViewEmployees("agent");
                dgvResult.Columns["Image"].Visible = false;
                dgvResult.Columns["Role"].Visible = false;
                dgvResult.Columns["Password"].Visible = false;
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
            checkBoxName.Checked=checkBoxID.Checked = false;
            txtSearch.Text = "";
            if (frmRemax.formToManage == "house")
            {
                if(frmLogin.admin!=null)
                    dgvResult.DataSource = HouseDB.getViewHouses("admin");
                else
                    dgvResult.DataSource = HouseDB.getViewHouses("user or agent");
            }

            if (frmRemax.formToManage == "client")
            {
                if (frmLogin.agent == null)
                    dgvResult.DataSource = ClientDB.getViewClients("");
                else
                {
                    dgvResult.DataSource = ClientDB.getViewClients(frmLogin.agent.Name);
                }
            }

            if (frmRemax.formToManage == "employee")
            {
                dgvResult.DataSource = EmployeeDB.getViewEmployees("");
            }
            if (frmRemax.formToManage == "agent")
            {
                dgvResult.DataSource = EmployeeDB.getViewEmployees("agent");
                dgvResult.Columns["Image"].Visible = false;
                dgvResult.Columns["Role"].Visible = false;
                dgvResult.Columns["Password"].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxID.Checked)
            {
                if (txtSearch.Text == "")
                    MessageBox.Show("Enter a criteria");
                else
                {
                    string criteria = txtSearch.Text;
                    if (frmRemax.formToManage == "house")
                    {
                        if (frmLogin.admin != null)
                        {
                            DataView dv = HouseDB.getViewHouses("admin");
                            dv.RowFilter = "CONVERT(Id, System.String) LIKE '%" + criteria+"%'";
                            dgvResult.DataSource=dv;
                        }                        
                        else
                        {
                            DataView dv = HouseDB.getViewHouses("user or agent");
                            dv.RowFilter = "CONVERT(Id, System.String) LIKE '%" + criteria + "%'";
                            dgvResult.DataSource = dv;
                        }
                    }
                    if (frmRemax.formToManage == "client")
                    {
                        if (frmLogin.agent == null)
                        {
                            DataView dv = ClientDB.getViewClients("");
                            dv.RowFilter = "CONVERT(Id, System.String) LIKE '%" + criteria + "%'";
                            dgvResult.DataSource = dv;
                        }
                        else
                        {
                            DataView dv = ClientDB.getViewClients(frmLogin.agent.Name);
                            dv.RowFilter = " CONVERT(Id, System.String) LIKE '%" + criteria + "%'";
                            dgvResult.DataSource = dv;
                        }
                    }
                    if (frmRemax.formToManage == "employee")
                    {
                        DataView dv = EmployeeDB.getViewEmployees("");
                        dv.RowFilter = "CONVERT(Id, System.String) LIKE '%" + criteria + "%'";
                        dgvResult.DataSource = dv;
                    }
                    if (frmRemax.formToManage == "agent")
                    {
                        DataView dv = EmployeeDB.getViewEmployees("agent");
                        dv.RowFilter = "CONVERT(Id, System.String) LIKE '%" + criteria + "%'";
                        dgvResult.DataSource = dv;
                    }
                }
            }
            if (checkBoxName.Checked)
            {
                if (txtSearch.Text == "")
                    MessageBox.Show("Enter a criteria");
                else
                {
                    string criteria = txtSearch.Text;
                    if (frmRemax.formToManage == "house")
                    {
                        if (frmLogin.employee == null)
                        {
                            DataTable dt = Remax.ViewHouses("user");
                            DataView dv = dt.DefaultView;
                            dv.RowFilter = "Name LIKE '%" + criteria + "%'";
                            dgvResult.DataSource = dv;
                        }
                        else
                        {
                            DataTable dt = Remax.ViewHouses();
                            DataView dv = dt.DefaultView;
                            dv.RowFilter = "Name LIKE '%" + criteria + "%'";
                            dgvResult.DataSource = dv;
                        }
                    }
                    if (frmRemax.formToManage == "client")
                    {
                        if (frmLogin.agent != null)
                        {
                            DataView dv = Remax.ViewClients(frmLogin.agent.Name);
                            dv.RowFilter = "Name LIKE '%" + criteria + "%'";
                            dgvResult.DataSource = dv;
                        }
                        else
                        {
                            DataTable dt = Remax.ViewClients();
                            DataView dv = dt.DefaultView;
                            dv.RowFilter = "Name LIKE '%" + criteria + "%'";
                            dgvResult.DataSource = dv;
                        }
                    }
                    if (frmRemax.formToManage == "employee")
                    {
                        DataTable dt = Remax.ViewEmployees();
                        DataView dv = dt.DefaultView;
                        dv.RowFilter = "Name LIKE '%" + criteria + "%'";
                        dgvResult.DataSource =dv;
                    }
                    if (frmRemax.formToManage == "agent")
                    {
                        DataTable dt = Remax.TabAgents();
                        DataView dv = dt.DefaultView;
                        dv.RowFilter= "Name LIKE '%" + criteria + "%'";
                        dgvResult.DataSource = dv;
                    }
                }
            }
           if(!checkBoxName.Checked && !checkBoxID.Checked) 
            {
                MessageBox.Show("Check type of search.");
            }
        }

    }
}
