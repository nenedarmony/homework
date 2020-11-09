using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_8
{
   abstract class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public long Id { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }

        public Person()
        {

        }

        protected Person(string name, string phoneNumber, long id, string adress, DateTime birthDate)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Id = id;
            Adress = adress;
            BirthDate = birthDate;
        }

      public  abstract void PrintDetails();
        public  void GetDetails()
        {
            Console.WriteLine(" enter name:" );
            Name = Console.ReadLine();
            Console.WriteLine(" enter phoneNumber:" );
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("enter id:");
            Id = long.Parse(Console.ReadLine());
            Console.WriteLine("enter adress:");
            Adress = Console.ReadLine();
            Console.WriteLine("enter birthDate:" );
            BirthDate = DateTime.Parse(Console.ReadLine());




        }


    }
}
