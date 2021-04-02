using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Prog_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            Console.WriteLine("Cторона правильного треугольника = {0}", a);            
            double r = Math.Sqrt(3.0) / 6.0 * a;
            Console.WriteLine("Радиус вписанной окружности = {0}", r);           
            double R = Math.Sqrt(3.0) / 3.0 * a;
            Console.WriteLine("Радиус описанной  окружности = {0}", R);           
            double P = 3.0 * a;
            Console.WriteLine("Периметр правильного треугольника = {0}", P);
            double h = Math.Sqrt(3.0) / 2.0 * a;
            Console.WriteLine("Высота правильного треугольника = {0}", h); 
            double S = Math.Sqrt(3.0) / 4.0 * a * a;
            Console.WriteLine("Площадь правильного треугольника = {0}", S);
        }
    }
}

