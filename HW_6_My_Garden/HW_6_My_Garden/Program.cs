using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_My_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Plante p = new Plante();
            p.GetDetails();
            p.PrinDetails();
            p.AgePlante();

            Tree t = new Tree();
            t.GetDetails();
            t.PrinDetails();
            t.SetYearPlante();
            t.SetYearPlante(3);
            t.CanEat();

            Flower f1 = new Flower();
            f1.GetDetails();
           
            Flower f = new Flower();
            f.GetDetails();
            f.PrinDetails();
           f.PlantFluwerNextOther(f1);

            GreenHouse g1 = new GreenHouse();
            GreenHouse g = new GreenHouse();
            g.GetDetails();
            g.PrinDetails();
            g.PlantFluwerNextOther(g1);
        }
    }
}
