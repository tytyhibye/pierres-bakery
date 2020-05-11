using Bakery.BreadMenu;
using Bakery.ProgramMenu;
using System;
using System.Collections.Generic;

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
    Creampuffs - $2 each or 3 for $5
    Cupcakes - $3 each or 3 for $8");
    
      Console.WriteLine(@"
      1. Creampuff($2)        2. Cupcake ($3)
      
Please select number 1 or 2 then hit ENTER:");
      
      string item = (Console.ReadLine());
      
      if(item == "1")
      {
        Console.WriteLine("How many Creampuffs would you like?");
        int puffAmount = int.Parse(Console.ReadLine());
        int puffPrice = PuffAdd(puffAmount);
        Program.returnList.Add(puffPrice);
        Program.CheckOut();
      }
      else if(item == "2")
      {
        Console.WriteLine("How many Cupcakes would you like?");
        int cakeAmount = int.Parse(Console.ReadLine());
        int cakePrice = CakeAdd(cakeAmount);
        // Program.CheckOut(cakePrice);
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
      return puffPrice;
    }   

    private static int CakeAdd(int cakeAmount) 
    {
      int cakePrice = cakeAmount*3;
      for ( int i = 1; i <= cakeAmount; i++)
      {
        if(i % 3 == 0)
        {
          cakePrice -= 1;
        }
      }
      return cakePrice;
    }                                                     
  }
}