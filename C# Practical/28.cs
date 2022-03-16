using System;
namespace OOPBasics
{
    public class Properties
    {
        public class CSharp
        {
            public int roll;
            public string name;
            private string Result;

            public CSharp(int a, string b, string c)
            {
                roll = a;
                name = b;
                Result1 = c;
            }

            public string Result1
            {
                get
                {
                    return Result;
                }
                set
                {
                    if (value == "good" || value == "average" || value == "bad")
                    {
                        Result = value;
                    }
                    else
                    {
                        Result = "Not Valid";
                    }
                }
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Properties.CSharp c1 = new Properties.CSharp(1, "Xyz", "good");
            Properties.CSharp c2 = new Properties.CSharp(2, "Ijk", "5");
            Console.WriteLine(c1.roll + " " + c1.name + " " + c1.Result1);
            Console.WriteLine(c2.roll + " " + c2.name + " " + c2.Result1);
            Console.ReadLine();
        }
    }
}