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
            LineOne = LineOneLength.FindLenght(8, 9, 8, 9);
            LineTwo = LineOneLength.FindLenght(8, 9, 8, 9);

            if (LineTwo == LineOne)
            {
                Console.WriteLine("Both the Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }

    }
}
