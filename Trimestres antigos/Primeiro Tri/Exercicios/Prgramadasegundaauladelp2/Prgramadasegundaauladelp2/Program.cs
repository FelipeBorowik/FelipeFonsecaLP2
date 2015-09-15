using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prgramadasegundaauladelp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int secondnumber = 0;
            int addition = 0;
            int bigger =-1;
            int smaller =1000000;

            Console.WriteLine("Digite a quantidade de numeros que você quer representado");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {


                Console.WriteLine("Digite os números");
                secondnumber = int.Parse(Console.ReadLine());
                addition += secondnumber;

                while (secondnumber > bigger)
                {               
                      bigger = secondnumber;
                }

                while  (secondnumber < smaller)
                {
                    smaller = secondnumber;
                }

            }
            Console.WriteLine("A soma dos numeros é :{0}", addition);
            Console.WriteLine("O maior número é : {0}", bigger);
            Console.WriteLine("O menor número é :{0}", smaller);
        }
    }
}
