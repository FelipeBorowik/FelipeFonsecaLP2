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
         String Odnaliab = "";
         String Bailando;
         Bailando = Console.ReadLine();
         for (int i = Bailando.Length -1; i >=0 ; i--)
         {
             Odnaliab += Bailando[i].ToString();
         }

         if (Bailando == Odnaliab)
         {
             Console.WriteLine("A Palavra digitada é palindromo");

         }
         else

             Console.WriteLine("A Palavra digitada não é palindromo");
            
        }
    }
}
