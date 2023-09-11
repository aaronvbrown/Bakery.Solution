using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("--------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("How many loaves of bread would you like to purchase?");
      string breadInput = Console.ReadLine();  
      int breadInputQty = int.Parse(breadInput);  
      BreadOrder breadOrd = new BreadOrder(breadInputQty);
      ConfirmOrEditBreadQty(breadOrd);
    }

    static void ConfirmOrEditBreadQty(BreadOrder breadOrd)
    {
      Console.WriteLine("Confirm bread order quantity:");
      // Console.WriteLIne($"You requested {breadOrd.BreadQuantity}");
      Console.WriteLine("Confirm bread order quantity:");
      // Console.WriteLIne("Is that right?  Type 'yes' to confirm or 'no' to re-enter the bread order quantity.");
    }
  }
}