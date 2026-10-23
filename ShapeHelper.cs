
using System;

class ShapeHelper
{
    public static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double CalculateArea(double width, double height)
    {
        return width * height;
    }
}
