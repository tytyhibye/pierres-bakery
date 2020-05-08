using System;
using System.Collections.Generic;

namespace Bakery.Menu
{
  class Bread
  {
    public int BagPrice { get; set; }
    public int CrosPrice { get; set; }
    public int BreadTotal { get; set; }
    private Dictionary<int, Action> BreadMenu { get; set; }

    public Bread()
    {
      // BagPrice = bagPrice;
      // CrosPrice = crosPrice;
      BreadTotal = 0;
      BreadMenu = new Dictionary<int, Action>() { {1, () => BaguettePrice()}, {2, () => CroissantPrice()} };
    }


    public static void StartMenu()
    {
      Console.WriteLine("            Menu Options:");
      Console.WriteLine("   'B' for Bread |  'P' for Pastries");
      string menuType = (Console.ReadLine().ToUpper());

      if( menuType == "P")
      {
        PMenu();
      }
      else
      {
        BMenu();
      }
    }

    public static void BMenu()
    {
      Console.WriteLine(@"
  ___                 _   __  __                _ 
 | _ )_ _ ___ __ _ __| | |  \/  |___ _ _ _  _  (_)
 | _ \ '_/ -_) _` / _` | | |\/| / -_) ' \ || |  _ 
 |___/_| \___\__,_\__,_| |_|  |_\___|_||_\_,_| (_)
                                                  
         Today's Special:
         Buy 2 get of FREE");
      
      Console.WriteLine(@"1. Baguette($5)      2. Croissant($5)
      3. Sourdough Roll($5) 4. Rosemary Potato Roll($5)
      
      Please input a number between 1 - 4 then hit ENTER:");

      int item = int.Parse(Console.ReadLine());
      BreadMenu[item].invoke();
    }

    private void BaguettePrice()
    {
      Console.WriteLine("How many Baguettes would you like?");
      
      int bagAmount = int.Parse(Console.ReadLine());
      int discount = bagAmount / 3;
      BagPrice = (bagAmount - discount)* 5;
      Console.WriteLine("You've ordered $" + BagPrice + " worth of Baguettes.");

      Console.WriteLine("Would you like to checkout? Y/N");
      string check = (Console.ReadLine().ToUpper());
       
      if(check == "Y")
      {
        Checkout();
      }
      else
      {
        StartMenu();
      }
    }

    private void CroissantPrice()
    {
      Console.WriteLine("How many Croissants would you like?");
      int crosAmount = int.Parse(Console.ReadLine());
      int discount = crosAmount / 3;
      CrosPrice = (crosAmount - discount)* 5;
      Console.WritLine("You've ordered $" + CrosPrice + " worth of Croissants.");

      Console.WriteLine("Would you like to checkout? Y/N");
      string check = (Console.ReadLine().ToUpper());

      if(check == "Y")
      {
        CheckOut();
      }
      else
      {
        StartMenu();
      }
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