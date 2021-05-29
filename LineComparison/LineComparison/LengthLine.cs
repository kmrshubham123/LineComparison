using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class LengthLine
    {
        double Distance;
        public double FindLenght(int x1, int x2, int y1, int y2)
        {
            Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length is:-" +Distance);
            return Distance;
        }
    }
}
