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
            //exercicio1
            long factorial = 1;
            long f = 0;
            Console.WriteLine("Digite um numero, cujo fatorial voce quer obter");
            f = int.Parse(Console.ReadLine());
            for (int i = 0; i < f; i++)
            {
                factorial *= (f - i);
            }
            Console.WriteLine("O Fatorial de {0} = {1}", f, factorial);
            //exercicio2
            //Professor nao consegui
            //exercicio3
            Console.WriteLine("Digite o numero de funcionarios:");
            int emp = int.Parse(Console.ReadLine());
            double salary;
            double increase;
            string nome;

            for (int i = 0; i < emp; i++)
            {
                Console.WriteLine("Digite o seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o valor do seu salario:");
                salary = double.Parse(Console.ReadLine());

                if (salary > -1 && salary < 2999)
                {
                    increase = salary * 1.25;                   
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario apos aumento:{2}", nome, salary, increase);                 
                }
                else if (salary > 2999 && salary < 3999)
                {
                    increase = salary / 1 / 4 + salary;                  
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario apos aumento:{2}", nome, salary, increase);                    
                }
                if (salary > 3999 && salary < 4999)
                {
                    increase = salary * 1.15;
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario apos aumento:{2}", nome, salary, increase);
                }
                else  if (salary > 4999)
                {
                    increase = salary * 1.10;
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario apos aumento:{2}", nome, salary, increase);                 
                }
            }
            //exercicio4
            int p1;
            int p2;
            int Finalmatch = 1;
            int end = 0;
            int TPP1 = 0;
            int tpp2= 0;

              while (Finalmatch != end)
            {
                Console.WriteLine();
                Console.WriteLine("Ponto Player 1: ");
                p1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ponto Player 2: ");
                p2 = int.Parse(Console.ReadLine());

               TPP1 += p1;
                tpp2 += p2;

                
                if (TPP1 == 21 && tpp2 < 20)
                {
                    Finalmatch = end;
                }
                if (tpp2 == 21 && TPP1 < 20)
                {
                    Finalmatch = end;
                }

                else  if (TPP1 > 21 && TPP1 <= tpp2 - 2)
                {
                    Finalmatch = end;
                }
                else if (tpp2 > 21 && tpp2 <= TPP1 - 2)
                {
                    Finalmatch = end;
                }
            }

            if (TPP1 > tpp2)
            {
                Console.WriteLine("Player 1 venceu com " + TPP1 + " pontos");
            }
            else
            {
                Console.WriteLine("Player 2 vencou com " + tpp2 + " pontos");
            }
            Console.WriteLine();       
        //exercicio5
            int km = 0;
            int liters = 50;
            int average = 0;
          
             Console.WriteLine("Quantos quilometros ja foram percoridos ?");
             km = int.Parse(Console.ReadLine());

             Console.WriteLine("Quantos litros ja foram consumidos ?");
             liters = int.Parse(Console.ReadLine());
             average = km / liters;

             if (liters == 0 && km < 600)
             {
                Console.WriteLine("Faltou gasolina(");
             }
                
             else { Console.WriteLine("Tu chegas ao seu destino com uma velocidade media de {0}", average); }
           //exercicio6
             int hight;
             int a = 0;
             int b = 0;
             int c = 0;
             int d = 0;
             int women = 100000;

             for (int i = 0; i < women; i++)
             {
                 Console.WriteLine("Nome:");
                 nome = Console.ReadLine();
                 Console.WriteLine("Para sair do loop, digite Fim");
                 switch (nome)
                 {
                     case "Fim":
                         i = women;
                         break;
                     default:
                         break;
                 }
                     if (nome != "Fim")
                         {
                           Console.WriteLine("Altura em cm");
                            hight = int.Parse(Console.ReadLine());

                             if (hight == a)  {b++;}

                             if (hight > a)
                             {
                                 c = a;
                                 a = hight;
                                 b = 1;
                             }
                             if (hight == c) {d++;}
                             else if (hight < a && c < hight)
                             {
                                 c = hight;
                                 d = 1;
                             }
                         }
                    }
             Console.WriteLine("As maiores alturas foram {0} e {1} , {2} pessoas tem a maior altura e {3} tem a segunda maior", a, c, b, d);
            //exercicio7 
            // Nao consegui
            //exercicio8

           int Mainnumber;
           int addition;
           int numberstoadd;

       
            Console.WriteLine("Digite um número: ");
            Mainnumber = int.Parse(Console.ReadLine());

            numberstoadd = Mainnumber;

            for (int i = 1; i < Mainnumber; i++)
            {
                addition = numberstoadd + (Mainnumber - i);
                numberstoadd = addition;
            }
            Console.WriteLine("A soma dos numeros que vem antes do numero que voce digitou é " + numberstoadd);

            
        }
    }
}
