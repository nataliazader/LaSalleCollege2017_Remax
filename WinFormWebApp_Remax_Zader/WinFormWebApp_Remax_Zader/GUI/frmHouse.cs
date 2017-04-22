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

            if (frmLogin.admin != null)
            {
                cboHAgent.DataSource = Remax.ViewEmployees();
                cboHAgent.DisplayMember = "Name";
                cboHAgent.ValueMember = "Id";
            }
            else {
                cboHAgent.Visible = false;
                lblHAgent.Visible = false;
            }



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

            if (frmManage.mode == "edit")
            {
                house = frmManage.house;
                txtHName.Text = house.Name;
                txtHPrice.Text = house.Price.ToString();
                txtHNetArea.Text = house.NetArea.ToString();
                txtYear.Text = house.YearBuilt.ToString();
                checkBoxElevator.Checked = house.Elevator;
                checkBoxMobility.Checked = house.AdapterMobility;
                checkBoxPool.Checked = house.Pool;
                checkBoxWater.Checked = house.Waterfront;

                foreach (DataRow row in Remax.ViewEmployees())
                    if (row["Id"].ToString() == house.IdAgent)
                        cboHAgent.Text = row["Name"].ToString();

                foreach (DataRow row in Remax.ViewClients())
                    if (row["Id"].ToString() == house.IdSeller)
                        cboHClient.Text = row["Name"].ToString();
                foreach (DataRow row in Remax.TabBuilding())
                    if (row["refBuildingType"].ToString() == house.BuildingType)
                        cboHBuilding.Text = row["BuildingType"].ToString();
                foreach (DataRow row in Remax.TabProperty())
                    if (row["refPropertyType"].ToString() == house.BuildingType)
                        cboHProperty.Text = row["PropertyType"].ToString();
                foreach (DataRow row in Remax.TabParking())
                    if (row["refNumParking"].ToString() == house.BuildingType)
                       cboHParking.Text = row["NumParking"].ToString();
                foreach (DataRow row in Remax.TabBedrooms())
                    if (row["refNumBedrooms"].ToString() == house.BuildingType)
                       cboHBedrooms.Text = row["NumBedrooms"].ToString();
                txtHDesc.Text = house.Description;
                txtHAddress.Text = house.Address;
            }
        }

        private void btnHSave_Click(object sender, EventArgs e)
        {
            House house = new House();
            house.BuildingType = cboHBuilding.SelectedValue.ToString();
            house.NumberParking = cboHParking.SelectedValue.ToString();
            house.NumberBedrooms = cboHBedrooms.SelectedValue.ToString();
            house.PropertyType = cboHProperty.SelectedValue.ToString();
            house.Price = float.Parse(txtHPrice.Text);
            house.IdAgent = (frmLogin.agent != null) ? frmLogin.agent.Id : cboHAgent.SelectedValue.ToString();
            house.IdSeller = cboHClient.SelectedValue.ToString();
            house.Pool = (checkBoxPool.Checked) ? true : false;
            house.Waterfront = (checkBoxWater.Checked) ? true : false;
            house.Elevator = (checkBoxElevator.Checked) ? true : false;
            house.AdapterMobility = (checkBoxMobility.Checked) ? true : false;
            house.NetArea = int.Parse(txtHNetArea.Text);
            house.YearBuilt = int.Parse(txtYear.Text);
            house.Description = txtHDesc.Text;
            house.Name = txtHName.Text;
            house.Address = txtHAddress.Text;

            if (frmManage.mode == "add" && frmLogin.admin!=null)
            {
                frmLogin.admin.Houses = Remax.TabHouses();
                frmLogin.admin.AddHouse(house);
                HouseDB.UpdateHousesDB(frmLogin.admin.Houses);
            }

            if (frmManage.mode == "add" && frmLogin.agent != null)
            {
                frmLogin.agent.Houses = Remax.TabHouses();
                frmLogin.agent.AddHouse(house);
                HouseDB.UpdateHousesDB(frmLogin.agent.Houses);
            }

            if (frmManage.mode == "edit" && frmLogin.admin != null)
            {
                house.Id = frmManage.house.Id;
                frmLogin.admin.Houses = Remax.TabHouses();
                frmLogin.admin.EditHouse(house);
                HouseDB.UpdateHousesDB(frmLogin.admin.Houses);
            }

            if (frmManage.mode == "edit" && frmLogin.agent != null)
            {
                house.Id = frmManage.house.Id;
                frmLogin.agent.Houses = Remax.TabHouses();
                frmLogin.agent.EditHouse(house);
                HouseDB.UpdateHousesDB(frmLogin.agent.Houses);
            }


            this.Close();
        }
    }
}
