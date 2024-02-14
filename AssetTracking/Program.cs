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

string input = "";

while (true) 
{
    input = Console.ReadLine();

    switch (input) 
    {
        case "1":
            // showlist
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
