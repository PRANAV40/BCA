using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A.B test = new A.B();
            test.C();
        }
    }
}

namespace A
{
    public class B
    {
        public void C()
        {
            Console.WriteLine("Hi");
            Console.ReadLine();
        }
    }
}