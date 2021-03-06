using Bakery.PastryMenu;
using Bakery.ProgramMenu;
using System;
using System.Collections.Generic;

namespace Bakery.BreadMenu
{
  class Bread
  {
    public int BreadTotal { get; set; }

    public Bread(int breadTotal)
    {
      BreadTotal = breadTotal;
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
                                          
 ███╗   ███╗███████╗███╗   ██╗██╗   ██╗
 ████╗ ████║██╔════╝████╗  ██║██║   ██║
 ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
 ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║
 ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
 ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 
                                                  
         Today's Special:
         Buy 2 get 1 FREE");
      
      Console.WriteLine(@"
      1. Baguette($5)        2. Croissant($4)
      
Please select number 1 or 2 then hit ENTER:");

      string item = (Console.ReadLine());
      if(item == "1")
      {
        Console.WriteLine("How many Baguettes would you like?");
        int bagAmount = int.Parse(Console.ReadLine());
        int bagPrice = BagAdd(bagAmount);
        Program.returnList.Add(bagPrice);
        Program.CheckOut();

      }
      else if(item == "2")
      {
        Console.WriteLine("How many Croissants would you like?");
        int croiAmount = int.Parse(Console.ReadLine());
        int croiPrice = CroiAdd(croiAmount);
        Program.returnList.Add(croiPrice);
        Program.CheckOut();
      }
      else
      {
        Program.Main();
      }
    }  

    private static int BagAdd(int input)
    {
      int discount = input / 3;
      int bagPrice = (input - discount)* 5;
      return bagPrice;
    } 

    private static int CroiAdd(int input)
    {
      int discount = input / 3;
      int croiPrice = (input - discount)* 4;
      return croiPrice;
    }                                                                          
  }
}