using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Forms_Hw3
{
    class Triangel:Shape
    {
        public Double TriangleHeight{ get; set; }
        public int NumOfEdges { get; set; }

        #region constractor
        public Triangel():base()
        {
        }

        public Triangel(string nameShape, string colorShape, double triangleHeight, int numOfEdges):base( nameShape,  colorShape)
        {
            TriangleHeight = triangleHeight;
            NumOfEdges = numOfEdges;
        }

        public Triangel(Triangel t) : base(t.NameShape, t.ColorShape)
        {
            TriangleHeight = t.TriangleHeight;
            NumOfEdges = t.NumOfEdges;
        }
        #endregion

        #region function
        public void getShape()
        {
            base.getShape();
            Console.WriteLine("enter the Triangle Height :");
            TriangleHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the Num Of Edges :");
            NumOfEdges = int.Parse(Console.ReadLine());


        }
        public void printShape()
        {
            base.printShape();
            Console.WriteLine("Triangle Height:" + TriangleHeight);
            Console.WriteLine("  Num Of Edges :" + NumOfEdges);
           
        }
        #endregion

    }
}
