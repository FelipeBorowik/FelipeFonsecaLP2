using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Exercicio13Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Poppy para inserir uma nova pessoa na tabela, e digite John Cena para consultar um nome registrado");
            string op = Console.ReadLine();
            Pessoa P = new Pessoa();

            List<Pessoa> pessoas = new List<Pessoa>();
            if (op == "Poppy")
            {
                
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

                    command.CommandText = String.Format("INSERT INTO Pessoa (Nome,Sobrenome,Peso,Altura,Telefone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", P.Nome, P.Sobrenome, P.Peso, P.Altura, P.Telefone);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                
            }

            else if (op == "John Cena")
            {
                Console.WriteLine("Informe o nome ou o id da pessoa que voçê quer consultar informações");
                    string informação = Console.ReadLine();

                    if (informação == "nome")
                    {
                        Console.WriteLine("Digite o nome da pessoa");
                        P.Nome = Console.ReadLine();
                        string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
                        string query = string.Format("SELECT * FROM Pessoa WHERE Nome = P.Nome");
                        MySqlConnection conn = new MySqlConnection(strConn);
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = conn;
                        command.CommandText = query;
                        conn.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("Id: {0} Nome: {1} Sobrenome: {2} Peso: {3} Altura: {4} Telefone: {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetInt32(5));
                            }
                        
                        reader.Close();
                        conn.Close();
                     }

                       
                        else  
                        {
                         Console.WriteLine("Digite o id da pessoa");
                         P.Id = int.Parse(Console.ReadLine());

                         string stConn = "Server=localhost;Database=test;Uid=root;Pwd=";
                         string query2 = string.Format( "SELECT * FROM PESSOA WHERE ID = P.Id");

                         MySqlConnection con = new MySqlConnection(stConn);
                         MySqlCommand command2 = new MySqlCommand();

                         command2.Connection = con;
                         command2.CommandText = query2;

                         con.Open();
                         MySqlDataReader leitor = command2.ExecuteReader();
                         if (reader.HasRows)
                         {
                             while (reader.Read())
                             {
                                 Console.WriteLine("Id: {0} Nome: {1} Sobrenome: {2} Peso: {3} Altura: {4} Telefone: {5} ", leitor.GetInt32(0), leitor.GetString(1), leitor.GetString(2), leitor.GetDouble(3), leitor.GetDouble(4), leitor.GetInt32(5));
                             }
                         }

                         leitor.Close();
                         con.Close();
                    }
 } 
            }
        }
    }
}
