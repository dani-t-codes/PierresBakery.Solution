// using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public bool TotBreadLoaves(int numOfLoaves)
    {
      if (numOfLoaves % 3 == 0)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
    //Buy 2, get 1 free.
    //3rd loaf is 0 dollars - if breadLoaves % 3 == 0, totBreadCost = 10  * (breadLoaves / 3)
    // else totBreadCost = breadLoaves * 5
    //Single loaf = $5
  }

  public class Pastry
  {
    public bool TotPastries(int numOfPastries)
    {
      // if (numOfPastries % 3 == 0)
      // {
      //   return true;
      // }
      // else 
      // {
        return false;
      }
    }
    //Buy 1 for $2
    //1st & 2nd loaves cost $2/each
    //Buy 3 for $5
    //3rd loaf costs $1 - if pastryNum % 3 == 0, totCost = $5 * (pastryNum / 3)
    //else totPastryCost = pastryNum * 2
  }