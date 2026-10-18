using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    internal class pg3
    {
        static void MainOld5(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            var rand = new Random();
            for (int i = 0; i < n; i++) arr[i] = rand.Next(5000);
            Console.WriteLine(string.Join("|", arr));
            Console.WriteLine("Введи число для поиска:");
            int fnd = int.Parse(Console.ReadLine());
            if (TryFind(arr, fnd, out int foundindex))
            {
                Console.WriteLine($"Найдено: индекс {foundindex}");
            }
            else {
                Console.WriteLine("Fatal Error: 0x80070490 - Элемент не найден");
            }
        }
        public static bool TryFind(int[] array, int value, out int index)
        {
            bool found = false;
            for (int i = 0;i < array.Length;i++) {
                if (array[i] == value)
                {
                    index = i;
                    return true;
                }
                
            }
            index = -1;
            return false;
        }
    }
}
