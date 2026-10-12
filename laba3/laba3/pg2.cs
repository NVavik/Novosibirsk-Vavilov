using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    internal class pg2
    {
        static void MainOld2(string[] args)
        {
            int n1 = 22;
            int n2 = 33;
            Console.WriteLine($"{n1} {n2}");
            Swap(ref n1, ref n2);
            Console.WriteLine($"{n1} {n2}");

        }
        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
}
