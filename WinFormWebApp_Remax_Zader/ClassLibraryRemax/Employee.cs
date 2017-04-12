using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class Employee
    {
        public string Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

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

        public Employee(string id, string name, string phone, string email, string role, string password)
        {
            this.Id = id;
            this.Name = Name;
            this.Phone = phone;
            this.Email = email;
            this.Role = role;
            this.Password = password;
        }
    }
}
