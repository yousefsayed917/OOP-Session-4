using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public Complex()
        {

        }
        public override string ToString()
        {
            return $"Real : {Real} , Imag : {Imag}";
        }
        #region Operator Overloading
        //Must Be Non Private - Class Member Method
        #region Binary Operator (+ , -)
        public static Complex operator + (Complex left , Complex right)
        {
            return new Complex
            {
                Real=(left?.Real??0)+(right?.Real??0),
                Imag=(left?.Imag??0)+(right?.Imag??0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }
        #endregion
        #region Unary Operator (++ , --)
        public static Complex operator ++(Complex complex)
        {
            return new Complex 
            { Real=(complex?.Real??0)+1, Imag = (complex?.Imag??0)+1 };
        }
        public static Complex operator --(Complex complex)
        {
            return new Complex
            { Real = (complex?.Real ?? 0) - 1, Imag = (complex?.Imag ?? 0) - 1 };
        }
        #endregion
        #region Relational Operator (< , >)
        public static bool operator >(Complex left , Complex right)
        {
            if (left.Real == right.Real)
                return left?.Imag > right?.Imag;
            else
                return left?.Real > right?.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left?.Imag < right?.Imag;
            else
                return left?.Real < right?.Real;
        }

        #endregion
        #region Casting operator
        public static explicit operator int (Complex complex)
        {
            return complex?.Real ?? 0;
        }
        public static implicit operator string(Complex complex)
        {
            return complex?.ToString()?? string.Empty;
        }
        #endregion
        #endregion

    }
}
