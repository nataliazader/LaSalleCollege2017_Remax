using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibraryRemax
{
    public class Agent :Employee
    {
        public DataTable Houses
        {
            get; set;
        }

        public DataTable Clients
        {
            get; set;
        }

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

        public List<Language> Languages
        {
            get; set;
        }

        public Agent():base() 
        {
            this.Houses = null;
            this.Clients = null;
            this.Languages = new List<Language>();
        }
        public Agent(string name, string phone, string email, string role, string gender, string address, string image, List<Language> languages, string password) :base(name,phone,email,role,password) 
        {
            this.Gender = gender;
            this.Address = address;
            this.Image = image;
            this.Languages = languages;
            this.Houses = null;
            this.Clients = null;
        }

        public Agent(string id,string name, string phone, string email, string role, string gender, string address, string image, List<Language> languages, string password) : base(id,name, phone, email, role, password)
        {
            this.Gender = gender;
            this.Address = address;
            this.Image = image;
            this.Languages = languages;
            this.Houses = null;
            this.Clients = null;
        }


        public void SearchHouse() { }
        public void SearchClient() { }

        public void AddHouse(House house)
        {
            DataRow row = this.Houses.NewRow();
            row["referBuildingType"] = house.BuildingType;
            row["referNumBedrooms"] = house.NumberBedrooms;
            row["referNumParking"] = house.NumberParking;
            row["referPropertyType"] = house.PropertyType;
            row["price"] = house.Price;
            row["referEmployee"] = house.IdAgent;
            row["referClient"] = house.IdSeller;
            row["Pool"] = house.Pool;
            row["Waterfront"] = house.Waterfront;
            row["Elevator"] = house.Elevator;
            row["Reduced Mobility"] = house.AdapterMobility;
            row["NetArea"] = house.NetArea;
            row["YearBuilt"] = house.YearBuilt;
            row["Description"] = house.Description;
            row["Name"] = house.Name;
            row["Address"] = house.Address;
            this.Houses.Rows.Add(row);
        }

        public void EditHouse(House house)
        {
            foreach (DataRow row in this.Houses.Rows)
                if (Convert.ToString(row["refHouse"]) == house.Id)
                {
                    row["referBuildingType"] = house.BuildingType;
                    row["referNumBedrooms"] = house.NumberBedrooms;
                    row["referNumParking"] = house.NumberParking;
                    row["referPropertyType"] = house.PropertyType;
                    row["price"] = house.Price;
                    row["referEmployee"] = house.IdAgent;
                    row["referClient"] = house.IdSeller;
                    row["Pool"] = house.Pool;
                    row["Waterfront"] = house.Waterfront;
                    row["Elevator"] = house.Elevator;
                    row["Reduced Mobility"] = house.AdapterMobility;
                    row["NetArea"] = house.NetArea;
                    row["YearBuilt"] = house.YearBuilt;
                    row["Description"] = house.Description;
                    row["Name"] = house.Name;
                    row["Address"] = house.Address;
                }
        }

        public void DeleteHouse(string id)
        {
            foreach (DataRow row in this.Houses.Rows)
                if (Convert.ToString(row["refHouse"]) == id)
                    row.Delete();
        }
        public void AddClient(Client client)
        {
            DataRow row = this.Clients.NewRow();
            row["Name"] = client.Name;
            row["Phone"] = client.Phone;
            row["Email"] = client.Email;
            row["Comments"] = client.Comment;
            row["referEmployee"] = client.IdAgent;
            row["Role"] = client.Role;
            this.Clients.Rows.Add(row);
        }
        public void EditClient(Client client)
        {
            foreach (DataRow row in this.Clients.Rows)
                if (Convert.ToString(row["refClient"]) == client.Id)
                {
                    row["Name"] = client.Name;
                    row["Phone"] = client.Phone;
                    row["Email"] = client.Email;
                    row["Comments"] = client.Comment;
                    row["referEmployee"] = client.IdAgent;
                    row["Role"] = client.Role;
                }
        }

        public void DeleteClient(string id)
        {
            foreach (DataRow row in this.Clients.Rows)
                if (Convert.ToString(row["refClient"]) == id)
                    row.Delete();
        }
    }
}
