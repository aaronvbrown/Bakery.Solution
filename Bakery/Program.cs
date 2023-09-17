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
      Console.WriteLine("How many pastries would you like to purchase?");
      string pastryInput = Console.ReadLine();  
      int pastryInputQty = int.Parse(pastryInput);  
      PastryOrder pastryOrd = new PastryOrder(pastryInputQty);
      ConfirmOrEditPastryQty(pastryOrd);
      Console.WriteLine($"Your order total is ${breadOrd.GetAmount() + pastryOrd.GetAmount()} ");
      Console.WriteLine("Thank you for shopping at Pierre's!");
    }

    static void ConfirmOrEditBreadQty(BreadOrder breadOrd)
    {
      Console.WriteLine("Confirm bread order quantity:");
      Console.WriteLine($"You requested {breadOrd.BreadQuantity} loaves of bread.");
      Console.WriteLine("Is that right?  Type 'yes' to confirm or 'no' to re-enter the bread order quantity.");
      string userResponse = Console.ReadLine();
      if (userResponse == "Yes" || userResponse == "yes")
      {
        Console.WriteLine($"You requested {breadOrd.BreadQuantity}");
        Console.WriteLine($"Great!  Your bread order total is ${breadOrd.GetAmount()}");
      }
      else
      {
        Main();
      }
    }

    static void ConfirmOrEditPastryQty(PastryOrder pastryOrd)
    {
      Console.WriteLine("Confirm pastry order quantity:");
      Console.WriteLine($"You requested {pastryOrd.PastryQuantity} pastries.");
      Console.WriteLine("Is that right?  Type 'yes' to confirm or 'no' to re-enter the bread order quantity.");
      string userResponse = Console.ReadLine();
      if (userResponse == "Yes" || userResponse == "yes")
      {
        Console.WriteLine($"You requested {pastryOrd.PastryQuantity}");
        Console.WriteLine($"Great!  Your pastry order total is ${pastryOrd.GetAmount()}");
      }
      else
      {
        Main();
      }
    }
  }
}