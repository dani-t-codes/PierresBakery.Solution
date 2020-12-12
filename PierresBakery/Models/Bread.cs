// using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
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

//refactor to Pastry.cs

  public class Pastry
  {
    public int TotPastryCost(int numOfPastries)
    {
      if (numOfPastries % 3 == 0)
      {
        return 5 * (numOfPastries / 3);
      }
      else 
      {
        return numOfPastries * 2;
        // return (2 * numOfPastries) - (1 * (numOfPastries % 3));
      }
    }
  }
    //Buy 1 for $2
    //1st & 2nd loaves cost $2/each
    //Buy 3 for $5
    //3rd loaf costs $1 - if pastryNum % 3 == 0, totCost = $5 * (pastryNum / 3)
    //else totPastryCost = pastryNum * 2
  // }
// }
}