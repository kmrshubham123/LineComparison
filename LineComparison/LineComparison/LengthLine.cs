using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public abstract class LengthLine
    {
        public abstract double FindLength(int x1, int x2, int y1, int y2);
    }
    public class CalculateLenght : LengthLine
    {
        public override double FindLength(int x1, int x2, int y1, int y2)
        {
            double Distance;
            Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length is: " + Distance);
            return Distance;
        }
    }
}   
