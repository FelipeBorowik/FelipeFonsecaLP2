using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLp2Aula1SemArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            int average;
            int n = 1;
            int i = 0;

            while (n != 0)
            {
                Console.WriteLine("Defina um valor para o N. Para obter o resultado digite 0 ");
                n = int.Parse(Console.ReadLine());

                numbers += n;
                i++;
            }

            Console.WriteLine();
            average = numbers / (i - 1);

            Console.WriteLine("A média dos numeros digitados é " + average);
        }
    }
}
