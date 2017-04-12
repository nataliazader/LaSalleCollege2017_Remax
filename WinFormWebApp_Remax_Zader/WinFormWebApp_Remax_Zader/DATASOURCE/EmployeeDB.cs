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
                    emp.Id = empReader["refEmployee"].ToString();
                    emp.Name = empReader["Name"].ToString();
                    emp.Phone = empReader["Phone"].ToString();
                    emp.Email = empReader["Email"].ToString();
                    emp.Role = empReader["Role"].ToString();
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

    }
}
