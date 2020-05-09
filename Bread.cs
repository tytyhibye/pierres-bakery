// using Bakery.PastryMenu;
using Bakery.Program;
using System;


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

      int item = int.Parse(Console.ReadLine());
      if( item == 1)
      {
        Console.WriteLine("How many Baguettes would you like?");
        int bagAmount = int.Parse(Console.ReadLine());
        
        int bagPrice = BagAdd(bagAmount);
        int breadTotal = BreadCheckout(bagPrice);
        int breadOutput = Program.CheckOut(breadTotal);
      }
      else
      {
        Bakery.StartMenu();
      }
    }  

    private static int BagAdd(int input)
    {
      int discount = input / 3;
      int bagPrice = (input - discount)* 5;
      // Console.WriteLine(bagPrice);
      return bagPrice;
    }

    private static int BreadCheckOut(int breadPrice)
    {
      int breadTotal = breadPrice;
      Console.WriteLine(breadTotal);
      return breadTotal;
    }                                                          
  }
}