using Bakery.BreadMenu;
// using Bakery.PastryMenu;
using System;

namespace Bakery.Program
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(@"
                    WELCOME TO
  ██████╗ ██╗███████╗██████╗ ██████╗ ███████╗███████╗  
  ██╔══██╗██║██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝  
  ██████╔╝██║█████╗  ██████╔╝██████╔╝█████╗  ███████╗  
  ██╔═══╝ ██║██╔══╝  ██╔══██╗██╔══██╗██╔══╝  ╚════██║  
  ██║     ██║███████╗██║  ██║██║  ██║███████╗███████║  
  ╚═╝     ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝  
                                                      
      ██████╗  █████╗ ██╗  ██╗███████╗██████╗ ██╗   ██╗
      ██╔══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗╚██╗ ██╔╝
      ██████╔╝███████║█████╔╝ █████╗  ██████╔╝ ╚████╔╝ 
      ██╔══██╗██╔══██║██╔═██╗ ██╔══╝  ██╔══██╗  ╚██╔╝  
      ██████╔╝██║  ██║██║  ██╗███████╗██║  ██║   ██║   
      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝  
      
      ");

      StartMenu();
    }
      public static void StartMenu()
    {
      Console.WriteLine("            Menu Options:");
      Console.WriteLine("   'B' for Bread |  'P' for Pastries");
      string menuType = (Console.ReadLine().ToUpper());

      if( menuType == "B")
      {
        Bread.BMenu();
      }
      // else if( menuType == "P")
      // {
      //   Pastry.PMenu();
      // }
      else
      {
        Environment.Exit(0);
      }
    }
    Bread bread = new Bread();
    int breadResult = bread.breadOutput;
    public static void CheckOut(int breadResult)
    {
      int outPut = breadTotal + pastryTotal;
      Console.WriteLine("Would you like to checkout? Y/N");
      string check = (Console.ReadLine().ToUpper());
      
      if(check == "N")
      {
        StartMenu();
      }
      else
      {
      Console.WriteLine("You're total today is $" + outPut);
      Console.WriteLine(@"
                (
                  )
            __..---..__
        ,-='  /  |  \  `=-.
       :--..____________..--;
        \.,_____________,./
          Have a nice day!");
      }
      Environment.Exit(0);
    }
  }
}