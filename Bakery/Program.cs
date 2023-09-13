using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;


namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("TODAY'S SPECIALS: Buy 2 loaves get one free!");
      Console.WriteLine("Buy 3 pastries get one free!");
      Console.WriteLine("How many loaves of bread do you want?");
      int loaves = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries do you want?");
      int pastries = int.Parse(Console.ReadLine());

      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();

      int breadCost = newBread.BreadPrice(loaves);
      int pastryCost = newPastry.PastryPrice(pastries);
      int totalCost = breadCost + pastryCost;

      Console.WriteLine($"Your total comes to ${totalCost}");

    }
  }
}