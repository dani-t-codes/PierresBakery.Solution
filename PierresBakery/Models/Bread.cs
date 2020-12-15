using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    // Auto-implemented properties
    public int NumOfLoaves { get; set; }
    private static List<Bread> _loaves = new List<Bread> {};

    // Constructor
    public Bread(int numOfLoaves)
    {
      NumOfLoaves = numOfLoaves;
      _loaves.Add(this);
    }
    public static List<Bread> GetAll()
    {
      return _loaves;
    }
    public static void ClearAll()
    {
      _loaves.Clear();
    }
    public int TotBreadLoavesCost(int numOfLoaves)
    {
      if (numOfLoaves != 1 && numOfLoaves != 2 && numOfLoaves != 3 && numOfLoaves % 3 == 0)
      {
        return 10 * (numOfLoaves / 3);
      }
      else if (numOfLoaves % 3 != 0 && numOfLoaves != 1 && numOfLoaves != 2)
      {
        return (5 * numOfLoaves) - (5 * (numOfLoaves % 3));
      }
      else if (numOfLoaves == 1 || numOfLoaves == 2)
      {
        return numOfLoaves * 5;
      }
      else if (numOfLoaves == 3)
      {
        return 10;
      }
      else
      {
        return 0; 
      }
    }
  }

}