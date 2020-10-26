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

        public Milk(string company, DateTime expirationDate, DateTime dxpirationDate)
        {
            Company = company;
            this.expirationDate = expirationDate;
            DxpirationDate = dxpirationDate;
        }
        public Milk(Milk milk)
        {
           
            Company = milk.Company;
            expirationDate = milk.expirationDate;
            DxpirationDate = milk.DxpirationDate;
        }

        #endregion
    
        #region function

        public void Printbreed()
        {
            Console.WriteLine("the company of the milk:" + Company + "price is:"+ price);
        }

        #endregion

    }

}



