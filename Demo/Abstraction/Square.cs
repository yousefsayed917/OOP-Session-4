using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Square : Base
    {
        public Square(decimal Dim) :base(Dim,Dim)
        {
            Dim1 = Dim2 = Dim;
        
        }
        public override decimal Perimeter
        {
            get { return Dim1 * 4; }
        }

        
    }
}
