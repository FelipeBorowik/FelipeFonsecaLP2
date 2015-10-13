using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Digite Poppy para inserir uma nova pessoa na tabela, e digite John Cena para consultar um nome registrado");
             string op = Console.ReadLine();

            List<Pessoa> pessoas = new List<Pessoa>();         
            if (op == "Poppy")
            {
              Pessoa P = new Pessoa();
              Console.Write("Digite o seu nome: ");
              P.Nome = Console.ReadLine();  
              Console.Write("Digite o seu sobrenome: ");
              P.Sobrenome = Console.ReadLine();
              Console.Write("Digite o seu peso: ");
              P.Peso = double.Parse(Console.ReadLine());
              Console.Write("Digite o seu altura: ");
              P.Altura = double.Parse(Console.ReadLine());
              Console.Write("Digite o seu telefone: ");
              P.Telefone = int.Parse(Console.ReadLine());
              pessoas.Add(P);

              string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
              MySqlConnection conn = new MySqlConnection(strConn);

              MySqlCommand command = new MySqlCommand();
              command.Connection = conn;

              command.CommandText = String.Format("INSERT INTO Pessoa (Nome,Sobrenome,Peso,Altura,Telefone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", P.Nome, P.Sobrenome , P.Peso , P.Altura , P.Telefone);
              conn.Open();
              command.ExecuteNonQuery();
              conn.Close();
            }

            else if(op == "John Cena")
            {
                    
            }
        }
    }
}
