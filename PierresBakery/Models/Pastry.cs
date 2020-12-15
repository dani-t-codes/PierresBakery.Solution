using System.Collections.Generic;
using System.Threading;
using PierresBakery.Models;

public class Pastry
  {
    // Auto-implemented properties
    public int NumOfPastries { get; set; }
    private static List<Pastry> _pastries = new List<Pastry> {};

    // Constructor
    public Pastry(int numOfPastries)
    {
      NumOfPastries = numOfPastries;
      _pastries.Add(this);
    }
    public static List<Pastry> GetAll()
    {
      return _pastries;
    }

    public static void ClearAll()
    {
      _pastries.Clear();
    }

    public int TotPastryCost(int numOfPastries)
    {
      if (numOfPastries == 1 || numOfPastries == 2)
      {
        return 2 * (numOfPastries);
      }
      else if (numOfPastries > 3 && numOfPastries % 3 != 0)
      {
        return (2 * numOfPastries) - ((numOfPastries % 3));
      }
      else if (numOfPastries % 3 == 0)
      {
        return 5 * (numOfPastries / 3);
      }
      else
      {
        return numOfPastries * 2;        
      }
    }
  }