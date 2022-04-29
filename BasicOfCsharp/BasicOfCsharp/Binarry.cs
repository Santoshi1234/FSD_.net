using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    //T(n)= o(logn)
    static class BinarySearch
    {
        static int[] array = { 4, 17, 20, 16, 18, 21, 645, 780 };

        public static void Do()
        {
            int result;
            result = binarySearch(array, 0, array.Length - 1, 645);
            Console.WriteLine("ELement at index" + result);
            result = binarySearch(array, 0, array.Length - 1, 648);
            Console.WriteLine("ELement at index" + result);
        }


        public static int binarySearch(int[] array, int left, int right, int num)
        {
            if (right >= left)
            {
                //Step 1: FInd the Mid element
                int mid = (right + left) / 2;

                //Step2 : check if Mid is the element /Num

                if (array[mid] == num)
                {
                    return mid;
                }

                //step 3: check if the num is less then Mid
                if (num < array[mid])
                {
                    return binarySearch(array, left, mid - 1, num);
                }
                else
                {
                    return binarySearch(array, mid + 1, right, num);

                }
                return -1;

            }
        }
    }
}
