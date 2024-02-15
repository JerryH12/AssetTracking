using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Asset
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Office { get; set; }
        public DateTime PurchaseDate {  get; set; }
        public int Price {  get; set; }
        public string Currency { get; set; }


        public Asset(string office, DateTime purchaseDate, int price)
        {
            Office = office;
            PurchaseDate = purchaseDate;
            Price = price;
            Currency = GetCurrencySymbol(office);
        }

        private string GetCurrencySymbol(string country)
        {
            Dictionary<string, string> countryCode = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            countryCode.Add("Sweden", "SE");
            countryCode.Add("USA", "US");
            countryCode.Add("India", "IN");
            var ri = new RegionInfo(countryCode[country]);
            return ri.ISOCurrencySymbol;
        }

        public virtual int GetRemainingLife()
        {
            TimeSpan span = DateTime.Now.Subtract(PurchaseDate);
            int remainingDays = 365 * 3 - span.Days;
            return remainingDays;
        }

        public virtual void Print()
        {
            int remainingLife = GetRemainingLife();

            if (remainingLife > 0)
            {
                Console.ForegroundColor = remainingLife < 90 ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine(Type.PadRight(15) + Brand.PadRight(15) + Model.PadRight(15) + Office.PadRight(15) + PurchaseDate.ToString("yy/MM/dd").PadRight(15) + Currency.PadRight(15) + Price.ToString().PadRight(15));
                Console.ResetColor();
            }
        }
    }
}
