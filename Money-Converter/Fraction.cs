using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Converter
{
    internal class Fraction
    {
        private readonly int num;
        private readonly int den;
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("afasgasgf.", nameof(denominator));
            }
            num = numerator;
            den = denominator;
        }
        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => a;
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        => new Fraction(a.num * b.num, a.den * b.den);
    }
}
