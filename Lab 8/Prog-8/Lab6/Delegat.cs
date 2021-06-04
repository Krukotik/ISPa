using System;
using System.Collections.Generic;
using System.Text;

    class Delegat
    {
  
        public static void Representaion(Action<ConsoleKeyInfo> del)
        {
            bool b = true;
            ConsoleKeyInfo k = Console.ReadKey();
            Console.WriteLine("Press 1 if you want find out Information of pation. Press 2 if you want find out Plan");

            while (b)
            {
                
                try
                {
                    if (k.Key != ConsoleKey.NumPad1 && k.Key != ConsoleKey.NumPad2)
                        throw new Exception();
                    b = false;
                }
                catch
                {
                    Console.WriteLine("Pls iput correct");
                    k = Console.ReadKey();
                }
            }
            
            while(k.Key != ConsoleKey.Escape)
            {
                del?.Invoke(k);
                Console.WriteLine("Do you end? Press esc if yes");
                k = Console.ReadKey();
            }
        }

        public static void DelegatDisplay(Person p)
        {
            Action<ConsoleKeyInfo> nowdelegat = p.InforamationPerson;
            nowdelegat += (ConsoleKeyInfo k) => p.Plan(k);
            Representaion(nowdelegat);
        }
       
    }

