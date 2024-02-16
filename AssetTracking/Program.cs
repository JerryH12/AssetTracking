using AssetTracking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

string input = "";

while (true) 
{
    Utilities.DisplayMenu();

    input = Console.ReadLine();

    switch (input) 
    {
        case "1":
            // show list of assets
            Utilities.ShowList();    
            break;
        case "2":
            Utilities.ShowList(true);
            break;
        case "3":
            Utilities.AddAsset(); ;
            break;
        default:
            break;
    }

    if (input.ToLower() == "q")
    {
        break;
    }
}
