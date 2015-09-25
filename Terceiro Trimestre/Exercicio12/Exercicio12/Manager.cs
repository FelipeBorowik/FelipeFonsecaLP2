using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Manager : Employeeinc
    {
        Employeeinc f = new Employeeinc();
        public string Birthdate;



        public string Matricula;


        public string Name;



        public string cpf;


        public string _workarea;

        public string Workarea { get; set; }

        public override double Salary()
        {
            double sal = f.Salary() + 4000;
            return sal;
        }

        public override double Foodticketamount()
        {
            double foodticket = Salary() * 0.08;

            if (foodticket > 750)
            {
                foodticket = 750;
            }

            return foodticket;
        }
    }
}
