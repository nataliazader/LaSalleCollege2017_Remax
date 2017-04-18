using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    abstract public class Product
    {
        public string Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public float Price
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public Product() { }

        public Product(string id,string name,float price,string description) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }

        public Product(string name, float price, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
        public abstract string GetDisplayText(string sep);
    }
}
