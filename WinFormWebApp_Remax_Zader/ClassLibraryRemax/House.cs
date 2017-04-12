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

        public double NumberBedrooms
        {
            get; set;
        }

        public double NumberParking
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

        public int Pool
        {
            get; set;
        }

        public int Waterfront
        {
            get; set;
        }

        public int Elevator
        {
            get; set;
        }

        public int AccessWaterfront
        {
            get; set;
        }

        public int AdapterMobility
        {
            get; set;
        }

        public int BodyWater
        {
            get; set;
        }

        public float NetArea
        {
            get; set;
        }

        public int YearBuilt
        {
            get; set;
        }

        //example
        public override string GetDisplayText(string sep)
        {
            return this.NetArea + sep + this.YearBuilt + sep + this.Price.ToString("с");
        }
    }
}
