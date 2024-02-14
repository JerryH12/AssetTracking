using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Phone : Asset
    {
        public Phone(string type, string brand, string model, string country, DateTime purchaseDate, int price, string currency) : base(purchaseDate, price, currency)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Country = country;
        }
    }
}
