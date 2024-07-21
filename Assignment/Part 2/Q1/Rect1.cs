using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_2
{
    internal class Rect1 : IRectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Area { get { return Width * Length; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area Of Rectangle = {Area}");
        }
    }
}
