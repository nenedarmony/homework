using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_8
{
    class Manager:Employee
    {

       //cunstractor
        public Manager() : base()
        {

        }

       //function
        public new void GetDetails()=> base.GetDetails();
        public new void PrintDetails() => base.PrintDetails();

        public new  double  Salary_With_Bonus_Seniority() => (((DateTime.Now.Year - DateStartWork.Year) * 0.10) + 1) * Salary;
    }
}
