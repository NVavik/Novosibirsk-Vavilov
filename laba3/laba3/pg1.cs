using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace laba3
{
    internal class pg1
    {
        static void MainOld1(string[] args)
        {
            string intres = GetStats(1, 2, 3);
            string intres2 = GetStats(10, 20, 30, 40, 50);
            string doubleres = GetStats(1.1, 2.2, -5.5);
            Console.WriteLine(intres);
            Console.WriteLine(intres2);
            Console.WriteLine(doubleres);
        }
        public static string GetStats(params int[] numbers)
        {
            int res = 0;
            int mx = numbers[0];
            int mn = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                res += numbers[i];
                if (numbers[i] > mx)
                {
                    mx = numbers[i];
                }
                if (numbers[i] < mn)
                {
                    mn = numbers[i];
                }
            }
            int srzn = res / numbers.Length;
            return $"Кол-во: {numbers.Length};\nСумма: {res};\nСреднее: {srzn:F2};\nМакс: {mx};\nМин: {mn}";
        }
        public static string GetStats(params double[] numbers)
        {
            double res = 0.0;
            double mx = numbers[0];
            double mn = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                res += numbers[i];
                if (numbers[i] > mx)
                {
                    mx = numbers[i];
                }
                if (numbers[i] < mn)
                {
                    mn = numbers[i];
                }
            }
            double srzn = res / numbers.Length;
            return $"Кол-во: {numbers.Length};\nСумма: {res:F1};\nСреднее: {srzn:F2};\nМакс: {mx};\nМин: {mn}";
        }
    }
}
