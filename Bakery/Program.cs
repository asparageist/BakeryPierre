using System;
using System.Collections.Generic;
using System.Linq;
using Pierre.Models;


namespace Bakery.Models
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("TODAY'S SPECIALS: Buy 2 loaves get one free!");
      Console.WriteLine("Buy 3 pastries get one free!");
      Console.WriteLine("How many loaves of bread do you want?");
      int inputB = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries do you want?");
      int inputP = int.Parse(Console.ReadLine());

      int totalCost = BakeryOrder.TotalPrice(inputB, inputP);

      Console.WriteLine($"Your total comes to ${totalCost}");
    }
  }
}