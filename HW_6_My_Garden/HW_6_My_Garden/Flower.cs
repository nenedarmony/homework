using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_My_Garden
{
    class Flower:Plante
       
    {
        public ConsoleColor FlowerColor { get; set; }

        #region constracrot

        public Flower():base()
        {

        }

        public Flower(string name, EnumSeason season, int amoungWaterNeded, DateTime datePlanting, bool elked, ConsoleColor flowerColor) : base(name, season, amoungWaterNeded, datePlanting, elked)
        {
            FlowerColor = flowerColor;
        }

        #endregion

        #region function 

        public new void GetDetails()
        {
            base.GetDetails();

            
            int position;
            Console.Write("Please enter a numeric  ");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((ConsoleColor)position);




        }

        public new void PrinDetails()
        {
            base.PrinDetails();
            Console.WriteLine("Flower Color:" + FlowerColor);

        }

        public bool PlantFluwerNextOther(Flower f)
        {
            if (this.Season == f.Season && this.AmoungWaterNeded == f.AmoungWaterNeded)
                return true;
                return false;

        }

    

        #endregion

    }
}
