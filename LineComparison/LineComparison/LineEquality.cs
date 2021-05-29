using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class LineEquality
    {
        double LineOne, LineTwo;
        LengthLine LineOneLength = new LengthLine();
        public void LineEquals()
        {
            LineOne = LineOneLength.FindLenght(1, 9, 15, 9);
            LineTwo = LineOneLength.FindLenght(8, 5, 8, 9);

            if (LineTwo == LineOne)
            {
                Console.WriteLine("Both the Lines are Equal");
            }
            else if (LineTwo>LineOne)
            {
                Console.WriteLine("Lines Two is greater");
            }
            else
            {
                Console.WriteLine("Lines Two is Lesser");
            }
        }

    }
}
