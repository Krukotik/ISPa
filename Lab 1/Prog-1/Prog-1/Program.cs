using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_1
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            char again = 'y';
            Random rand = new Random();

            while (again == 'y')
            {

                int i = rand.Next(100);

                Console.WriteLine("Компьютер загадал число от 0 до 100");

                if (i < 50) Console.WriteLine("Число меньше 50");
                else Console.WriteLine("Число больше или равно 50");

                int x = Convert.ToInt32(Console.ReadLine());

                if (i == x) Console.WriteLine("Вы победили свою пекарню!");
                else Console.WriteLine("Вы проиграли,пекарня загадала число {0}", i);

                Console.WriteLine("Попробовать еще?(y = Да,n = Нет)");
                again = Convert.ToChar(Console.ReadLine());
              
            }

        }
    }
}

