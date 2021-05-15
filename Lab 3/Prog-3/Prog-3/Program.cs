using System;

namespace Prog_3
{
    class Person
    {
        protected string gender { get; set; }
        protected int id { get; set; }
        protected int age { get; set; }
        protected string name { get; set; }
        protected int weight { get; set; }
        protected string weight_diagnosis { get; set; }
        protected int height { get; set; }

        string[] arr_fit = new string[7] { "nothing", "nothing", "nothing", "nothing", "nothing", "nothing", "nothing" };

        public Person(string gender, int age, string name, int weight, int height, int id)
        {
            this.gender = gender;
            this.age = age;
            this.name = name;
            this.weight = weight;
            this.height = height;
            this.id = id;
        }

        public static int Create_ID()
        {
            Random rand = new Random();

            int id = rand.Next(1000, 9999);
            return id;
        }

        public int CalcualtorWeight()
        {
            int index_weight = weight / (height * height);
            return index_weight;
        }
        public int CalculatorWeight(int weight, int height)
        {
            double height_d = (double)height / 100;
            double index_weight_d = (double)weight / (height_d * height_d);
            int index_weight = (int)index_weight_d;
            Console.WriteLine(index_weight);
            return index_weight;
        }

        public void Sleep()
        {
            for (int i = 0; i < 7; i++)
            {
                if (arr_fit[i] == "train")
                    Console.WriteLine("In " + i + "day you shoud sleep 10 hour for refuse your power");
                if (arr_fit[i] == "hollyday")
                    Console.WriteLine("In " + i + "day you shoud sleep 8 hour for refuse your power");
            }
        }
        public void InformationTrain()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Today : " + arr_fit[i]);
            }
        }

        public void InforamationPerson()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight : " + weight);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("ID : " + id);
        }

        public string Diagnosis(int index_weight)
        {
            string result_diagnosis = "normal";
            if (index_weight < 18.5)
                result_diagnosis = "low_normal";
            if (index_weight >= 18.5 && index_weight < 25)
                result_diagnosis = "normal";
            if (index_weight >= 25 && index_weight < 30)
                result_diagnosis = "obesity";
            if (index_weight >= 30 && index_weight < 35)
                result_diagnosis = "obesity1";
            if (index_weight >= 35 && index_weight < 40)
                result_diagnosis = "obesity2";
            if (index_weight >= 40)
                result_diagnosis = "obesity3";
            weight_diagnosis = result_diagnosis;
            return result_diagnosis;
        }

        public void Plan(string diagnosis)
        {
            if (diagnosis == "low_normal")
            {
                Console.WriteLine("You have a low weight. Eat a more meet high-calorie foods and visite a doctar");
            }
            if (diagnosis == "normal")
            {
                Console.WriteLine("You have a normal weight.");
            }
            if (diagnosis == "obesity")
            {
                Console.WriteLine("You have a obesity. Recomendation star a active life");
            }
            if (diagnosis == "obesity1")
            {
                Console.WriteLine("You have a obesity1. Recomendation star a active life and visite a doctar");
            }
            if (diagnosis == "obesity2")
            {
                Console.WriteLine("You have a obesity2. Recomendation visite a doctar");
            }
            if (diagnosis == "obesity3")
            {
                Console.WriteLine("You have a obesity3. Recomendation? I realy don't know bro. May be stop a breath. Also call advise a doctar");
            }
        }
        public string this[int index]
        {
            get
            {
                if (arr_fit[index] != "nothing")
                    return arr_fit[index];
                else
                    return null;
            }

            set
            {
                arr_fit[index] = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 18)
                    age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int id_person = Person.Create_ID();
            string your_gender, your_name, your_age_s, your_height_s, your_weight_s;
            int your_age, your_height, your_weight;

            Console.WriteLine("Input your gender : ");
            your_gender = Console.ReadLine();
            while (your_gender != "man" && your_gender != "woman")
                your_gender = Console.ReadLine();
            Console.WriteLine("Input your name : ");
            your_name = Console.ReadLine();
            Console.WriteLine("Input your age");
            your_age_s = Console.ReadLine();
            while (!Int32.TryParse(your_age_s, out your_age))
                your_age_s = Console.ReadLine();
            Console.WriteLine("Input your height");
            your_height_s = Console.ReadLine();
            while (!Int32.TryParse(your_height_s, out your_height))
                your_height_s = Console.ReadLine();
            Console.WriteLine("Input your weight");
            your_weight_s = Console.ReadLine();
            while (!Int32.TryParse(your_weight_s, out your_weight))
                your_weight_s = Console.ReadLine();

            Person human = new Person(your_gender, your_age, your_name, your_weight, your_height, id_person);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("What is your palne on " + i + "day?");
                human[i] = Console.ReadLine();
            }

            human.CalcualtorWeight();
            human.Plan(human.Diagnosis(human.CalculatorWeight(72, 185)));
            human.Sleep();
            human.InformationTrain();
            human.InforamationPerson();
        }
    }
}