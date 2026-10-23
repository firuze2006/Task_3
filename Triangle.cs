
using System;

class Triangle : IShape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public double CalculatePerimeter()
    {
        return A + B + C;
    }
}
