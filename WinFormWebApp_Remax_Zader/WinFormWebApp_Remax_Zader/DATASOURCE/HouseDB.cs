using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRemax;
using System.Data.SqlClient;
using System.Data;

namespace WinFormWebApp_Remax_Zader.DATASOURCE
{
    public static class HouseDB
    {
        public static House getHouse(string id)
        {
            SqlConnection connection = Remax.getConnection();
            string selectStatement = " SELECT * FROM Houses WHERE refHouse = @refHouse";

            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@refHouse", id);
                SqlDataReader houseReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (houseReader.Read())
                {
                    House house = new House();
                    house.Id = houseReader["refHouse"].ToString();
                    house.BuildingType = houseReader["referBuildingType"].ToString();
                    house.NumberBedrooms = houseReader["referNumBedrooms"].ToString();
                    house.NumberParking= houseReader["referNumParking"].ToString();
                    house.PropertyType = houseReader["referPropertyType"].ToString();
                    house.Price = float.Parse(houseReader["price"].ToString());
                    house.IdAgent = houseReader["referEmployee"].ToString();
                    house.IdSeller = houseReader["referClient"].ToString();
                    house.Pool = (bool)houseReader["Pool"];
                    house.Waterfront = (bool)houseReader["Waterfront"];
                    house.Elevator = (bool)houseReader["Elevator"];
                    house.AdapterMobility = (bool)houseReader["Reduced mobility"];
                    house.NetArea = (int)houseReader["NetArea"];
                    house.YearBuilt= (int)houseReader["YearBuilt"];
                    house.Description = houseReader["Description"].ToString();
                    house.Name = houseReader["Name"].ToString();
                    house.Address = houseReader["Address"].ToString();
                    return house;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateHousesDB(DataTable newHouses)
        {
            SqlConnection connection = Remax.getConnection();           
            SqlCommand command = new SqlCommand("SELECT * FROM Houses", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            connection.Open();
            adapter.Fill(dataSet,"Houses");
            connection.Close();
            DataTable oldHouses = dataSet.Tables["Houses"];
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(newHouses);
        }

        public static DataView getViewHouses(string user)
        {
            DataView dataViewHouses = new DataView();
            DataTable dataTableHouses = new DataTable();
            SqlConnection connection = Remax.getConnection();
            string viewStatement = "";
            if (user == "admin")
                viewStatement = "SELECT Houses.refHouse as Id,Houses.Name,Houses.YearBuilt as Year,Houses.NetArea , Houses.price as Price, BuildingType.BuildingType as Building, NumBedrooms.NumBedrooms as Bedroom, NumParking.NumParking as Parking, PropertyType.PropertyType as Property, Employees.Name as Agent,Clients.Name as Seller,Houses.Pool,Houses.Waterfront as Water,Houses.[Reduced mobility] as Mobility,Houses.Elevator,Houses.Address, Houses.Description";
            else
                viewStatement = "SELECT Houses.refHouse as Id,Houses.Name,Houses.YearBuilt as Year,Houses.NetArea , Houses.price as Price, BuildingType.BuildingType as Building, NumBedrooms.NumBedrooms as Bedroom, NumParking.NumParking as Parking, PropertyType.PropertyType as Property, Employees.Name as Agent,Houses.Pool,Houses.Waterfront as Water,Houses.[Reduced mobility] as Mobility,Houses.Elevator,Houses.Address, Houses.Description";
            viewStatement += " FROM Houses ";
            viewStatement += " INNER JOIN BuildingType on Houses.referBuildingType = BuildingType.refBuildingType ";
            viewStatement += " INNER JOIN NumBedrooms on Houses.referNumBedrooms = NumBedrooms.refNumBedrooms ";
            viewStatement += " INNER JOIN NumParking on Houses.referNumParking = NumParking.refNumParking ";
            viewStatement += " INNER JOIN PropertyType on Houses.referPropertyType = PropertyType.refPropertyType ";
            viewStatement += " INNER JOIN Employees on Houses.referEmployee = Employees.refEmployee ";
            viewStatement += " INNER JOIN Clients on Houses.referClient = Clients.refClient ";

            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(viewStatement, connection);            
                SqlDataReader housesReader = selectCommand.ExecuteReader();
                dataTableHouses.Load(housesReader);
                dataViewHouses = dataTableHouses.DefaultView;
                return dataViewHouses;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
