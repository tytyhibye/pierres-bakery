using System;
using System.Collections.Generic;

namespace Bakery.Menu
{
  class Bread
  {
    public string BreadType { get; set; }
    public int BreadAmount { get; set; }
    public int BreadPrice { get; set; }
    private Dictionary<int, Action> BreadMenu { get; set; }

    public static void StartMenu()
    {
      Console.WriteLine("            Menu Options:");
      Console.WriteLine("   'B' for Bread |  'P' for Pastries");
      string menuType = Console.ReadLine();
    }
  }

  class Pastry
  {
    public string PastryType { get; set; }
    public int PastryAmount { get; set; }
    public int PastryPrice { get; set; }
    private Dictionary<int, Action> PastryMenu { get; set; }
  }

}