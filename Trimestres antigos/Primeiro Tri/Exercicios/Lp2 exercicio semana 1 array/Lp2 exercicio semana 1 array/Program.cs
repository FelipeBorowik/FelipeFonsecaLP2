using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lp2_exercicio_semana_1_array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList loopnumbers = new ArrayList();
            int k = 1;
            int add = 0;
            int average;

            for (int i = 0; k != 0; i++)
            {
                Console.WriteLine("Escreva os numeros,cujo qual vc quer a media. Obs para obter os resultados, digite 0 ");
                k = int.Parse(Console.ReadLine());

                loopnumbers.Add(k);
                loopnumbers.Remove(0);

                add += k;
            }
            Console.WriteLine();

            average = add / loopnumbers.Count;
            Console.WriteLine("A media dos numeros digitados da " + average);
        }
    }
}
