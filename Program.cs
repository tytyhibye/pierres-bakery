// using Bakery.BreadMenu;
using Bakery.PastryMenu;
using System;

namespace Bakery.ProgramMenu
{
  class Program
  {
    // StartMenu();
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

      // if( menuType == "B")
      // {
      //   Bread.BMenu();
      // }
      if( menuType == "P")
      {
        Pastry.PMenu();
      }
      else
      {
        Environment.Exit(0);
      }
    }
    
    public static void CheckOut(int puffPrice)
    {
      int outPut = puffPrice;
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