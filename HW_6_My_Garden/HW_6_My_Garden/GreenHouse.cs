using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_My_Garden
{
    enum EnumFrequency {everyHauer,everyDay,everyWeek }
    class GreenHouse:Flower
    {
        public string GreenHouseName{ get; set; }
        public int LineNumber { get; set; }
        public int PotNumber { get; set; }
        public EnumFrequency Supervition  { get; set; }

        #region constractor

        public GreenHouse():base()
        {

        }

        public GreenHouse(string greenHouseName, int lineNumber, int potNumber, EnumFrequency supervition, string name, EnumSeason season, int amoungWaterNeded, DateTime datePlanting, bool elked, ConsoleColor flowerColor):base(name, season, amoungWaterNeded, datePlanting, elked, flowerColor)
        {
            GreenHouseName = greenHouseName;
            LineNumber = lineNumber;
            PotNumber = potNumber;
            Supervition = supervition;
        }


        #endregion

        public   void  PlantNextOther(GreenHouse f)
        {
           if(PlantFluwerNextOther(f)==true && this.GreenHouseName==f.GreenHouseName && this.Supervition==f.Supervition )
                Console.WriteLine("you can plant ");
           else
                Console.WriteLine("you cant plant ");

        }
    }
}
