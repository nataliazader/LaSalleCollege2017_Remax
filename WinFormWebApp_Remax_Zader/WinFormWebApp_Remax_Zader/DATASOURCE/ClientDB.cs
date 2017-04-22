using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibraryRemax;
using System.Data;

namespace WinFormWebApp_Remax_Zader.DATASOURCE
{
    public static class ClientDB
    {
        public static Client getClient(string id)
        {
            SqlConnection connection = Remax.getConnection();
            string selectStatement = "SELECT * FROM Clients WHERE refClient = @refClient";
            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@refClient",id);
                SqlDataReader clientReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (clientReader.Read())
                {
                    Client client = new Client();
                    client.Id = clientReader["refClient"].ToString();
                    client.Name = clientReader["Name"].ToString();
                    client.Phone = clientReader["Phone"].ToString();
                    client.Email = clientReader["Email"].ToString();
                    client.Comment = clientReader["Comments"].ToString();
                    client.IdAgent = clientReader["referEmployee"].ToString();
                    client.Role = clientReader["Role"].ToString();
                    return client;
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

        public static void UpdateClientsDB(DataTable newClients)
        {
            SqlConnection connection = Remax.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Clients", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            connection.Open();
            adapter.Fill(dataSet, "Clients");
            connection.Close();
            DataTable oldClients = dataSet.Tables["Clients"];
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(newClients);
        }
    }
}
