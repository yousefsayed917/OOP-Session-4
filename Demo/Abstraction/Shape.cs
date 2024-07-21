using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    //Abstract Class : Is A Class Contains Partial Implementation to Another Class
    //u Can Not Create Object [Instance] From Abstract Class
    //Because It Is Not Fully Impemented Class
    abstract class Shape
    {
        public Shape(decimal dim1,decimal dim2)
        {
            Dim1 = dim1;
            Dim2 = dim2;
        }
        public decimal Dim1 {  get; set; }
        public decimal Dim2 {  get; set; }
        public abstract decimal Perimeter {  get; }

        public abstract decimal CalcArea();
        
    }
}
