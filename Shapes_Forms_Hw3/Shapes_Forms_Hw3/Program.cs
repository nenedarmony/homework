using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Forms_Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangel trangle = new Triangel();
            trangle.getShape();
            trangle.printShape();

            Rectangel rectangl = new Rectangel();
            rectangl.getShape();
            rectangl.printShape();

            Console.ReadLine();

        }
    }
}
