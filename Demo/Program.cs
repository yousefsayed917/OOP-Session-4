using Demo.Abstraction;
using Demo.Operator_Overloading;
using Demo.Static_And_Constants;
using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading
            //Complex c1 = new Complex() { Real = 10, Imag = 20 };
            //Complex c2 = new Complex() { Real = 17, Imag = 27 };
            //Complex c3;
            #region Binary Operator (+ , -)
            //Complex c3 = c1 + c2;
            //Console.WriteLine(c3.ToString());
            //Complex c4 = c3 + c2 - c1;
            //Console.WriteLine(c4.ToString());
            #endregion
            #region Unary Operator (++ , --)
            // c3 = ++c1; //Prefix
            //Console.WriteLine(c3.ToString());
            // c3 = c1++; //Postfix
            //Console.WriteLine(c3.ToString());
            // c3 = --c1; //Prefix
            //Console.WriteLine(c3.ToString());
            // c3 = c1--; //Postfix
            //Console.WriteLine(c3.ToString());
            #endregion
            #region Relational Operator (< , >)
            //if (c1 > c2)
            //    Console.WriteLine("c1 is Max");
            //else
            //    Console.WriteLine("c2 is Max");
            //if (c1 < c2)
            //    Console.WriteLine("c1 is Min");
            //else
            //    Console.WriteLine("c2 is Min");
            #endregion
            #region Casting operator
            //int y = (int)c1; //Explicit Casting Using Overloading (recommended)
            //Console.WriteLine(y);
            //object obj = " yousef ";//Non -Boxing because both is reference type
            //string s=(string)c2;//Implicit casting 
            //Console.WriteLine(s);
            #endregion
            #region  Business Need For Casting Operator
            ////Manual Mapping
            //User user = new User()
            //{ Id = 11, FullName = "yousef sayed", Email = "yousef@gmail.com", Password = "1234", SecurityStmp = Guid.NewGuid() };
            //UserViewModel userViewModel= (UserViewModel)user;
            //Console.WriteLine(userViewModel.ToString());
            #endregion
            #endregion
            #region Abstraction
            //Rect rectangle = new Rect()
            //{ Dim1 = 3, Dim2 = 4 };
            //decimal RectArea = rectangle.CalcArea();
            //Console.WriteLine($"Rectangle Area = {RectArea}");
            //decimal RectPerimeter = rectangle.Perimeter ;
            //Console.WriteLine($"Rectangle Perimeter = {RectPerimeter}");
            //Circle circle = new Circle(3);
            //decimal CircleArea = circle.CalcArea();
            //decimal Circleperimeter = circle.Perimeter;
            //Console.WriteLine(CircleArea);
            //Console.WriteLine(Circleperimeter);
            #endregion
            #region Static - Constants
            Utility utility = new Utility(1, 2);// Not Used
            Console.WriteLine(Utility.CmToInch(254));
            #endregion

        }
    }
}
