using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region vec of person
            Person[] KindOfEmployee = new Person[4];
           
            KindOfEmployee[0] = new Student() ;
            KindOfEmployee[1] = new Employee();
            KindOfEmployee[2] = new Teacher();
            KindOfEmployee[3] = new Manager() ;

            foreach (Person item in KindOfEmployee)
            {
                item.GetDetails();
            }
            foreach (Person item in KindOfEmployee)
            {
                item.PrintDetails();
            }
            #endregion

            #region vec of employee
            Employee[] KindOfEmploye = new Employee[3];

            KindOfEmploye[0] = new Employee();
            KindOfEmploye[1] = new Manager();
            KindOfEmploye[2] = new Teacher();
           

            foreach (Person item in KindOfEmploye)
            {
                item.GetDetails();
            }

            foreach (Employee item in KindOfEmploye)
            {
                if (item is Teacher)
                    Console.WriteLine(item.JobName);
                Console.WriteLine(item.Salary_With_Bonus_Seniority()); ;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
