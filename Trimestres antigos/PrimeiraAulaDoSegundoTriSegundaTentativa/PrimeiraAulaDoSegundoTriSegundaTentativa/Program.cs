using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAulaDoSegundoTriSegundaTentativa
{
    class Program
    {
        static void Main(string[] args)
        {
            int workersinfo = int.Parse(Console.ReadLine());
            int[] cpf = new int[workersinfo];
            int[] borndate = new int[workersinfo];
            int[] entrydate = new int[workersinfo];
            double[] salary = new double[workersinfo];
            double[] Newsalary = new double[workersinfo];
            string[] name = new string[workersinfo];

            for (int i = 0; i < workersinfo; i++)
            {
                name[i] = Console.ReadLine();
                cpf[i] = int.Parse(Console.ReadLine());
                borndate[i] = int.Parse(Console.ReadLine());
                entrydate[i] = int.Parse(Console.ReadLine());
                salary[i] = double.Parse(Console.ReadLine());

                if (entrydate[i] >=2014 )
                {
                    Newsalary[i] = salary[i] + 423.45;
                }
                else if (entrydate[i] >=2010 && entrydate[i] <= 2013)
                {
                    Newsalary[i] = salary[i] + (salary[i] * 9.84 / 100); 
                }
                else if (entrydate[i] >= 2000 && entrydate[i] <= 2010)
                {
                    Newsalary[i] = salary[i] + (salary[i] * 16.4 / 100);
                }
                else if (entrydate[i] < 2000)
                {
                    Newsalary[i] = salary[i] + (salary[i] * 22.6 / 100);
                }
            }

            for (int i = 0; i < workersinfo; i++)
            {
                Console.WriteLine("CPF: " + cpf[i]);
                Console.WriteLine("Nome: " + name[i]);
                Console.WriteLine("Nasc: " + borndate[i]);
                Console.WriteLine("Admins: " + entrydate[i]);
                Console.WriteLine("Salario Atual: " + salary[i]);
                Console.WriteLine("Novo Salario: " + Newsalary[i]);





            }


           
        }
    }
}
