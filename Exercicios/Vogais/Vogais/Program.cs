using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance;
            string vowels = "aeiouAEIOUÁÉÍÓÚáéíóúÀà";
            string v = "";
            int i = 0;

            Console.WriteLine("Digite uma frase: ");
            sentance = Convert.ToString(Console.ReadLine());

            while (i < sentance.Length)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (sentance[i] == vowels[j])
                    {
                        v += sentance[i];
                    }
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("A frase digitada tem  " + v.Length + " vogais");
        }
    }
}
