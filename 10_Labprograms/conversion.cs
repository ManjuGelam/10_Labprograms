using System;
using System.Globalization;

namespace _10_Labprograms
{
    class conversion
    {
        static int hex2dec(string hexnum)
        {
            int decnum = 0;
            decnum = int.Parse(hexnum,NumberStyles.HexNumber);
            return decnum;
        }
        static void Main(string[] args)
        {
            string hexnum = "";
            int decnum = 0;
            Console.WriteLine("enter a hexadecimal number:");
            hexnum = hex2dec(hexnum);
            Console.WriteLine("decimal number:" + decnum);
            Console.ReadLine();
          
        }

        
    }
}
