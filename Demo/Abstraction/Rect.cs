using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    //Concrete Class Fully Impelemented Class
    internal class Rect : Base
    {
        public Rect(decimal dim1, decimal dim2) : base(dim1, dim2)
        {
        }

        public override decimal Perimeter
        { get { return (Dim1 + Dim2) * 2m; } }

       
    }
}
