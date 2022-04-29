using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfCsharp
{
    class EvenOdd
    {
        public void Do()
        {
            Console.WriteLine("Please enter a number to find if it is odd or even");
            bool keepRunning = true;

            //While (<expression>=true/false)
            while (keepRunning)
            {
                //How to read from command line
                String input = Console.ReadLine();

                //How to convert from one datatype to another dt
                int Value = Convert.ToInt32(input);
                if(Value == 0)
                {
                    keepRunning = false;
                    break;
                }

                //check if odd or even
                if (Value % 2 == 0)
                {
                    Console.WriteLine("This is Even");
                }
                else
                {
                    Console.WriteLine("This is odd");
                }

            }

        }
    }
}
