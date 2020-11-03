using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_My_Garden
{
    enum EnumSeason {spring,autumn,winter,summer }
    class Plante
    {
        #region prop/f

        private readonly string planteId;
        public string PlanteId  {   get { return planteId; }  }
        public string Name { get; set; }
        public EnumSeason Season { get; set; }
        public int AmoungWaterNeded { get; set; }
        public DateTime DatePlanting { get; set; }
        public bool Elked { get; set; }

        #endregion

        #region constractor

        public Plante()
        {

        }

        public Plante(string name, EnumSeason season, int amoungWaterNeded, DateTime datePlanting, bool elked)
        {
            Name = name;
            Season = season;
            AmoungWaterNeded = amoungWaterNeded;
            DatePlanting = datePlanting;
            Elked = elked;
        }

        #endregion

        #region function
        
        public TimeSpan AgePlante()
        {
            return DateTime.Now - DatePlanting;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine("enter  name :");
            Name = Console.ReadLine();
            Console.WriteLine("enter AmoungWaterNeded :");
            AmoungWaterNeded = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Date Planting :");
            DatePlanting = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter Elked :");
            Elked = bool.Parse(Console.ReadLine());

        }

        public virtual void PrinDetails()
        {
            Console.WriteLine("planteId" + PlanteId);
            Console.WriteLine("  name :" + Name);
            Console.WriteLine(" AmoungWaterNeded :"+ AmoungWaterNeded);
            Console.WriteLine("Season:"+ Season);
            Console.WriteLine(" Date Planting :"+ DatePlanting);
            Console.WriteLine(" Elked :"+ Elked);
        }


        #endregion
    }
}
