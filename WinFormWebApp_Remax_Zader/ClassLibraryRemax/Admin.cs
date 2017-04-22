using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibraryRemax
{
    public class Admin:Employee
    {
        public DataTable Houses {
            get; set;
        }

        public DataTable Clients
        {
            get; set;
        }

        public DataTable Employees
        {
            get; set;
        }

        public DataTable Languages
        {
            get; set;
        }
        public Admin():base()
        {
            this.Houses = null;
            this.Clients = null;
            this.Employees = null;
            this.Languages = null;
        }
        public Admin(string id, string name, string phone, string email, string role, string password) :base(name,phone,email,role,password) 
        {
            this.Houses = null;
            this.Clients = null;
            this.Employees = null;
            this.Languages = null;
        }

        public void SearchHouse() { }
        public void SearchClient() { }
        public void SearchEmployee() { }
        public void SearchSale() { }

        public void AddHouse(House house) {
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

        public void AddClient(Client client) {
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

        public void AddEmployee(Agent agent)
        {
            DataRow row = this.Employees.NewRow();
            row["Name"] = agent.Name;
            row["Phone"] = agent.Phone;
            row["Email"] = agent.Email;
            row["Gender"] = agent.Gender;
            row["Address"] = agent.Address;
            row["Image"] = "1.jpg";
            row["Password"] = agent.Password;
            row["Role"] = agent.Role;
            if(agent.Id!=null)
            foreach (Language l in agent.Languages)
            {
                DataRow rowL = this.Languages.NewRow();
                rowL["referEmployee"] = agent.Id;
                rowL["referLanguage"] = l.Id;
                this.Languages.Rows.Add(rowL);
            }
            this.Employees.Rows.Add(row);
        }
        public void EditEmployee(Agent agent)
        {
            foreach (DataRow row in this.Employees.Rows)
                if (Convert.ToString(row["refEmployee"]) == agent.Id)
                {
                    row["Name"] = agent.Name;
                    row["Phone"] = agent.Phone;
                    row["Email"] = agent.Email;
                    row["Gender"] = agent.Gender;
                    row["Address"] = agent.Address;
                    row["Image"] = "1.jpg";
                    row["Password"] = agent.Password;
                    row["Role"] = agent.Role;
                    foreach (DataRow rowL in this.Languages.Rows)
                        if (Convert.ToString(rowL["referEmployee"]) == agent.Id)
                            rowL.Delete();
                    foreach (Language l in agent.Languages)
                    {
                        DataRow rowL = this.Languages.NewRow();
                        rowL["referEmployee"] = agent.Id;
                        rowL["referLanguage"] = l.Id;
                        this.Languages.Rows.Add(rowL);
                    }
                }
        }
        public void DeleteEmployee(string id)
        {
            foreach (DataRow row in this.Employees.Rows)
                if (Convert.ToString(row["refEmployee"]) == id)
                    row.Delete();
            foreach (DataRow rowL in this.Languages.Rows)
                if (Convert.ToString(rowL["referEmployee"]) == id)
                    rowL.Delete();
        }
    }
}
