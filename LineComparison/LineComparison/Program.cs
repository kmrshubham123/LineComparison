using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Welcome to the Line Comparison Problem ####");

            LengthLine lengthLine = new LengthLine(); 
            double LineOne=lengthLine.FindLenght(3,4,6,9);
            double LineTwo=lengthLine.FindLenght(7,8,5,10);

            //Equals
            Boolean Check_equality = LineOne.Equals(LineTwo);
            if (Check_equality == true)
            {
                Console.WriteLine("Lines are Equal in length");
            }
            else
            {
                Console.WriteLine("Lines are Not Equal");
            }
            /// Equal Greater less than
            if (LineOne == LineTwo)
            {
                Console.WriteLine("Both lines are same");
            }
            else if (LineOne>LineTwo)
            {
                Console.WriteLine("Line one is Greater Than Line Two");
            }
            else
            {
                Console.WriteLine("Line one is Lesser Than Line Two");
            }


        }
    }
}
