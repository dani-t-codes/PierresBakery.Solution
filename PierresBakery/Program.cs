using System.Collections.Generic;
using PierresBakery.Models;
using System;

public class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("--------------------------");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Today's Daily Deals:");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
    Console.WriteLine("Pastries: Buy 1 for $2, or 3 for $5.");
    Console.WriteLine("--------------------------");
    Console.WriteLine("What would you like to purchase today (Bread/Pastries/Exit)");
    string response = Console.ReadLine().ToLower();

    if (response == "bread") 
    {
      List<Bread> result = Bread.GetAll();
      Console.WriteLine("How many loaves of bread would you like to purchase? (e.g. 2)");
      string stringBreadLoaves = Console.ReadLine();
      int breadLoavesToNum = int.Parse(stringBreadLoaves);
      Bread newBread = new Bread(breadLoavesToNum);
      Console.WriteLine(newBread.TotBreadLoavesCost(breadLoavesToNum));
      // create if/ else for numbers vs anything else
      try 
      {
        int value = 1 / int.Parse("0"); // should value be breadLoavesToNum?
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }

      Program.Main();
    }
    else if (response == "pastries")
    {
      List<Pastry> result = Pastry.GetAll();
      Console.WriteLine("How many pastries would you like to purchase? (e.g. 2)");
      string stringPastries = Console.ReadLine();  
      int pastryStringToNum = int.Parse(stringPastries);
      Pastry newPastry = new Pastry(pastryStringToNum);
      Console.WriteLine(newPastry.TotPastryCost(pastryStringToNum));
      // create if/ else for numbers vs anything else
      try 
      {
        int value = 1 / int.Parse("0"); // should value be pastryStringToNum? 
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }

      Program.Main();
    }
    else if (response == "exit")
    {
      Console.WriteLine("Come again soon! Goodbye!");
    }
    else
    {
      Console.WriteLine("I'm not sure what you mean. Please try again.");
      Program.Main();
    }
  }
}