using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_8
{
    class Employee : Person
    {
        public DateTime DateStartWork { get; set; }
        public int SalaryParHour { get; set; }
        public int SumOfHourInWeak { get; set; }
        public int Salary { get; set; }

        public Employee():base()
        {

        }

        public Employee(DateTime dateStartWork, int salaryParHour, int sumOfHourInWeak, int salary, string name, string phoneNumber, long id, string adress, DateTime birthDate) : base(name, phoneNumber, id, adress, birthDate)
       
        {
            DateStartWork = dateStartWork;
            SalaryParHour = salaryParHour;
            SumOfHourInWeak = sumOfHourInWeak;
            Salary = salary;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("name:" + this.Name);
            Console.WriteLine("phoneNumber:" + this.PhoneNumber);
            Console.WriteLine("id:" + this.Id);
            Console.WriteLine("adress:" + this.Adress);
            Console.WriteLine("birthDate:" + this.BirthDate);
        }
    }
}
