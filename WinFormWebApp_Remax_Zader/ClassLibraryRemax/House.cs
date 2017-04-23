using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class House : Product
    {
        public string BuildingType
        {
            get; set;
        }

        public string NumberBedrooms
        {
            get; set;
        }

        public string NumberParking
        {
            get; set;
        }

        public string PropertyType
        {
            get; set;
        }

        public string IdAgent
        {
            get; set;
        }

        public string IdSeller
        {
            get; set;
        }

        public bool Pool
        {
            get; set;
        }

        public bool Waterfront
        {
            get; set;
        }

        public bool Elevator
        {
            get; set;
        }

        public bool AdapterMobility
        {
            get; set;
        }


        public int NetArea
        {
            get; set;
        }

        public int YearBuilt
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public House() : base()
        {
        }

        public House(string id) : base()
        {
        }

        public House(string id, string name, float price, string description,string buildingType,string numberBedrooms,string numberParking,string idAgent,string idSeller,bool pool, bool water, 
            bool  elevator, bool mobility,int netArea,int year,string address) : base(id, name, price, description)
        {
            this.BuildingType = buildingType;
            this.NumberBedrooms = numberBedrooms;
            this.NumberParking = numberParking;
            this.IdAgent = idAgent;
            this.IdSeller = idSeller;
            this.Pool = pool;
            this.Waterfront = water;
            this.AdapterMobility = mobility;
            this.Elevator = elevator;
            this.NetArea = netArea;
            this.YearBuilt = year;
            this.Address = address;
        }

    }
}
