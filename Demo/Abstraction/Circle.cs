using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(decimal radius,decimal dim1, decimal dim2) :base(dim1,dim2)
        { Dim1 = Dim2 = radius; }
        public override decimal Perimeter
        {
            get { return 2 * 3.14m * Dim1; }
        }

        public override decimal CalcArea()
        {
            return 3.14m * Dim2 * Dim1;
        }
    }
}
