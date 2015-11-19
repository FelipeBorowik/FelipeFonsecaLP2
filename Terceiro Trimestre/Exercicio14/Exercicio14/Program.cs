using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;database=test;Uid=root;Pwd=");
            MySqlDataReader read = new MySqlDataReader();
            User U = new User();
            bool logado = false;

            
                if (logado == false)
                {
                    Console.WriteLine("Digite a sua nome de login e a sua senha");
                    U.Login = Console.ReadLine();
                    U.Passward = Console.ReadLine();

                    if (read.HasRows)
                    {
                        while (read.Read() && logado == false)
                        {
                            if (read.GetString(3) == U.Login && read.GetString(4) == U.Passward)
                            {
                                DateTime today = DateTime.Now;
                                cmd.CommandText = String.Format("INSERT INTO User (LastAccess) VALUES ('{0}')", today);
                                cmd.Connection.Open();
                                cmd.ExecuteNonQuery();
                                cmd.Connection.Close();
                                logado = true;
                                Console.WriteLine("Login completo");
                            }
                        }

                        if (logado == false)
                            Console.WriteLine("Login não realizado, confira se todos os dados estão corretos");
                    }

                    else
                        Console.WriteLine("Login não realizado, confira se todos os dados estão corretos");
                }

                else
                {
                    Console.WriteLine("Para sair do accesso, digite Ja acabou Jessica ");
                    string exit = Console.ReadLine();

                    if (exit == "Ja acabou Jessica")
                    {
                        logado = false;
                       
                    }
                }
            

        }
    }
}
