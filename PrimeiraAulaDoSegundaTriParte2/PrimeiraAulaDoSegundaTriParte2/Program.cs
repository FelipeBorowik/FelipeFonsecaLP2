using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAulaDoSegundaTriParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            int workersinfo = int.Parse(Console.ReadLine());
            double newsalary = 0;

            Worker w = new Worker();


            for (int i = 0; i < workersinfo; i++)
            {
                w.cpf.Add(Console.ReadLine());
                w.name.Add(Console.ReadLine());               
                w.borndate.Add(Console.ReadLine());
                w.entrydate.Add(Console.ReadLine());
                w.salary.Add(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < workersinfo; i++)
            {
                Console.WriteLine("CPF: " + w.cpf[i]);
                Console.WriteLine("Nome: " + w.name[i]);
                Console.WriteLine("Nasc: " + w.borndate[i]);
                Console.WriteLine("Admins: " + w.entrydate[i]);
                Console.WriteLine("Salario Atual: " + w.salary[i]);

                newsalary = w.calculationfornewsalary(i);

                Console.WriteLine("Novo Salário: " + newsalary);
                Console.WriteLine();
                
            }
        }
    }
}
