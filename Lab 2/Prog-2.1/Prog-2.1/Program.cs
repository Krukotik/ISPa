using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Prog_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = Console.ReadLine();
            string[] words = d.Split(' ');
            Console.WriteLine("reversed:");
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
