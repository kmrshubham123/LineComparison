﻿using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Welcome to the Line Comparison Problem ####");

            LengthLine lengthLine = new LengthLine(); 
            lengthLine.FindLenght(1, 9, 1, 9);
            ///Equality Check of Two Line
            LineEquality equality = new LineEquality();
            equality.LineEquals();
        }
    }
}
