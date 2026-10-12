using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace laba3
{
    internal class pg2_2
    {
        static void MainOld4(string[] args)
        {
            int[] mas = {1, 2, 3, 4, 5};
            int[] mas2 = Reverse(mas);
            Console.WriteLine(string.Join(" ", mas));
            Console.WriteLine(string.Join(" ", mas2));
        }
        public static int[] Reverse(int[] array)
        {
            int[] mas2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++) { 
                mas2[i] = array[array.Length - i - 1];
            }
            return mas2;
        }
    }
}
