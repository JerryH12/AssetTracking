// sample data

//creating a set list of products, mostly for testing purposes

//assets.Add(new Computer("HP", "Elitebook", "Sweden", "2020-10-02", "SEK", 588));
//assets.Add(new Computer("Asus", "W234", "USA", "2017-04-21", "USD", 1200));
//Creating device list


using AssetTracking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

//new Computer("Computer", "MacBook", "SD", "Sweden", Convert.ToDateTime("2021-06-14"), 1200, "SEK"),
//            new Phone("Mobile", "Samsung", "SD", "USA", Convert.ToDateTime("2022-03-12"), 200, "USD"),
//            new Phone("Mobile", "Motorolla", "HD", "India", Convert.ToDateTime("2020-12-22"), 300, "INR"),
//            new Computer("Computer", "Asus", "HD", "India", Convert.ToDateTime("2021-04-16"), 500, "INR"),
//            new Computer("Computer", "HP", "Note", "Sweden", Convert.ToDateTime("2021-03-17"), 500, "SEK"),
//            new Phone("Mobile", "Apple", "iPhone12", "Sweden", Convert.ToDateTime("2020-03-19"), 699, "SEK"),
//            new Computer("Computer", "Lenovo", "IdeaPad", "India", Convert.ToDateTime("2023-07-17"), 999, "INR"),
//            new Computer("Computer", "Dell", "ThinkPad", "USA", Convert.ToDateTime("2014-06-17"), 499, "USD"),
//            new Phone("Mobile", "Apple", "iPhone14", "USA", Convert.ToDateTime("2021-05-10"), 999, "USD"),
//            new Computer("Computer", "Lenovo", "AZ22", "Sweden", Convert.ToDateTime("2021-09-19"), 599, "SEK"),
//            new Phone("Mobile", "Apple", "iPhone11", "USA", Convert.ToDateTime("2019-05-19"), 599, "USD"),
//            new Phone("Mobile", "Apple", "iPhone13", "Sweden", Convert.ToDateTime("2016-07-10"), 799, "SEK"),
//            new Computer("Computer", "Lenovo", "SD", "India", Convert.ToDateTime("2022-05-17"), 400, "INR"),
//            new Phone("Mobile", "Apple", "iPhone15", "Sweden", Convert.ToDateTime("2021-01-10"), 1999, "SEK"),


//Phone phone = new Phone("", "", "", "", new DateTime(), 0, "");
//Console.WriteLine(phone.GetType().Name);
//var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentUICulture.LCID);
var ri = new RegionInfo("SE");
Console.WriteLine(ri.ISOCurrencySymbol);

Console.WriteLine("Menu Options");
Console.WriteLine("(1) Show an asset list");
Console.WriteLine("\"Q\" to quit");
string input = "";

while (true) 
{
    input = Console.ReadLine();

    switch (input) 
    {
        case "1":
            // show list of assets
            Utilities.ShowList();
           
            break;
        case "2":
            // add
            Utilities.Add();
            
            break;
        case "3":
            // delete
            Utilities.Remove();
            break;
        default:
            break;
    }

    if (input.ToLower() == "q")
    {
        break;
    }
}
