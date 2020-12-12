using System.Collections.Generic;
using System.Threading;
using PierresBakery.Models;
using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Today's Daily Deals:");
    Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
    Console.WriteLine("Pastries: Buy 1 for $2, or 3 for $5.");
    Console.WriteLine("--------------------------");
    Console.WriteLine("What would you like to purchase today (Bread/Pastries/Exit)");
    string response = Console.ReadLine().ToLower();

    if (response == "bread") 
    {
      Console.WriteLine("How many loaves of bread would you like to purchase? (e.g. 2)");
      string stringBreadLoaves = Console.ReadLine();
      int breadLoavesToNum = int.Parse(stringBreadLoaves);
      Console.WriteLine(TotBreadLoavesCost(breadLoavesToNum));
      // Console.WriteLine("Is this the correct number of bread loaves?"(Yes/No));  // stretch 
      // create if/ else for numbers vs anything else
      // exception handling for 0 and negative numbers - return "Not a valid #"
        // if user orders # of loaves not divisible by 3, say some kind of return about the discount applying to x # of loaves 
        // stretch - ask if they want to add to their order to X totLoaves for free loaf, return new totalCost & totalLoaves
      // string confirmNumLoaves = Console.ReadLine().ToLower();  // stretch
      //   if (confirmNumLoaves == "yes")
      //   {
      //     return costLoaves; // TODO
      //   }
      //   else
      //   {
      //     return Program.Main(); // (stretch - go to beginning of loop)
      //   }
    }
    else if (response == "pastries")
    {
      Console.WriteLine("How many pastries would you like to purchase? (e.g. 2)");
      string stringPastries = Console.ReadLine();  // (stretch - accept num value OR words translated to num) 
      int pastryStringToNum = int.Parse(stringPastries);
      // create if/ else for numbers vs anything else
      // Console.WriteLine("Is this the correct number of pastries?"(Yes/No)); //stretch
      // Console.WriteLine(TotPastryCost(pastryStringToNum));
      // exception handling for 0 and negative numbers - return "Not a valid #"
    //   string confirmNumPastries = Console.ReadLine().ToLower();  //stretch
    //     if (confirmNumPastries == "yes")
    //       {
    //         return costPastries; // TODO
    //       }
    //     else
    //       {
    //         return Program.Main(); // (stretch - go to beginning of loop)
    //       }
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

//   private static bool TotBreadLoavesCost(int breadLoavesToNum)
//   {
//     throw new NotImplementedException();
//   }
}