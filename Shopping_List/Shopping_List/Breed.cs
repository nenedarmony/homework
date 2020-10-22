using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
   
    class Breed
    { 
        #region prop

         public static int howMuchBreed { get; set; }
         public bool IsTherFiler { get; set; }
         public string Color { get; set; }
         private Double price ;
         public Double Price
        {
            get { return price ; }
            set { if(value<=3) 
                price  = value; 
            else
                    Console.WriteLine("the price is too hight choose another bread");
                price = 0; 
            }
       

        }

        #endregion 

        #region constractors

         public Breed()=> howMuchBreed++;

           public Breed(bool isTherFiler,string color , Double price ):this()//שולחים לקונ הריק כדי שיעשה את הפעולה  וכך אין כפילות קוד 
          {
               IsTherFiler = isTherFiler;
               Color = color;
               Price = price;
          }

          public Breed(Breed bread ):this()//העתקה עמוקה 
           { 
            bread= new Breed();
            IsTherFiler = bread.IsTherFiler;
            Color = bread.Color;
            Price = bread.price;
            }
        }

      #endregion

    #region function

    public void Printbreed()
    {
        Console.WriteLine("the color of the bred is : "+Color);
        
    }

    #endregion
    }


