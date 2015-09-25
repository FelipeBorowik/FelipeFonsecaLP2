using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program 
    {
        static void Main(string[] args)
        {
            int amountofworkers;
            double incmoney = 0;
            string employeetype;
            Employeeinc f = new Employeeinc();
         
            amountofworkers = Convert.ToInt32(Console.ReadLine());

            Outsourced outsourced = new Outsourced();
            Worker worker = new Worker();
            Manager manager = new Manager();


            List<Outsourced> outsourceds = new List<Outsourced>();
            List<Worker> workers = new List<Worker>();
            List<Manager> managers = new List<Manager>();

            int j = 0;
            int k = 0;
            int l = 0;

            for (int i = 0; i < amountofworkers; i++)
            {
               
                employeetype = Console.ReadLine();
                Console.WriteLine();

                if (employeetype == "Outsourced")
                {
                    Console.Write("Nome: ");
                    outsourced.name = Console.ReadLine();

                    Console.WriteLine("Matrícula: ");
                    outsourced.Matricula = Console.ReadLine();

                    Console.Write("Data Nascimento: ");
                    outsourced.birthdate = Console.ReadLine();

                    Console.Write("CPF: ");
                    outsourced.cpf = Console.ReadLine();

                    Console.Write("CNPJ: ");
                    outsourced.cnpj = Console.ReadLine();

                    outsourceds.Add(outsourced);
                    k++;
                }

                else if (employeetype == "Worker")
                {
                    double foodticket = worker.Foodticketamount();

                    Console.Write("Nome: ");
                    worker.Name = Console.ReadLine();

                    Console.Write("Matrícula: ");
                    worker.Matricula = Console.ReadLine();

                    Console.Write("Data Nascimento: ");
                    worker.Birthdate = Console.ReadLine();

                    Console.Write("CPF: ");
                    worker.cpf = Console.ReadLine();

                    workers.Add(worker);
                    j++;
                }

                else if (employeetype == "Manager")
                {
                    Console.Write("Nome: ");
                    manager.Name = Console.ReadLine();

                    Console.Write("Matrícula: ");
                    manager.Matricula = Console.ReadLine();

                    Console.Write("Data Nascimento: ");
                    manager.Birthdate = Console.ReadLine();

                    Console.Write("CPF: ");
                    manager.cpf = Console.ReadLine();

                    Console.Write("Área de Atuação: ");
                    manager.Workarea = Console.ReadLine();

                    Console.WriteLine();

                    managers.Add(manager);
                    l++;
                }

            }

            if (outsourceds.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Outsourced");
                Console.WriteLine();

                for (int m = 0; m < outsourceds.Count; m++)
                {
                    Console.WriteLine("Nome: " + outsourceds[m].name);
                    Console.WriteLine("Terceirizado: " + outsourceds[m].Matricula);
                    Console.WriteLine("Data Nascimento: " + outsourceds[m].birthdate);
                    Console.WriteLine("CPF: " + outsourceds[m].cpf);
                    Console.WriteLine("CNPJ: " + outsourceds[m].cnpj);
                    Console.WriteLine();
                }
            }

            if (managers.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Gerentes");
                Console.WriteLine();

                for (int n = 0; n < managers.Count; n++)
                {
                    double Managerfoodticketamount = managers[n].Foodticketamount();

                    Console.WriteLine("Nome" + managers[n].Name);
                    Console.WriteLine("Matrícula: " + managers[n].Matricula);
                    Console.WriteLine("Data de nascimento: " + managers[n].Birthdate);
                    Console.WriteLine("CPF: " + managers[n].cpf);
                    Console.WriteLine("Salário: " + managers[n].Salary());
                    Console.WriteLine("Área de atuação: " + managers[n].Workarea);
                    Console.WriteLine("Vale Alimentação: " + Managerfoodticketamount);
                    Console.WriteLine();

                    incmoney += managers[n].Salary() + Managerfoodticketamount;
                }
            }

            if (workers.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Trabalhadores");
                Console.WriteLine();

                for (int o = 0; o < workers.Count; o++)
                {
                    double Workerfoodticketamount = workers[o].Foodticketamount();
                    Console.WriteLine("Name: " + workers[o].Name);
                    Console.WriteLine("Matrícula: " + workers[o].Matricula);
                    Console.WriteLine("Data Nascimento: " + workers[o].Birthdate);
                    Console.WriteLine("CPF : " + workers[o].cpf);
                    Console.WriteLine("Salário: " + workers[o].Salary());
                    Console.WriteLine("Vale alimentação: " + Workerfoodticketamount);
                    Console.WriteLine();

                    incmoney += workers[o].Salary() + workers[o].Foodticketamount();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Despesa da empresa com o salário mensal dos seus funcionários: " + incmoney);
        }
    }
}
