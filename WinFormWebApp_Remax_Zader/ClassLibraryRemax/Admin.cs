using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class Admin:Employee
    {
        public Admin():base(){ }
        public Admin(string id, string name, string phone, string email, string role, string password) :base(id,name,phone,email,role,password) 
        {
        }

        public void SearchHouse() { }
        public void SearchClient() { }
        public void SearchEmployee() { }
        public void SearchSale() { }

        public void AddHouse() { }
        public void AddClient() { }
        public void AddEmployee() { }
        public void AddSale() { }
    }
}
