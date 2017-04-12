using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class Company
    {
        public string Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }

        public Company()
        {
        }

        public Company(string id, string name, string address, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
    }
}
