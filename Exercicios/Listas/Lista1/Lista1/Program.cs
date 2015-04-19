using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorials();
            
        }
        static void Factorials(bool ex2 = false) 
        {
            int factorial = 1;
            int f = 0;           
           Console.WriteLine("Digite um numero, cujo fatorial voce quer obter");
           f = int.Parse(Console.ReadLine());           
           for (int i = 0; i < f; i++)
            {
                factorial *= (f - i);
            }                      
           Console.WriteLine("O Fatorial de {0} = {1}", f, factorial);            
        }

    }
}
