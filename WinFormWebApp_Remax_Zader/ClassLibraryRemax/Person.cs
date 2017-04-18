using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class Person
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

        public Person() { }

        public Person(string name,string phone,string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }

        public Person(string id, string name, string phone, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }

    }
}
