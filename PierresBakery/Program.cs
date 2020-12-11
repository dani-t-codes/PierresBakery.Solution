using System;
using System.Collections.Generic;
using Bread.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Today's Daily Deals:");
    Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
    Console.WriteLine("Pastries: Buy 1 for $2, or 3 for $5.");
    Console.WriteLine("What would you like to purchase today (Bread/Pastries/Exit)");
    string response = Console.ReadLine().ToLower();


  // private class Bread()
    if (response == "bread") 
    {
      Console.WriteLine("How many loaves of bread would you like to purchase?");
      int breadLoaves = Console.ReadLine();
      Console.WriteLine("Is this the correct number of bread loaves?"(Yes/No));
      Console.WriteLine(breadLoaves);
      string confirmNumLoaves = Console.ReadLine().ToLower();
        if (confirmNumLoaves == "yes")
        {
          return costLoaves;
        }
        else
        {
          return Program.Main(); // (stretch - go to beginning of loop)
        }
    }
    else if (response == "pastries")
    {

    }
    else (response == "exit");
    {

    }
  }
}