using System;
using System.Runtime.InteropServices;

namespace Lab4_2
{
    static class Task
    {
        [DllImport("C:\\Users\\Jarvis\\source\\repos\\ISP\\Lab4_2\\Dll1\\Debug\\Dll1.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Fibanachi(int count);

        [DllImport("C:\\Users\\Jarvis\\source\\repos\\ISP\\Lab4_2\\Dll1\\Debug\\Dll1.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Factorial(int fact);
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number a , b , c");
            int a, b, c;
            string a_s = Console.ReadLine();
            while(!Int32.TryParse(a_s, out a))
                a_s = Console.ReadLine();
            string b_s = Console.ReadLine();
            while (!Int32.TryParse(b_s, out b))
                b_s = Console.ReadLine();
            string c_s = Console.ReadLine();
            while (!Int32.TryParse(c_s, out c))
                c_s = Console.ReadLine();

            int answer = (Task.Factorial(a) * Task.Fibanachi(a) + Task.Fibanachi(c) - Task.Factorial(b)) / 2;

            Console.WriteLine($"Your answer is {answer}");

        }
    }
}
