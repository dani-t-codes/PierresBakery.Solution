using System.Collections.Generic;
using PierresBakery.Models;
using System;

public class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
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
      bool success = Int32.TryParse(stringBreadLoaves, out int number);
      
      if (success)
      {
        int breadLoavesToNum = int.Parse(stringBreadLoaves);
        if (breadLoavesToNum % 3 == 0)
        {
          Bread newBread = new Bread(breadLoavesToNum);
          Console.WriteLine(newBread.TotBreadLoavesCost(breadLoavesToNum));
          Console.WriteLine("You got the best price on bread!");
        }
        else if (breadLoavesToNum % 3 != 0)
        {
          Bread newBread = new Bread(breadLoavesToNum);
          Console.WriteLine(newBread.TotBreadLoavesCost(breadLoavesToNum));
          Console.WriteLine("You should consider adding more loaves to your order to get a better deal.");
        }
        else
        {
          Console.Write("I'm sorry, something went wrong. Please try again.");
          Console.WriteLine("~~~~~~~~~");
        }
      }
      else
      {
        Console.Write("I'm sorry, something went wrong.");
        Console.WriteLine("~~~~~~~~~");
      } 
    Program.Main();
    }
    else if (response == "pastries")
    {
      List<Pastry> result = Pastry.GetAll();
      Console.WriteLine("How many pastries would you like to purchase? (e.g. 2)");
      string stringPastries = Console.ReadLine();  
      bool success = Int32.TryParse(stringPastries, out int number);
      
      if (success)
      {
        int pastryStringToNum = int.Parse(stringPastries);
        if (pastryStringToNum % 3 == 0)
        {
          Pastry newPastry = new Pastry(pastryStringToNum);
          Console.WriteLine(newPastry.TotPastryCost(pastryStringToNum));
          Console.WriteLine("You got the best deal on pastries!");
        }
        else if (pastryStringToNum % 3 != 0)
        {
          Pastry newPastry = new Pastry(pastryStringToNum);
          Console.WriteLine(newPastry.TotPastryCost(pastryStringToNum));
          Console.WriteLine("You should consider adding more pastries to your order to get a better deal.");
        }
        else
        {
          Console.Write("I'm sorry, something went wrong.");
          Console.WriteLine("~~~~~~~~~");
        }
      }
      else
      {
        Console.Write("I'm sorry, something went wrong.");
        Console.WriteLine("~~~~~~~~~");
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