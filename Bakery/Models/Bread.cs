using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class BreadOrder
  {
    public int BreadQuantity {get; set;}

    
    //constructor
    public BreadOrder(int breadQty) 
    {
      BreadQuantity = breadQty;
    }

    public decimal GetAmount()
    {
      return (BreadQuantity - BreadQuantity/3) * 5;
    }
  }
}git 