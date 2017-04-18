using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class Employee:Person
    {

        public string Role
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public Employee()
        {
        }

        public Employee(string name, string phone, string email, string role, string password):base(name,phone,email)
        {
            this.Role = role;
            this.Password = password;
        }
    }
}
