 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static_And_Constants
{
    internal class Utility
    {
       // private const Pi= 3.14;
        public int X { get; set; }
        public int Y { get; set; }

        private  static double pi;
        //Class Member Property 
        //get and set {Static Attribute - Constant}
        public  static double Pi
        {
            set { pi = value; }
            get { return pi; }
        }
        public Utility(int x, int y)
        {
            X = x;
            Y = y;
        }
        //static constructor only one in class
        //can not Specify access modifier or parameters
        //will be Executed only one time per class before the first usage of the class
        //1- call static method or static property
        //2- create object from this class
        //create object from another class inheriting from this class
         static Utility()
        {
            Pi = 3.14;
        }
        public override string ToString()
        {
            return $"X : {X}, Y : {Y}";
        }
        //Class Member Method 
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }public static double CalcArea(double r)
        {
            return Pi * r * r;
        }
    }
}
