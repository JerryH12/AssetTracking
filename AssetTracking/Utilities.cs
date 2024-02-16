using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    static internal class Utilities
    {
        public static List<Asset> sortedList;

        public static List<Asset> assets = [
            new Computer("Computer", "MacBook", "SD" , "Sweden",Convert.ToDateTime("2021-06-14"), 1200),
            new Phone("Mobile", "Samsung", "SD" , "USA",Convert.ToDateTime("2022-03-12"), 200),
            new Phone("Mobile", "Motorolla", "HD" , "India",Convert.ToDateTime("2020-12-22"), 300),
            new Computer("Computer", "Asus", "HD", "India", Convert.ToDateTime("2021-04-16"), 500),
            new Computer("Computer", "HP", "Note", "Sweden", Convert.ToDateTime("2021-03-17"), 500),
            new Phone("Mobile", "Apple", "iPhone12", "Sweden", Convert.ToDateTime("2020-03-19"), 699),
            new Computer("Computer", "Lenovo", "IdeaPad", "India", Convert.ToDateTime("2023-07-17"), 999),
            new Computer("Computer", "Dell", "ThinkPad", "USA", Convert.ToDateTime("2014-06-17"), 499),
            new Phone("Mobile", "Apple", "iPhone14", "USA", Convert.ToDateTime("2021-05-10"), 999),
            new Computer("Computer", "Lenovo", "AZ22", "Sweden", Convert.ToDateTime("2021-08-12"), 599),
            new Phone("Mobile", "Apple", "iPhone11", "USA", Convert.ToDateTime("2019-05-19"), 599),
            new Phone("Mobile", "Apple", "iPhone13", "Sweden", Convert.ToDateTime("2016-07-10"), 799),
            new Computer("Computer", "Lenovo", "SD", "India", Convert.ToDateTime("2022-05-17"), 400),
            new Phone("Mobile", "Apple", "iPhone15", "Sweden", Convert.ToDateTime("2021-01-10"), 1999),
            new Phone("Mobile", "Samsung", "Galaxy", "sweden", Convert.ToDateTime("23-10-10"), 2100),
        ];

        /// <summary>
        /// Display a menu of options.
        /// </summary>
        public static void DisplayMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("(1) Show an asset list sorted by Type and Date.");
            Console.WriteLine("(2) Show an asset list sorted by Office and Date.");
            Console.WriteLine("(3) Add a new asset.");
            Console.WriteLine("Enter \"Q\" to quit\n");     
        }

        /// <summary>
        /// Add a new asset to the list that can be either computer or phone.
        /// </summary>
        public static void AddAsset()
        {
            try
            {
                string type, model, brand, office, input;
                double priceInUSD;
               
                Console.WriteLine("Add a new asset by entering the following: ");

                Console.Write("Type (Phone/Computer): ");
                type = Console.ReadLine();

                Console.Write("Model: ");
                model = Console.ReadLine();

                Console.Write("Brand: ");
                brand = Console.ReadLine();

                Console.Write("Office (Sweden/USA/India): ");
                office = Console.ReadLine();

                Console.Write("Purchase Date (year-month-day): ");
                input = Console.ReadLine();

                if(!DateTime.TryParse(input, out DateTime date))
                {
                    throw new FormatException();
                }
               
                Console.Write("Price in USD: ");
                input = Console.ReadLine();

                if(!double.TryParse(input, out double price))
                {
                    throw new FormatException();
                }
               
                Asset asset1;
                bool error = false;

                switch (type.ToLower())
                {
                    case "computer":
                        assets.Add(new Computer(type, brand, model, office, date, price));
                        break;
                    case "phone":
                        assets.Add(new Phone(type, brand, model, office, date, price));
                        break;
                    default:
                        error = true;
                        break;
                }

                if (error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Asset could not be added. Try again!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("The new asset was added successfully!\n");
                }

                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            return;
        }

        /// <summary>
        /// It does nothing. To be implemented in the future.
        /// </summary>
        public static void Remove() { }

        /// <summary>
        /// Show a list of assets. Can be sorted by office and date or by type and date if the parameter is left out.
        /// </summary>
        /// <param name="orderByOffice"></param>
        public static void ShowList(bool orderByOffice = false) 
        {
            if (orderByOffice)
            {
                sortedList = assets.OrderBy(asset => asset.Office).ThenBy(asset => asset.PurchaseDate).ToList();
            }
            else
            {
                sortedList = assets.OrderBy(asset => asset.GetType().Name).ThenBy(asset => asset.PurchaseDate).ToList();
            }

            Console.WriteLine("\n");
            Console.WriteLine("Type".PadRight(12) + "Brand".PadRight(12) + "Model".PadRight(12) + "Office".PadRight(10) + "Purchase Date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(12) + "Local price today");
            Console.WriteLine("----".PadRight(12) + "-----".PadRight(12) + "-----".PadRight(12) + "------".PadRight(10) + "-------------".PadRight(15) + "------------".PadRight(15) + "--------".PadRight(12) + "----------------");
           
            foreach (Asset asset in sortedList)
            {
                asset.Print();
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        }
    }
}
