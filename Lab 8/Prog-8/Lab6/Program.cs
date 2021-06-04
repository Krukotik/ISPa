using System;
using System.Collections.Generic;


namespace Lab6
{
    class Hospital
    {


        static void Main(string[] args)
        {

            ConsoleKeyInfo key;
            key = Console.ReadKey();
            InfectedPation firstpation = null;
            OncologyPation secondpation = null;
            PsychotherapiyPation thirdpation = null;

            while (key.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("What is type of pation? Input 1(infected pation), 2(oncology pation), 3(psychotherapiy pation)");
                int i;
                string st;
                st = Console.ReadLine();
                while (!Int32.TryParse(st, out i))
                    st = Console.ReadLine();
                if (i == 1)
                {
                    double bloodsugar1;
                    double bloodsugar2;
                    firstpation = new InfectedPation("Man", 22, "Pasha", 180, 184, 0000);
                    Console.WriteLine("Input result bloods:");
                    string str = Console.ReadLine();
                    while (!double.TryParse(str, out bloodsugar1))
                        str = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    while (!double.TryParse(str2, out bloodsugar2))
                        str2 = Console.ReadLine();
                    firstpation.AnalizeBlood(bloodsugar1, bloodsugar2);
                    firstpation.Print("bad", "cancer", "hard medium", firstpation);
                    Delegat.DelegatDisplay(firstpation);

                }
                if (i == 2)
                {
                    secondpation = new OncologyPation("Woman", 19, "Rose", 50, 170, 0001, "remisson");
                    secondpation.SetStarEndDisease(2020, 6, 4, "start");
                    secondpation.SetStarEndDisease(2021, 12, 2, "end");
                    secondpation.Print("bad", "cancer", "hard medium", secondpation);
                    Delegat.DelegatDisplay(secondpation);

                }
                if (i == 3)
                {
                    thirdpation = new PsychotherapiyPation("Woman", 20, "Scarlet", 56, 170, 0002);

                    Console.WriteLine("Input your training treatment:");

                    for (int a = 0; a < 7; a++)
                    {
                        thirdpation[a] = Console.ReadLine();
                    }
                    thirdpation.Print("bad", "cancer", "hard medium", thirdpation);
                    Delegat.DelegatDisplay(thirdpation);

                }

               

                if(secondpation != null && secondpation != null && thirdpation != null)
                {
                    List<Person> p = new List<Person>() { secondpation, firstpation, thirdpation };
                    p.Sort();
                    Console.WriteLine("Input 1 if you want see sort list");
                    ConsoleKeyInfo k = Console.ReadKey();
                    foreach (Person per in p)
                    {
                        per.InforamationPerson(k);
                    }
                }

                Console.WriteLine("Push Escape if you end");
                key = Console.ReadKey();
            }

        }
    }
}
