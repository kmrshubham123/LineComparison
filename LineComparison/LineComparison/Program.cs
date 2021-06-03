using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Welcome to the Line Comparison Problem ####");
            LengthLine lengthLine = new LengthLine();
            double LineOne = lengthLine.FindLenght(3, 8, 9, 10);
            double LineTwo = lengthLine.FindLenght(3, 15, 15, 10);

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
            /// Equal greater Lesser
            if(LineOne==LineTwo)
            {
                Console.WriteLine("Both lines are same");
            }
            else if(LineOne>LineTwo)
            {
                Console.WriteLine("Line one is greater than Line Two");
            }
            else 
            {
                Console.WriteLine("Lines one is lesser than Line Two ");
            }


          



        }
    }
}
