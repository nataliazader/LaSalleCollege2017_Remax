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
        DataSetRemax dataSetRemax = new DataSetRemax();
        public frmManage()
        {
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {            
            if (frmLogin.empList==null)
                User();
            if (frmRemax.formToManage == "house")
            {
                DataSetRemaxTableAdapters.ViewHousesTableAdapter adapterViewHouses = new DataSetRemaxTableAdapters.ViewHousesTableAdapter();
                adapterViewHouses.Fill(dataSetRemax.ViewHouses);
                dgvResult.DataSource = dataSetRemax.ViewHouses;
            }
            else if (frmRemax.formToManage == "client")
            {
                DataSetRemaxTableAdapters.ViewClientsTableAdapter adapterViewClients = new DataSetRemaxTableAdapters.ViewClientsTableAdapter();
                adapterViewClients.Fill(dataSetRemax.ViewClients);
                if (frmLogin.agent != null)
                {
                    DataView dataViewAgent = new DataView(dataSetRemax.ViewClients);
                    dataViewAgent.RowFilter = "Agent = '"+ frmLogin.agent.Name+"'";
                    dgvResult.DataSource = dataViewAgent;
                }
                else
                   dgvResult.DataSource = dataSetRemax.ViewClients;
            }
            else if (frmRemax.formToManage == "employee")
            {

            }
            else if (frmRemax.formToManage == "sale")
            {

            }
            else if (frmRemax.formToManage == "agent")
            {

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
    }
}
