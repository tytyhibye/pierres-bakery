using Bakery.Program;
using System;

namespace Bakery.PastryMenu
{

  class Pastry
    {
      public int PastryTotal { get; set; }

      public Pastry(int pastryTotal)
      {
        PastryTotal = pastryTotal;
      }

      public static void PMenu()
      {
        Console.WriteLine(@"
  ██████╗  █████╗ ███████╗████████╗██████╗ ██╗   ██╗
  ██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗╚██╗ ██╔╝
  ██████╔╝███████║███████╗   ██║   ██████╔╝ ╚████╔╝ 
  ██╔═══╝ ██╔══██║╚════██║   ██║   ██╔══██╗  ╚██╔╝  
  ██║     ██║  ██║███████║   ██║   ██║  ██║   ██║   
  ╚═╝     ╚═╝  ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝   ╚═╝   
                                                    
      ███╗   ███╗███████╗███╗   ██╗██╗   ██╗        
      ████╗ ████║██╔════╝████╗  ██║██║   ██║        
      ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║        
      ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║        
      ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝        
      ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝
                                                    
          Today's Special:
      Buy 1 for $2 or 3 for $5");
      
      Console.WriteLine(@"
        1. Creampuff($2)        2. Cupcake ($2)
        
  Please select number 1 or 2 then hit ENTER:");
      int item = int.Parse(Console.ReadLine());
      if( item == 1)
      {
        Console.WriteLine("How many Creampuffs would you like?");
        int puffAmount = int.Parse(Console.ReadLine());
        
        int puffTally = PuffAdd(puffAmount);
        PuffCheckOut(puffTally);
      }
      else
        {
          Bakery.StartMenu();
        }
      }  
      
      private static int PuffAdd(int input)
      {
        int discount = input / 3;
        int puffPrice = (input - discount)* 5;
        Console.WriteLine(puffPrice);
        return puffPrice;
      } 
      public static void PuffCheckOut(int puffTotal)
    {
      int puffOutPut = pastryTotal;
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