using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class User : Employee
    {
        public User() : base() { }

        public User(string id, string name, string phone, string email, string role, string password) :base(id,name,phone,email,role,password) 
        {
        }

        public void SearchHouse() { }
        public void SearchEmployee() { }
    }
}
