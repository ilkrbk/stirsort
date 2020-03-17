using System;
using System.Collections.Generic;

namespace StirSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() {8, 1, 3, 5, 2, 7, 9};
            for (var i = 0; i < array.Count / 2; i++)
            {
                bool swapFlag = false;
                int temp;
                // в условии < по убыванию
                //           > по возростанию
                for (var j = i; j < array.Count - i - 1; j++)
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        swapFlag = true;
                    }
                for (var j = array.Count - i - 1; j > i; j--)
                    if (array[j - 1] < array[j])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        swapFlag = true;
                    }
                if (!swapFlag)
                    break;
            }

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}