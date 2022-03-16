using System;

namespace OOPs
{
    public class Abstraction
    {
        abstract class Cs
        {
            public abstract void Fun();
        }

        private class Good : Cs
        {
            public override void Fun()
            {
                Console.WriteLine("C# is Good");
            }
        }

        private class Best : Cs
        {
            public override void Fun()
            {
                Console.WriteLine("C# is Best");
            }
        }

        private class Better : Cs
        {
            public override void Fun()
            {
                Console.WriteLine("C# is Better");
            }
        }

        public class MyClass
        {
            public static void Main()
            {
                Cs c;
                c = new Good();
                c.Fun();
                c = new Best();
                c.Fun();
                c = new Better();
                c.Fun();
                Console.ReadLine();
            }
        }
    }
}