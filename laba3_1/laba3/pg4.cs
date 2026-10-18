using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace laba3
{
    internal class pg4
    {
        static void Main(string[] args)
        {
            int[] mas = { -99, -53, 45, 95, 5, 7, 88, 94, 84, 33, 11, 66 };
            int[] evenmas = Filter(mas, IsEven);
            int[] posmas = Filter(mas, IsPositive);
            int[] fifmas = Filter(mas, IsFif);
            Console.WriteLine("Исходный:");
            Console.WriteLine(string.Join(" ", mas));
            Console.WriteLine("Formatted:");
            Console.WriteLine(string.Join(" ", evenmas));
            Console.WriteLine(string.Join(" ", posmas));
            Console.WriteLine(string.Join(" ", fifmas));
        }
        public delegate bool FilterCondition(int number);
        public static int[] Filter(int[] sourceArray, FilterCondition condition)
        {
            int[] mas1 = new int[sourceArray.Length];
            int j = 0;
            foreach (int el in sourceArray)
            {
                if (condition(el))
                {
                    mas1[j] = el;
                    j++;
                }
            }
            int[] mas2 = new int[j];
            for (int i = 0; i < j; i++)
            {
                mas2[i] = mas1[i];
            }
            return mas2;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPositive(int n)
        {
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsFif(int n) {
            int orig = n;
            int rev = 0;
            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            if (orig == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
