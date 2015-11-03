using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDeRevisãoantesdaprova
{
    class ContaBancaria
    {
        public string cliente { get; set; }
        public int num_conta  { get; set; }
        public double saldo  { get; set; }
        public double novosaldo { get; set; }
        public void depositar(double valor)
        {
            novosaldo = saldo + valor;  
        }
        public void sacar( double valor )
        {
            if (saldo - valor >= 0)
            {
               novosaldo = saldo - valor; 
            }
            else
            {
                Console.WriteLine("O valor sacado vai deixar seu saldo negativo");
            }
        }
       
    }

}
