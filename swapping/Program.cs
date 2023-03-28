using System;

namespace swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("veribles after swapping ");
           
            a = a + b; //30
            b = a - b; // 10
            a = a - b;

            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);

            Console.ReadLine();

           


        }
    }
}
