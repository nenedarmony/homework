using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_8
{
    class Teacher:Employee
    {

        public string JobName { get; set; }
        
        //cunstractor

        public Teacher() : base()
        {

        }

        public Teacher( string jobName,DateTime dateStartWork, int salaryParHour, int sumOfHourInWeak, int salary, string name, string phoneNumber, long id, string adress, DateTime birthDate) : base( dateStartWork,  salaryParHour,  sumOfHourInWeak,  salary,  name,  phoneNumber,  id,  adress,  birthDate)
        {
           JobName = jobName;
        }

        //function 

        public override void PrintDetails()
        {
            Console.WriteLine("jobName:" + this.JobName);
           
        }

        public override void GetDetails()
        {
          //  base.GetDetails();
            Console.WriteLine(" enter jobName:");
            JobName = Console.ReadLine();
        }

        public new double Salary_With_Bonus_Seniority() => (((DateTime.Now.Year - DateStartWork.Year) * 0.5) + 1) * Salary;
       
    }
}
