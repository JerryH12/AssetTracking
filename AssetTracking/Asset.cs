using System;
using System.Collections.Generic;
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
        public string Country { get; set; }
        public DateTime PurchaseDate {  get; set; }
        public int Price {  get; set; }
        public string Currency { get; set; }

        public Asset(DateTime purchaseDate, int price, string currency)
        {
            PurchaseDate = purchaseDate;
            Price = price;
            Currency = currency;
        }

        public virtual int GetRemainingLife()
        {
            TimeSpan span = DateTime.Now.Subtract(PurchaseDate);
            int remainingDays = span.Days;
            return 365 * 3 - remainingDays;
        }

        public virtual void Print()
        {
            int remainingLife = GetRemainingLife();

            if (remainingLife > 0)
            {
                Console.ForegroundColor = remainingLife < 90 ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine(Type.PadRight(15) + Brand.PadRight(15) + Model.PadRight(15) + PurchaseDate.ToString("yy/MM/dd").PadRight(15) + Currency.PadRight(15) + Price.ToString().PadRight(15));
                Console.ResetColor();
            }
        }
    }
}
