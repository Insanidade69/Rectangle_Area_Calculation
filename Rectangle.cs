using System;
using System.Globalization;

namespace Rectangle_Area_Calculator
{
    class Rectangle
    {
        public double A;
        public double B;

        public double Area()
        {
            return A * B;
        }
        public double Perimeter()
        {
            return 2 * (A + B);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
        public override string ToString()
        {
            return "Area is equals: " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerimeter is equals: " + Perimeter().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal is equals: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
