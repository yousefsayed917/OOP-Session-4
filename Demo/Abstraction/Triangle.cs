using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Triangle : Shape
    {
        public decimal Dim3 { get; set; }
        public Triangle(decimal dim1,decimal dim2 , decimal dim3):base(dim1,dim2)
        {
            Dim3 = dim3;
        }
        public override decimal Perimeter {  get { return Dim1 * 4; }  }

        public override decimal CalcArea()
        {
            return Dim1 * 4;
        }
    }
}
