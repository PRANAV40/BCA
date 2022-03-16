using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3,4 };
            try
            {
                Console.WriteLine(myNumbers[5]);
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                Console.ReadLine();
            }
        }
    }
}