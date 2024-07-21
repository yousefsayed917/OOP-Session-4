using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    abstract class Base : Shape
    {
        protected Base(decimal dim1, decimal dim2) : base(dim1, dim2)
        {
        }

        public override decimal CalcArea()
        {
            return Dim1 * Dim2;
        }
    }
}
