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

        public Breed[] breedArr; //הגדרנו מערך
        public Milk[] milkArr; //הגדרנו מערך

        public ShoppingList(string listName, DateTime dateList)
        {
            ListName = listName;
            DateList = dateList;
        }

        public ShoppingList(int numOfBreed, int numOfMilk)
        {
            breedArr = new Breed[numOfBreed];
            milkArr = new Milk[numOfMilk];
        }

      
    }
}
