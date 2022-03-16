using System;
namespace OOPs
{
    public class Inheritence
    {
        class MainClass
        {
            public void Print()
            {
                Console.WriteLine("Print");
            }
        }
        class Subclass : MainClass
        {
            void Print1()
            {
                Console.WriteLine("Print 2");
            }
            static void Main(string[] args)
            {
                Subclass s = new Subclass(); 
                                            
                s.Print();
                s.Print1();
                Console.ReadLine();
            }
        }
    }
}
