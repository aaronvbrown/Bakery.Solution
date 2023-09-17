using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class PastryOrder
  {
    public int PastryQuantity {get; set;}

    
    //constructor
    public PastryOrder(int pastryQty) 
    {
      PastryQuantity = pastryQty;
    }

    public decimal GetAmount()
    {
      return (PastryQuantity - PastryQuantity/4) *2;
    }
  }
}