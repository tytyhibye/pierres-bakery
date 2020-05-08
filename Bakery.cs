using System;
using System.Collections.Generic;

namespace Bakery.Menu
{
  class Bread
  {
    public int BreadTotal { get; set; }
    // private Dictionary<int, Action> BreadMenu { get; set; }

    public Bread(int breadTotal)
    {
      BreadTotal = breadTotal;
      // BreadMenu = new Dictionary<int, Action>() { {1, () => BaguettePrice()}, {2, () => CroissantPrice()} };
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
      
      Console.WriteLine(@"
      1. Baguette($5)        2. Croissant($5)
      
Please select number 1 or 2 then hit ENTER:");

      int item = int.Parse(Console.ReadLine());
      // BreadMenu[item].invoke();
      if( item == 1)
      {
        Console.WriteLine("How many Baguettes would you like?");
        int bagAmount = int.Parse(Console.ReadLine());
        
        BagTally(bagAmount);
        CheckOut();
      }
      // else if (item == 2)
      // {
      //   CroisTally();
      // }
      else
      {
        StartMenu();
      }
    }  

    private static int BagTally(int bagAmount)
    {
      int discount = bagAmount / 3;
      int bagPrice = (bagAmount - discount)* 5;
      // Console.WriteLine(bagPrice);
      return bagPrice;
    }

    // private int CroisTally()
    // {
    //   Console.WriteLine("How many Croissants would you like?");
      
    //   int croisAmount = int.Parse(Console.ReadLine());
    //   int discount = croisAmount / 3;
    //   int croisPrice = (croisAmount - discount)* 5;
    //   Console.WriteLine("You've ordered $" + croisPrice + " worth of Croissants.");
    //   return croisPrice;
    // }

    // public int BreadTally(int bagPrice)
    // {
    //   BreadTotal += bagPrice;
    //   return BreadTotal; 
    // }

    public static void CheckOut()
    {;
      Console.WriteLine("Would you like to checkout? Y/N");
      string check = (Console.ReadLine().ToUpper());
      
      if(check == "N")
      {
        StartMenu();
      }
      else
      {
        // BagTally();
        // breadTotal = bread.bagPrice;

        Console.WriteLine("You're total today is $" + 0 + " today");
        Console.WriteLine(@"
                  (
                    )
              __..---..__
          ,-='  /  |  \  `=-.
         :--..___________..--;
          \.,_____________,./");
        Console.WriteLine("            Have a nice day!");
        Environment.Exit(0);
        }
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
  }

  // class Pastry
  // {
  //   public string PastryType { get; set; }
  //   public int PastryAmount { get; set; }
  //   public int PastryPrice { get; set; }
  //   private Dictionary<int, Action> PastryMenu { get; set; }
  // }

}