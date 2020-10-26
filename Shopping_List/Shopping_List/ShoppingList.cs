using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    class ShoppingList
    {
       

        public const String bh = "BH";//שומר על השם הזה ולא משתנה לעולם
        public string ListName;
        public DateTime DateList;

        public Breed[] breedArr { get; set; } //הגדרנו מערך
        public Milk[] milkArr { get; set; }  //הגדרנו מערך

        #region constractor
        public ShoppingList(ShoppingList s)
        {
            ListName = s.ListName;
            DateList = s.DateList;

            breedArr =  new Breed(breedArr);


        }

        public ShoppingList(int numOfBreed, int numOfMilk)
        {
            breedArr = new Breed[numOfBreed];
            for (int i = 0; i <numOfBreed; i++)
            {
                breedArr[i] = new Breed();
            }
            milkArr = new Milk[numOfMilk];
            for (int i = 0; i < numOfMilk; i++)
            {
                milkArr[i] = new Milk();
            }
        }
        #endregion
        #region function
        public void PrintList()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; 
            Console.OutputEncoding = new UTF8Encoding();
            Console.WriteLine(new String((bh+" list name:"+ListName+", date: "+DateList).Reverse().ToArray()));
            Console.WriteLine();
        }


        #endregion
    }
}
