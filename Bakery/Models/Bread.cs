using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class BreadOrder
  {
    public int BreadQuantity {get; set;}

    public BreadOrder(int breadQty) 
    {
      BreadQuantity = breadQty;
    }

    // public SetBreadQuantity(int breadQty)
    // {
    //   BreadQuantity = breadQty;
    // }
    
    // public decimal GetAmount()
    // {
    //   return BreadQuantity * 5
    // }
  }
}