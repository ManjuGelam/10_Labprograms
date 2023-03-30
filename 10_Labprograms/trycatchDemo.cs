using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Labprograms
{
    class trycatchDemo
    {
        static void Main()
        {
            try
            {
                Console.Write("enter first number:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("enter second number:");
                int z = x / y;
                Console.WriteLine("the result of division:" + z);

            }
            catch(DivideByZeroException)
            {
              Console.ForegroundColor=Console.Red;

            }
        }
    }
}
