using Bakery.BreadMenu;
using Bakery.PastryMenu;
using System;
using System.Collections.Generic;

namespace Bakery.ProgramMenu
{
  class Program
  {
  
    public static void Main()
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
        Main();
      }
    }

    public static List<int> returnList = new List<int>();

    public static void CheckOut()
    {
      // int outPut = orderPrice;
      Console.WriteLine("Would you like to checkout? Y/N");
      string check = (Console.ReadLine().ToUpper());
      
      if(check == "Y")
      {
        int outPut = 0;
        for(int i = 0; i < returnList.Count; i ++)
        {
          outPut += returnList[i];
          // Console.WriteLine(returnList[i]);
          // Console.WriteLine(outPut);
        }
        Console.WriteLine("You're total today is $" + outPut);
        Console.WriteLine(@"
                  (
                    )
              __..---..__
          ,-='  /  |  \  `=-.
         :--..___________..--;
          \.,_____________,./
            Have a nice day!");
      Environment.Exit(0);
      }
      else
      {
        StartMenu();
      }
    }
  }
}

// int carbholder = 0
// for (i = 0; i>= list.length; i ++)
// {carbholder += list[i]}