using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Forms_Hw3
{
    class Rectangel:Shape
    {
        public string RectangelKind { get; set; }
        public int With { get; set; }

        #region constractor
        public Rectangel() : base()
        {
        }

        public Rectangel(string nameShape, string colorShape, string rectangelKind, int with) : base(nameShape, colorShape)
        {
            RectangelKind = rectangelKind;
            With = with;
        }

        public Rectangel(Rectangel r) : base(r.NameShape, r.ColorShape)
        {
            RectangelKind = r.RectangelKind;
            With = r.With;
        }
        #endregion

        #region function
        public void getShape()
        {
            base.getShape();
            Console.WriteLine("enter the Triangle Height :");
            RectangelKind =Console.ReadLine();

            Console.WriteLine("enter the Num Of Edges :");
            With = int.Parse(Console.ReadLine());


        }
        public void printShape()
        {
            base.printShape();
            Console.WriteLine(" Rectangel Kind:" + RectangelKind);
            Console.WriteLine("  With :" + With);

        }
        #endregion
    }
}
