using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_My_Garden
{ enum EnumKindTree {Idle,fruit }
    class Tree:Plante
    {
        public EnumKindTree KindTree { get; set; }
        
        #region constracrot

        public Tree():base()
        {

        }

        public Tree(string name, EnumSeason season, int amoungWaterNeded, DateTime datePlanting, bool elked, EnumKindTree kindTree):base(name, season, amoungWaterNeded, datePlanting, elked)
        {
            KindTree = kindTree;
        }

        #endregion

        #region function 
        
        public new  void GetDetails()
        {
            base.GetDetails();

            Console.WriteLine("enter  1 - fruit ,2 -Idle :");
            int choise = int.Parse(Console.ReadLine());
            if(choise==1)
            KindTree = EnumKindTree.fruit;
            else
            KindTree = EnumKindTree.Idle;


        }

        public new void PrinDetails()
        {
            base.PrinDetails();
            Console.WriteLine("KindTree:" + KindTree);
           
        }

        public DateTime SetYearPlante(int n)
        {
          return  DatePlanting.AddYears(n);
        }
        public DateTime SetYearPlante()
        {
            return DatePlanting.AddYears(1);
        }
        public bool CanEat()
        {
            TimeSpan interval = DateTime.Now - DatePlanting;
            if (interval.CompareTo( 3))
                return true;
            return false;
                    
        }



        #endregion

  
    }
}
