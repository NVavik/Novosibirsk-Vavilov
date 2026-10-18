using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    internal class pg2_1
    {
        static void MainOld3(string[] args)
        {
            int[] mas = {1, 2, 3, 4, 5};
            Console.WriteLine(string.Join(" ", mas));
            Reverse(mas);
            Console.WriteLine(string.Join(" ", mas));
        }
        public static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
    }
}
