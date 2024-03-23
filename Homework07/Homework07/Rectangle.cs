using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07
{
    internal class Rectangle : Shape
    {


        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(string name, string color, int[] position, int sideA, int sideB)
            : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea() => Console.WriteLine("The area of the rectangle is: " + (SideA));
    }
}
