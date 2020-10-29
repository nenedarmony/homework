using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Forms_Hw3
{
    class Shape
    {
        public string NameShape { get; set; }
        public string ColorShape { get; set; }
        private int MyProperty { get; set; }

        #region constractor
        public Shape()
        {
        }

        public Shape(Shape s)
        {
            NameShape = s.NameShape;
            ColorShape = s.ColorShape;
            MyProperty = s.MyProperty;

        }

        public Shape(string nameShape, string colorShape)
        {
            this.NameShape = nameShape;
            this.ColorShape = colorShape;
           
        }


        #endregion

        #region functions
        public void getShape()
        {
            Console.WriteLine("enter the name of the shape:");
            NameShape = Console.ReadLine();

            Console.WriteLine("enter the color of the shape:");
            ColorShape = Console.ReadLine();

            Console.WriteLine("enter the number of the shape:");
            MyProperty = int.Parse(Console.ReadLine());


        }
        public void printShape()
        {
            Console.WriteLine(" the name of the shape is :"+NameShape);
            Console.WriteLine(" the color of the shape is :" + ColorShape);
            Console.WriteLine(" the num of the shape is :" + MyProperty);
        }
        #endregion


    }
}
