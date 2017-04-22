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
    }
}
