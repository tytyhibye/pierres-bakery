using Bakery.BreadMenu;
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
      
      string item = (Console.ReadLine());
      if(item == "1")
      {
        Console.WriteLine("How many Creampuffs would you like?");
        int puffAmount = int.Parse(Console.ReadLine());
        int puffPrice = PuffAdd(puffAmount);
        Program.CheckOut(puffPrice);
      }
      else
      {
        Program.Main();
      }
    }  
    
    private static int PuffAdd(int puffAmount) 
    {
      int puffPrice = puffAmount*2;
      for ( int i = 1; i <= puffAmount; i++)
      {
        if(i % 3 == 0)
        {
          puffPrice -= 1;
        }
      }
      Console.WriteLine(puffPrice);
      return puffPrice;
    }                                                        
  }
}