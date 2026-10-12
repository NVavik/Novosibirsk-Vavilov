namespace laba3
{
    internal class Program
    {
        static void MainOld(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Max = {Max2(n1, n2)}, Min = {Min2(n1, n2)}");
        }
        static int Max2(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int Min2(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
