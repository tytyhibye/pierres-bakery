using System;
using System.Collections.Generic;

namespace Bakery.Menu
{
  class Bread
  {
    public int BagPrice { get; set; }
    public int CrosPrice { get; set; }
    public int BreadTotal { get; set; }
    public int PastryTotal { get; set; }
    public int TotalPrice { get; set; }
    // private Dictionary<int, Action> BreadMenu { get; set; }

    public Bread()
    {
      BagPrice = 0;
      CrosPrice = 0;
      BreadTotal = 0;
      PastryTotal = 0;
      TotalPrice = BreadTotal + PastryTotal;
      // BreadMenu = new Dictionary<int, Action>() { {1, () => BaguettePrice()}, {2, () => CroissantPrice()} };
    }


    public static void StartMenu()
    {
      Console.WriteLine("            Menu Options:");
      Console.WriteLine("   'B' for Bread |  'P' for Pastries");
      string menuType = (Console.ReadLine().ToUpper());

      if( menuType == "B")
      {
        BMenu();
      }
      else
      {
        Environment.Exit(0);
      }
    }

    public static void BMenu()
    {
      Console.WriteLine(@"
██████╗ ██████╗ ███████╗ █████╗ ██████╗ 
██╔══██╗██╔══██╗██╔════╝██╔══██╗██╔══██╗
██████╔╝██████╔╝█████╗  ███████║██║  ██║
██╔══██╗██╔══██╗██╔══╝  ██╔══██║██║  ██║
██████╔╝██║  ██║███████╗██║  ██║██████╔╝
╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═════╝
                                                  
         Today's Special:
         Buy 2 get 1 FREE");
      
      Console.WriteLine(@"1. Baguette($5)      2. Croissant($5)
      3. Sourdough Roll($5) 4. Rosemary Potato Roll($5)
      
      Please input a number between 1 - 4 then hit ENTER:");

      int item = int.Parse(Console.ReadLine());
      // BreadMenu[item].invoke();
      if( item == 1)
      {
        Console.WriteLine("How many Baguettes would you like?");
      
        int bagAmount = int.Parse(Console.ReadLine());
        int discount = bagAmount / 3;
        int BagPrice = (bagAmount - discount)* 5;
        Console.WriteLine("You've ordered $" + BagPrice + " worth of Baguettes.");

        Console.WriteLine("Would you like to checkout? Y/N");
        string check = (Console.ReadLine().ToUpper());
       
        if(check == "N")
        {
          StartMenu();
        }
        else
        {
          CheckOut();
        }
      }
      else if (item == 2)
      {
         Console.WriteLine("How many Croissants would you like?");
        int crosAmount = int.Parse(Console.ReadLine());
        int discount = crosAmount / 3;
        int CrosPrice = (crosAmount - discount)* 5;
        Console.WriteLine("You've ordered $" + CrosPrice + " worth of Croissants.");

        Console.WriteLine("Would you like to checkout? Y/N");
        string check = (Console.ReadLine().ToUpper());

        if(check == "N")
        {
          StartMenu();
        }
        else
        {
          CheckOut();
        }
      }
      else
      {
        StartMenu();
      }
    }  

    public static void CheckOut()
    {
      Bread bread = new Bread();
      int TotalPrice = bread.BagPrice + bread.CrosPrice;
      Console.WriteLine("You're total today is $" + TotalPrice + " today.");
    } 
  }


  // class Pastry
  // {
  //   public string PastryType { get; set; }
  //   public int PastryAmount { get; set; }
  //   public int PastryPrice { get; set; }
  //   private Dictionary<int, Action> PastryMenu { get; set; }
  // }

}