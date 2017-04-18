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
    public partial class frmHouse : Form
    {
        House house = null;
        public frmHouse()
        {
            InitializeComponent();
        }

        private void btnHCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHouse_Load(object sender, EventArgs e)
        {
            txtHName.Focus();

            cboHClient.DataSource = Remax.ViewClients();
            cboHClient.DisplayMember = "Name";
            cboHClient.ValueMember = "Id";

            cboHAgent.DataSource = Remax.ViewEmployees();
            cboHAgent.DisplayMember = "Name";
            cboHAgent.ValueMember = "Id";


            cboHBuilding.DataSource = Remax.TabBuilding();
            cboHBuilding.ValueMember = "refBuildingType";
            cboHBuilding.DisplayMember = "BuildingType";

            cboHProperty.DataSource = Remax.TabProperty();
            cboHProperty.ValueMember = "refPropertyType";
            cboHProperty.DisplayMember = "propertyType";


            cboHParking.DataSource = Remax.TabParking();
            cboHParking.DisplayMember = "NumParking";
            cboHParking.ValueMember = "refNumParking";

            cboHBedrooms.DataSource = Remax.TabBedrooms();
            cboHBedrooms.DisplayMember = "NumBedrooms";
            cboHBedrooms.ValueMember = "refNumBedrooms";
            if (frmManage.mode == "add")
            {

            }
            if (frmManage.mode == "edit")
            {
                house = frmManage.house;
                txtHName.Text = house.Name;
                txtHPrice.Text = house.Price.ToString();
                txtHNetArea.Text = house.NetArea.ToString();
                txtYear.Text = house.YearBuilt.ToString();

                foreach (DataRow row in Remax.ViewEmployees())
                    if (row["Id"].ToString() == house.IdAgent)
                        cboHAgent.Text = row["Name"].ToString();

                foreach (DataRow row in Remax.ViewClients())
                    if (row["Id"].ToString() == house.IdSeller)
                        cboHAgent.Text = row["Name"].ToString();
                foreach (DataRow row in Remax.TabBuilding())
                    if (row["refBuildingType"].ToString() == house.BuildingType)
                        cboHBuilding.Text = row["BuildingType"].ToString();
                foreach (DataRow row in Remax.TabProperty())
                    if (row["refPropertyType"].ToString() == house.BuildingType)
                        cboHBuilding.Text = row["PropertyType"].ToString();
                foreach (DataRow row in Remax.TabParking())
                    if (row["refNumParking"].ToString() == house.BuildingType)
                        cboHBuilding.Text = row["NumParking"].ToString();
                foreach (DataRow row in Remax.TabBedrooms())
                    if (row["refNumBedrooms"].ToString() == house.BuildingType)
                        cboHBuilding.Text = row["NumBedrooms"].ToString();
                txtHDesc.Text = house.Description;
                txtHAddress.Text = house.Address;
            }
        }
    }
}
