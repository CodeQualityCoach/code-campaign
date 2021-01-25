using System;

namespace Campaign_01
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public static Fraction Parse(string val)
        {
            var parts = val.Split("/");

            if (!int.TryParse(parts[0], out var num))
                throw new InvalidCastException("given numerator is not an integer");
            if (!int.TryParse(parts[1], out var denom))
                throw new InvalidCastException("given denominator is not an integer");
            
            return new Fraction(num, denom);
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new DivideByZeroException("Denominator in a fraction cannot be zero.");
            
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(
                a.Numerator * b.Numerator,
                a.Denominator * b.Denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(
                (a.Numerator * b.Denominator)+(b.Numerator * a.Denominator),
                a.Denominator * b.Denominator);
        }
    }
}
