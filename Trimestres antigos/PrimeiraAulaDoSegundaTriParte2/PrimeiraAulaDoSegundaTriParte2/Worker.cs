using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PrimeiraAulaDoSegundaTriParte2
{
    class Worker
    {
        public ArrayList cpf = new ArrayList();
        public ArrayList borndate = new ArrayList();
        public ArrayList entrydate = new ArrayList();
        public ArrayList salary = new ArrayList();
        public ArrayList name = new ArrayList();

        public double calculationfornewsalary(int j)
        {
            double modifiedsalary = 0;

            if (Convert.ToInt32(entrydate[j]) >= 2014)
            {
                modifiedsalary = Convert.ToDouble(salary[j]) + 423.45;
            }
            else if (Convert.ToInt32(entrydate[j]) >= 2010 && Convert.ToInt32(entrydate[j])<= 2013)
            {
                double addiciontosalary = Convert.ToDouble(salary[j]) * 9.84 / 100;
                modifiedsalary = Convert.ToDouble(salary[j]) + addiciontosalary;
            }
            else if (Convert.ToInt32(entrydate[j]) >= 2000 && Convert.ToInt32(entrydate[j]) <= 2010)
            {
                double addiciontosalary1 = Convert.ToDouble(salary[j])* 16.4 / 100;
                modifiedsalary = Convert.ToDouble(salary[j]) + addiciontosalary1;
            }
            else if (Convert.ToInt32(entrydate[j]) < 2000)
            {
                 double addiciontosalary2 = Convert.ToDouble(salary[j])* 22.6 / 100;
                 modifiedsalary = Convert.ToDouble(salary[j]) + addiciontosalary2;
            }

            return modifiedsalary;
        }
    }
}
