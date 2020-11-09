using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_8
{
   abstract class Student:Person
    {
        public string Subject { get; set; }

        public Student():base()
        {

        }

        protected Student(string subject, string name, string phoneNumber, long id, string adress, DateTime birthDate) :base(name,phoneNumber,id,adress,birthDate)
        {
            Subject = subject;
        }

        public override void PrintDetails()
        {
            Console.WriteLine("name:"+this.Name);
            Console.WriteLine("phoneNumber:" + this.PhoneNumber);
            Console.WriteLine("id:" + this.Id);
            Console.WriteLine("adress:" + this.Adress);
            Console.WriteLine("birthDate:" + this.BirthDate);
            Console.WriteLine("subject:" + this.Subject);
        }
        public new  void GetDetails()
        {
            Console.WriteLine(" enter Subject:");
            Subject = Console.ReadLine();
        }
        }
}
