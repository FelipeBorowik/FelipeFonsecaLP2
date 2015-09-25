using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Employeeinc
    {    
       
            public double salary = 5000;
         
            public virtual double Salary()
            {
                return salary;
            }

            public virtual double Foodticketamount()
            {
                double foodticket = this.salary * (6.5 / 100);

                if (foodticket > 750)
                {
                    foodticket = 750;
                }

                return foodticket;
            
            }

        

    }
}