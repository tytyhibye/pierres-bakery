using System;
using System.Collections.Generic;

namespace Bakery.Menu
{
  class Bread
  {
    public int BreadTotal { get; set; }
    // private Dictionary<int, Action> BreadMenu { get; set; }

    public Bread()
    {
      BreadTotal = 0;
      // BreadMenu = new Dictionary<int, Action>() { {1, () => BaguettePrice()}, {2, () => CroissantPrice()} };
    }

    public void BMenu()
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
      3. Sourdough Roll($5)  4. Rosemary Potato Roll($5)
      
      Please input a number between 1 - 4 then hit ENTER:");

      int item = int.Parse(Console.ReadLine());
      // BreadMenu[item].invoke();
      if( item == 1)
      {
        BagTally();
      }
      // else if (item == 2)
      // {
      //   CroisTally();
      // }
      else
      {
        StartMenu();
      }
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

    private static int BagTally()
    {
      Console.WriteLine("How many Baguettes would you like?");
      
      int bagAmount = int.Parse(Console.ReadLine());
      int discount = bagAmount / 3;
      int bagPrice = (bagAmount - discount)* 5;
      Console.WriteLine("You've ordered $" + bagPrice + " worth of Baguettes.");
      
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

    public int BreadTally(int bagPrice)
    {
      BreadTotal += bagPrice;
      return BreadTotal; 
    }

    public void CheckOut(int BreadTotal)
    {
      // Bread bread = new Bread();
      BreadTally(bagPrice);
      int TotalPrice = BreadTotal;
      Console.WriteLine("You're total today is $" + TotalPrice + " today");
      Console.WriteLine(@"
                (
                  )
            __..---..__
        ,-='  /  |  \  `=-.
       :--..____________..--;
        \.,______________,./");
 Console.WriteLine("       Have a nice day!")
      Environment.Exit(0);
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