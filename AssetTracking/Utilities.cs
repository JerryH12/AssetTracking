using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    static internal class Utilities
    {
        public static List<Asset> sortedList = [];
        public static List<Asset> assets = [
            new Computer("Computer", "MacBook", "SD" , "Sweden",Convert.ToDateTime("2021-06-14"), 1200, "SEK"),
            new Phone("Mobile", "Samsung", "SD" , "USA",Convert.ToDateTime("2022-03-12"), 200, "USD"),
            new Phone("Mobile", "Motorolla", "HD" , "India",Convert.ToDateTime("2020-12-22"), 300, "INR"),
            new Computer("Computer", "Asus", "HD", "India", Convert.ToDateTime("2021-04-16"), 500, "INR"),
            new Computer("Computer", "HP", "Note", "Sweden", Convert.ToDateTime("2021-03-17"), 500, "SEK"),
            new Phone("Mobile", "Apple", "iPhone12", "Sweden", Convert.ToDateTime("2020-03-19"), 699, "SEK"),
            new Computer("Computer", "Lenovo", "IdeaPad", "India", Convert.ToDateTime("2023-07-17"), 999, "INR"),
            new Computer("Computer", "Dell", "ThinkPad", "USA", Convert.ToDateTime("2014-06-17"), 499, "USD"),
            new Phone("Mobile", "Apple", "iPhone14", "USA", Convert.ToDateTime("2021-05-10"), 999, "USD"),
            new Computer("Computer", "Lenovo", "AZ22", "Sweden", Convert.ToDateTime("2021-09-19"), 599, "SEK"),
            new Phone("Mobile", "Apple", "iPhone11", "USA", Convert.ToDateTime("2019-05-19"), 599, "USD"),
            new Phone("Mobile", "Apple", "iPhone13", "Sweden", Convert.ToDateTime("2016-07-10"), 799, "SEK"),
            new Computer("Computer", "Lenovo", "SD", "India", Convert.ToDateTime("2022-05-17"), 400, "INR"),
            new Phone("Mobile", "Apple", "iPhone15", "Sweden", Convert.ToDateTime("2021-01-10"), 1999, "SEK"),
        ];

        public static void Add()
        {}

        public static void Remove() { }

        public static void ShowList() 
        {     
            sortedList = assets.OrderBy(asset => asset.Type).ThenBy(asset => asset.PurchaseDate).ToList();

            Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Purchase Date".PadRight(15) + "Currency".PadRight(15) + "Price".PadRight(15));
           
            foreach (Asset asset in sortedList)
            {
                asset.Print();
            }
        }
    }
}
