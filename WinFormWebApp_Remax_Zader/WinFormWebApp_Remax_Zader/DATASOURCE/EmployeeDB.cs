using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibraryRemax;
using System.Data;
using System.Windows.Forms;

namespace WinFormWebApp_Remax_Zader.DATASOURCE
{
    public static class EmployeeDB
    {
        public static Employee getEmployee(string email, string password)
        {
            SqlConnection connection = Remax.getConnection();
            string selectStatement = "SELECT * FROM Employees WHERE Email = @email  AND Password = @password";
            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@email", email);
                selectCommand.Parameters.AddWithValue("@password", password);
                SqlDataReader empReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (empReader.Read())
                {
                    Employee emp = new Employee();
                    if (empReader["Role"].ToString() == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Id = empReader["refEmployee"].ToString();
                        admin.Name = empReader["Name"].ToString();
                        admin.Phone = empReader["Phone"].ToString();
                        admin.Email = empReader["Email"].ToString();
                        admin.Role = empReader["Role"].ToString();
                        emp=admin;
                    }

                    if (empReader["Role"].ToString() == "Agent")
                    {
                        Agent agent = new Agent();
                        agent.Id = empReader["refEmployee"].ToString();
                        agent.Name = empReader["Name"].ToString();
                        agent.Phone = empReader["Phone"].ToString();
                        agent.Email = empReader["Email"].ToString();
                        agent.Role = empReader["Role"].ToString();
                        agent.Gender = empReader["Gender"].ToString();
                        agent.Address = empReader["Address"].ToString();
                        agent.Image = empReader["Image"].ToString();
                        agent.Address = empReader["Address"].ToString();
                        agent.Languages = null;
                        emp=agent;
                    }

                    return emp;
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

        public static Agent getAgent(string id)
        {
            SqlConnection connection = Remax.getConnection();
            string selectStatement = "SELECT * FROM Employees WHERE refEmployee = @id";
            string selectStatementLanguages = "SELECT AgentLanguages.referLanguage as refLanguage,Languages.Language FROM AgentLanguages INNER JOIN Languages on AgentLanguages.referLanguage = Languages.refLanguage WHERE AgentLanguages.referEmployee = @id ";

            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@id", id);
                SqlDataReader empReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (empReader.Read())
                {
                    Agent agent = new Agent();
                    agent.Id = empReader["refEmployee"].ToString();
                    agent.Name = empReader["Name"].ToString();
                    agent.Phone = empReader["Phone"].ToString();
                    agent.Email = empReader["Email"].ToString();
                    agent.Role = empReader["Role"].ToString();
                    agent.Gender = empReader["Gender"].ToString();
                    agent.Password = empReader["Password"].ToString();
                    agent.Address = empReader["Address"].ToString();
                    agent.Image = empReader["Image"].ToString();
                    agent.Address = empReader["Address"].ToString();
                    connection.Close();
                    connection.Open();
                    SqlCommand selectCommandLanguages = new SqlCommand(selectStatementLanguages, connection);
                    selectCommandLanguages.Parameters.AddWithValue("@id", id);
                    SqlDataReader langReader = selectCommandLanguages.ExecuteReader();
                    while (langReader.Read())
                    {
                        Language lang = new Language(langReader["refLanguage"].ToString(),langReader["Language"].ToString());
                        agent.Languages.Add(lang);
                    }
                    return agent;
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

        public static void UpdateEmployeesDB(DataTable newEmployees,DataTable newLanguages)
        {
            SqlConnection connection = Remax.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            SqlCommand commandL = new SqlCommand("SELECT * FROM AgentLanguages", connection);
            SqlDataAdapter adapterL = new SqlDataAdapter(commandL);
            DataSet dataSetL = new DataSet();
            connection.Open();
            adapter.Fill(dataSet, "Employees");
            adapterL.Fill(dataSetL,"AgentLanguages");
            connection.Close();
            SqlCommandBuilder builderL = new SqlCommandBuilder(adapterL);
            adapterL.Update(newLanguages);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(newEmployees);
        } 
     }
}
