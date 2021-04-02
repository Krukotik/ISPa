using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Prog_2._3
{
    class Program
    {
        static int getrandomnumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 9);
            return number;
        }
        static char getrandomletter()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 26);
            char latter = (char)('a' + number);
            return latter;
        }
        static void Main(string[] args)
        {
            char[] str = new char[256];
            for (int i = 0; i < 256; i++)
            {
                str[i] = getrandomletter();
            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write(str[getrandomnumber()]);
                Console.Write(" ");
            }
        }
    }
}


