using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WinFormWebApp_Remax_Zader.DATASOURCE
{
    public static class Remax
    {
        public static SqlConnection getConnection()
        {
            var connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\LaSalleCollege2017_Remax\\WinFormWebApp_Remax_Zader\\WinFormWebApp_Remax_Zader\\App_Data\\Remax.mdf; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static DataSetRemax.ViewHousesDataTable ViewHouses()
        {
            DataSetRemax.ViewHousesDataTable viewHouses = new DataSetRemax.ViewHousesDataTable();
            DataSetRemaxTableAdapters.ViewHousesTableAdapter adapterViewHouses = new DataSetRemaxTableAdapters.ViewHousesTableAdapter();
            adapterViewHouses.Fill(viewHouses);
            return viewHouses;
        }

        public static DataSetRemax.ViewHousesDataTable ViewHouses(string user)
        {
            DataSetRemax.ViewHousesDataTable viewHouses = new DataSetRemax.ViewHousesDataTable();
            DataSetRemaxTableAdapters.ViewHousesTableAdapter adapterViewHouses = new DataSetRemaxTableAdapters.ViewHousesTableAdapter();
            adapterViewHouses.Fill(viewHouses);
            viewHouses.Columns.Remove("Seller");
            return viewHouses;
        }

        public static DataSetRemax.ViewClientsDataTable ViewClients() {
            DataSetRemax.ViewClientsDataTable viewClients = new DataSetRemax.ViewClientsDataTable();
            DataSetRemaxTableAdapters.ViewClientsTableAdapter adpClient = new DataSetRemaxTableAdapters.ViewClientsTableAdapter();
            adpClient.Fill(viewClients);
            return viewClients;
        }

        public static DataView ViewClients(string name)
        {
            DataSetRemax.ViewClientsDataTable viewClients = new DataSetRemax.ViewClientsDataTable();
            DataSetRemaxTableAdapters.ViewClientsTableAdapter adpClient = new DataSetRemaxTableAdapters.ViewClientsTableAdapter();
            adpClient.Fill(viewClients);
            DataView dataViewClients =  new DataView(viewClients);
            dataViewClients.RowFilter = "Agent = '" + name + "'";
            return dataViewClients;
        }

        public static DataSetRemax.ViewEmployeesDataTable ViewEmployees()
        {
            DataSetRemax.ViewEmployeesDataTable viewEmp = new DataSetRemax.ViewEmployeesDataTable();
            DataSetRemaxTableAdapters.ViewEmployeesTableAdapter adpEmp = new DataSetRemaxTableAdapters.ViewEmployeesTableAdapter();
            adpEmp.Fill(viewEmp);
            return viewEmp;
        }

        public static DataSetRemax.BuildingTypeDataTable TabBuilding()
        {
            DataSetRemax.BuildingTypeDataTable tabBuilding = new DataSetRemax.BuildingTypeDataTable();
            DataSetRemaxTableAdapters.BuildingTypeTableAdapter adpB = new DataSetRemaxTableAdapters.BuildingTypeTableAdapter();
            adpB.Fill(tabBuilding);
            return tabBuilding;
        }

        public static DataSetRemax.PropertyTypeDataTable TabProperty()
        {
            DataSetRemax.PropertyTypeDataTable tabProperty = new DataSetRemax.PropertyTypeDataTable();
            DataSetRemaxTableAdapters.PropertyTypeTableAdapter adpP = new DataSetRemaxTableAdapters.PropertyTypeTableAdapter();
            adpP.Fill(tabProperty);
            return tabProperty;
        }

        public static DataSetRemax.NumParkingDataTable TabParking()
        {
            DataSetRemax.NumParkingDataTable tabParking = new DataSetRemax.NumParkingDataTable();
            DataSetRemaxTableAdapters.NumParkingTableAdapter adpPark = new DataSetRemaxTableAdapters.NumParkingTableAdapter();
            adpPark.Fill(tabParking);
            return tabParking;
        }

        public static DataSetRemax.NumBedroomsDataTable TabBedrooms()
        {
            DataSetRemax.NumBedroomsDataTable tabBedrooms = new DataSetRemax.NumBedroomsDataTable();
            DataSetRemaxTableAdapters.NumBedroomsTableAdapter adpBed = new DataSetRemaxTableAdapters.NumBedroomsTableAdapter();
            adpBed.Fill(tabBedrooms);
            return tabBedrooms;
        }

        public static DataSetRemax.ViewAgentsDataTable TabAgents()
        {
            DataSetRemax.ViewAgentsDataTable tabAgents = new DataSetRemax.ViewAgentsDataTable();
            DataSetRemaxTableAdapters.ViewAgentsTableAdapter adpAgt = new DataSetRemaxTableAdapters.ViewAgentsTableAdapter();
            adpAgt.Fill(tabAgents);
            tabAgents.Columns.Remove("Password");
            tabAgents.Columns.Remove("Image");
            tabAgents.Columns.Remove("Role");
            return tabAgents;
        }

        public static DataTable TabHouses()
        {
            DataSetRemax.HousesDataTable tabHouses = new DataSetRemax.HousesDataTable();
            DataSetRemaxTableAdapters.HousesTableAdapter adpHouses = new DataSetRemaxTableAdapters.HousesTableAdapter();
            adpHouses.Fill(tabHouses);
            return tabHouses;
        }

        public static DataTable TabClients()
        {
            DataSetRemax.ClientsDataTable tabClients = new DataSetRemax.ClientsDataTable();
            DataSetRemaxTableAdapters.ClientsTableAdapter adpClients = new DataSetRemaxTableAdapters.ClientsTableAdapter();
            adpClients.Fill(tabClients);
            return tabClients;
        }

        public static DataTable TabEmployees()
        {
            DataSetRemax.EmployeesDataTable tabEmployees = new DataSetRemax.EmployeesDataTable();
            DataSetRemaxTableAdapters.EmployeesTableAdapter adpEmployees = new DataSetRemaxTableAdapters.EmployeesTableAdapter();
            adpEmployees.Fill(tabEmployees);
            return tabEmployees;
        }

        public static DataTable TabLanguages()
        {
            DataSetRemax.AgentLanguagesDataTable tabLanguages = new DataSetRemax.AgentLanguagesDataTable();
            DataSetRemaxTableAdapters.AgentLanguagesTableAdapter adpLanguages = new DataSetRemaxTableAdapters.AgentLanguagesTableAdapter();
            adpLanguages.Fill(tabLanguages);
            return tabLanguages;
        }

    }
}
