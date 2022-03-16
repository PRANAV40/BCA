using System;

namespace OOPs
{
    public class MethodOverloading
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }

        public static void Main()
        {
            int sum1 = Sum(54, 74);
            double sum2 = Sum(34.84, 65.16);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.ReadLine();
        }
    }
}