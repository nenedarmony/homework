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

        public Breed[] breed { get; set; } //הגדרנו מערך
        public Milk[] milk { get; set; } //הגדרנו מערך

        public ShoppingList(string listName, DateTime dateList)
        {
            ListName = listName;
            DateList = dateList;
        }

        public ShoppingList(int numOfBreed, int numOfMilk)
        {

            for (int i = 0; i < numOfBreed; i++)
            {
                ShoppingList.Breed[i] = new Breed();
            }
           

        }
    }
}
