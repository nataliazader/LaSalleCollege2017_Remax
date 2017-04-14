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
    public static class EmployeeDB
    {
        public static List<Employee> getEmployee(string email, string password)
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
                    List<Employee> listEmp = new List<Employee>();
                    if (empReader["Role"].ToString() == "admin")
                    {
                        Admin admin = new Admin();
                        admin.Id = empReader["refEmployee"].ToString();
                        admin.Name = empReader["Name"].ToString();
                        admin.Phone = empReader["Phone"].ToString();
                        admin.Email = empReader["Email"].ToString();
                        admin.Role = empReader["Role"].ToString();
                        listEmp.Add(admin);
                    }

                    if (empReader["Role"].ToString() == "agent")
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
                        listEmp.Add(agent);
                    }

                    return listEmp;
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

    }
}
