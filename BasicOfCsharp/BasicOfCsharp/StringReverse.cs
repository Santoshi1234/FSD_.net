using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfCsharp
{
    class StringReverse
    {
        public void Do()
        {

            Console.WriteLine("Please enter a String to reverse");
            String input = Console.ReadLine();

            //String is collection of character.
            //for (initialization;condtion;increment/decrement)
            //Mumbai ==>iabmuM ==>6 (0 - 5)
            //STrat reading from last index/char
            //Store/append it in a seperate  String
            //decrement Index position

            String result = String.Empty;
            for (int i = input.Length - 1; i > 0; i--)
            {
                result = result + input[i];//i, ia, iab, iabm , iabmu , iabmuM

            }
            Console.WriteLine(result);

        }
    }
}
