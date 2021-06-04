using System;
using System.Collections.Generic;


namespace Lab6
{
    class Hospital
    {
        public static void Print(string disease, string treatment, string disease_stage, ListHealthy pation)
        {
            if (pation is PsychotherapiyPation)
            {
                Console.WriteLine("Pation of psychotherapiy");
                pation.SetDiagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();
            }
            if (pation is OncologyPation)
            {
                Console.WriteLine("Pation of oncology");
                pation.SetDiagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();
            }
            if (pation is InfectedPation)
            {
                Console.WriteLine("Pation of infected");
                pation.SetDiagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();

            }
        }
        static void Main(string[] args)
        {

            double bloodsugar1;
            double bloodsugar2;
            string gender, name, ages, heigths, weigths, ids;
            int age, heigth, weigth, id, facke;

            Console.WriteLine("Input a gender, age, name, heigth, weigth, id: ");

            gender = Console.ReadLine();
            while ((gender != "man" && gender != "woman") && (gender != "Man" && gender != "woman"))
            {
                Console.WriteLine("Only man or waoman");
                gender = Console.ReadLine();
            }

            ages = Console.ReadLine();
            while (!Int32.TryParse(ages, out age))
                ages = Console.ReadLine();

            name = Console.ReadLine();
            while (Int32.TryParse(name, out facke))
            {
                Console.WriteLine("Input only word");
                name = Console.ReadLine();
            }
            heigths = Console.ReadLine();
            while (!Int32.TryParse(heigths, out heigth))
                heigths = Console.ReadLine();

            weigths = Console.ReadLine();
            while (!Int32.TryParse(weigths, out weigth))
                weigths = Console.ReadLine();

            ids = Console.ReadLine();
            while (!Int32.TryParse(ids, out id))
                ids = Console.ReadLine();

            InfectedPation firstpation = new InfectedPation(gender, age, name, heigth, weigth, id);

            Console.WriteLine("Input result bloods:");
            string str = Console.ReadLine();
            while (!double.TryParse(str, out bloodsugar1))
                str = Console.ReadLine();
            string str2 = Console.ReadLine();
            while (!double.TryParse(str, out bloodsugar2))
                str = Console.ReadLine();

            firstpation.AnalizeBlood(bloodsugar1, bloodsugar2);

            OncologyPation secondpation = new OncologyPation("Woman", 19, "Rose", 50, 170, 0001, "remisson");

            secondpation.SetStarEndDisease(2020, 6, 4, "start");
            secondpation.SetStarEndDisease(2021, 12, 2, "end");

            Console.WriteLine("Input your training treatment:");
            PsychotherapiyPation thirdpation = new PsychotherapiyPation("Woman", 20, "Scarlet", 56, 170, 0002);
            for (int i = 0; i < 7; i++)
            {
                thirdpation[i] = Console.ReadLine();
            }

            Print("good", "nothing", "easy", firstpation);
            Print("good", "nothing", "easy", secondpation);
            Print("good", "nothing", "easy", thirdpation);

            List<Person> p = new List<Person>() { secondpation, firstpation, thirdpation };
            p.Sort();
            foreach(Person per in p)
            {
               per.InforamationPerson();
            }
        }
    }
}
