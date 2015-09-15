using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contesters = new string[5];
            double[,] time = new double[3, 5];
            string[] winner = new string[3];
            double[] winingtime = new double[3];
            double[] fulltime = new double[5];
            double champtime = 0;
            string champion = "";

            for (int i = 0; i < 5; i++)
            {
                contesters[i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int m = 0; m < 5; m++)
                {
                    time[i, m] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3 ; i++)
            {
                for (int m = 0; m < 5; m++)
                {
                    if (time[i , m] > winingtime[i] || (i==0 && m==0))
                    {
                        winingtime[i] = time[i, m];
                        winner[i] = contesters[m];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                fulltime[i] = time[0, 1] + time[1, i] + time[2, i];
            }

            for (int i = 0; i < 5; i++)
            {
                if (fulltime[i] < champtime || i ==0 )
                {
                    champtime = fulltime[1];
                    champion = contesters[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} foi vencedor da prova {1}", winner[i], i);
            }
            Console.WriteLine("O Campeão do circuito é {0}", champion);
            Console.WriteLine("O Tempo desse do Campeão foi de {0}s", champtime);
        }

    }
}
