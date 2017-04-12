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

        protected string Description
        {
            get; set;
        }
        public abstract string GetDisplayText(string sep);
    }
}
