using Bakery.BreadMenu;
using Bakery.PastryMenu;
using System;

namespace Bakery
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
      else if( menuType == "P")
      {
        Pastry.PMenu();
      }
      else
      {
        Environment.Exit(0);
      }
    }
    
    public static void CheckOut()
    {
      Console.WriteLine("You're total today is $" + outPut + " today");
      Console.WriteLine(@"
                (
                  )
            __..---..__
        ,-='  /  |  \  `=-.
       :--..____________..--;
        \.,_____________,./
          Have a nice day!");

      Environment.Exit(0);
      }
  }
}