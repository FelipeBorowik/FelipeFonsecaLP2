using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Stringaocontrario
{
    class Program
    {
        static void Main(string[] args)
        {
         String Bailando;
         Bailando = Console.ReadLine();
         for (int i = Bailando.Length -1; i >=0 ; i--)
         {
             Console.WriteLine(Bailando[i]);
         }
  
            
        }
    }
}
