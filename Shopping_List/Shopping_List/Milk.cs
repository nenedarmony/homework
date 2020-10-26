using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    class Milk
    {
        #region prop\f

        public static int howMuchMilk { get; set; }
        public string Company { get; set; }
        private Double price;
        private DateTime expirationDate;
        public DateTime DxpirationDate
        {
            get { return expirationDate; }
            set
            {
                if (DateTime.Now == value)
                    Console.WriteLine("the date has expired buy another one ");
                else
                    expirationDate = value;
            }
        }

        #endregion

        #region constractor

        public Milk() => howMuchMilk++;

        public Milk(string company,DateTime dxpirationDate)
        {
            Company = company;
            DxpirationDate = dxpirationDate;
        }
        public Milk(Milk milk)
        {
           
            Company = milk.Company;
            DxpirationDate = milk.DxpirationDate;
        }

        #endregion

        #region function

        public void printMilk()
        {
            Console.WriteLine("Company:" + Company);
            Console.WriteLine("expirationDate:" + expirationDate);
            Console.WriteLine("price:" + price);


        }
        public void GetMilkFromUser()
        {
            Console.WriteLine(" enter Company:");
            Company = Console.ReadLine();
            Console.WriteLine(" enter price:");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter expirationDate:");
            expirationDate = DateTime.Parse(Console.ReadLine());
        }


        #endregion

    }

}



