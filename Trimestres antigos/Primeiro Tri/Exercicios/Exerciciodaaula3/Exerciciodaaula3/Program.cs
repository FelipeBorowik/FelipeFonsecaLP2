using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciodaaula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; 
            int y;
            int answer = 1;
             
            Console.WriteLine("Digite o expoente que tu queres");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a potencia que tu queres");
            y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {
                answer = answer * x;
            }


            Console.WriteLine("A resposta da conta aritimetica é igual a {0}", answer);

        }
    }
}
