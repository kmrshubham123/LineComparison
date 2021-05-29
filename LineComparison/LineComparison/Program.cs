using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Welcome to the Line Comparison Problem ####");

            LengthLine lengthLine = new LengthLine(); 
            lengthLine.FindLenght(2, 20, 2, 20);
        }
    }
}
