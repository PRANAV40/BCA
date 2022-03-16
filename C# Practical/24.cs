using System;

namespace OOPs
{
    public class MethodOverriding
    {
        public class Cs
        {
            public virtual void Fun()
            {
                Console.WriteLine("B.Sc");
            }
        }

        public class MCA : Cs
        {
            public override void Fun()
            {
                Console.WriteLine("M.Sc");
            }
        }

        private class BCA : Cs
        {
            public override void Fun()
            {
                Console.WriteLine("B.Sc");
            }
        }

        public static void Main()
        {
            Cs c;
            c = new BCA();
            c.Fun();
            c = new MCA();
            c.Fun();
            Console.ReadLine();
        }
    }
}