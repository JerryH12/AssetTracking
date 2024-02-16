using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Computer : Asset
    {
        public Computer(string type, string brand, string model, string office, DateTime purchaseDate, double price) : base(office, purchaseDate, price)
        {
            Type = type;
            Brand = brand;
            Model = model;
        }
    }
}
