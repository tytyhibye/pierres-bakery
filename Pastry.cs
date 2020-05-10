// using Bakery.BreadMenu;
using Bakery.ProgramMenu;
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
      if(item == 1)
      {
        Console.WriteLine("How many Creampuffs would you like?");
        int puffAmount = int.Parse(Console.ReadLine());
        int puffPrice = PuffAdd(puffAmount);
        Program.CheckOut(puffPrice);
      }
      else
      {
        Environment.Exit(0);
      }
    }  
    
    private static int PuffAdd(int puffAmount)
    {
      for ( int i = 2; i <= puffAmount; i++)
      {
        if(i % 6 == 0)
        {
          i -= 1;
        }
      }
      return puffAmount;
    }                                                        
  }
}