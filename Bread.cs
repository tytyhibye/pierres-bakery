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
        
        int bagTally = BagAdd(bagAmount);
        BreadCheckOut(bagTally);
      }
      // else if (item == 2)
      // {
      //   Console.WriteLine("How many Croissants would you like?");
      //   int croisAmount = int.Parse(Console.ReadLine());
        
      //   int croisTally = CroisAdd(croisAmount);
      //   CheckOut(croisTally);
      // }
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

    // private static int CroisAdd(int input)
    // {
    //   int discount = input / 3;
    //   int croisPrice = (input - discount)* 4;
    //   Console.WriteLine(croisPrice);
    //   return croisPrice;
    // }

    public static void BreadCheckOut(int breadTotal)
    {
      int breadOutPut = breadTotal;
      Console.WriteLine("Would you like to checkout? Y/N");
      string check = (Console.ReadLine().ToUpper());
      
      if(check == "N")
      {
        Bakery.StartMenu();
      }
     else
      {
        Bakery.CheckOut();
      }
    }                                                          
  }
}