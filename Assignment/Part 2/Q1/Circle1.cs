using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_2
{
    internal class Circle1 : ICircle
    {
        public double Radius { get; set; }
        private const double Pi = 3.14;
        //public Circle1(double radius)
        //{
        //    Radius = radius;
        //}
        public double Area { get { return Pi * Radius * Radius; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area Of Circle = {Area}");
        }
    }
}
