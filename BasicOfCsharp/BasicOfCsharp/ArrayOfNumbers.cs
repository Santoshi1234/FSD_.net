using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfCsharp
{
    class ArrayOfNumbers
    {
        int[] array = { 20, 10, 40, 60, 70, 80 };

        public void Do()
        {
            foreach(int num in array)
            {
                Console.WriteLine(num);
                Console.Write(" ");


            }
        }

    }
}
