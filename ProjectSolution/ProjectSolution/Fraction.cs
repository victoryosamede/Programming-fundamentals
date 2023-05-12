using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public decimal DecimalValue => (decimal)Numerator / Denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            Numerator = numerator;
            Denominator = denominator;
        }
        public static Fraction Parse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            string[] parts = input.Split('/');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid fraction format.");
            }

            if (!int.TryParse(parts[0], out int numerator) || !int.TryParse(parts[1], out int denominator))
            {
                throw new ArgumentException("Invalid fraction format.");
            }
            return new Fraction(numerator, denominator);
        }

    }
}
