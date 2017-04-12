using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class Agent :Employee
    {
        public string Gender
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public string Image
        {
            get; set;
        }

        public List<string> Languages
        {
            get; set;
        }

        public Agent():base() 
        {
        }
        public Agent(string id, string name, string phone, string email, string role, string gender, string address, string image, List<string> languages, string password) :base(id,name,phone,email,role,password) 
        {
            this.Gender = gender;
            this.Address = address;
            this.Image = image;
            this.Languages = languages;
        }

        public void SearchHouse() { }
        public void SearchClient() { }

        public void AddHouse() { }
        public void AddClient() { }
    }
}
