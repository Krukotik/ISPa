using System;
using System.Collections.Generic;
using System.Text;


    public class Person : ListHealthy, IComparable<Person>, IPlan
    {
        protected string Gender { get; set; }
        protected int Id { get; set; }
        protected int Age { get; set; }
        protected string Name { get; set; }
        protected int Weight { get; set; }
        protected int IndexWeight { get; set; }
        protected string WeightDiagnosis { get; set; }
        protected int Height { get; set; }

        protected string ListDisease = "Healthy";

        string[] arrfit = new string[7] { "nothing", "nothing", "nothing", "nothing", "nothing", "nothing", "nothing" };

        public Person(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        {
            this.Gender = gender;
            this.Age = age;
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Id = id;
            this.ListDisease = "Healthy";
        }

        public override void SetDiagnosis(string disease, string treatment, string disease_stage) { }

        public static int Create_ID()
        {
            Random rand = new Random();

            int id = rand.Next(1000, 9999);
            return id;
        }

        public int CalcualtorWeight()
        {
            IndexWeight = Weight / (Height * Height);
            return IndexWeight;
        }
        public virtual int CalculatorWeight(int weight, int height)
        {
            double height_d = (double)height / 100;
            double index_weight_d = (double)weight / (height_d * height_d);
            int index_weight = (int)index_weight_d;
            Console.WriteLine(index_weight);
            return index_weight;
        }

        public void TestCovid()
        {
            Console.WriteLine("10.04.2021 : New accident(727219), Average(7), Days(628035)");
        }
    
        public void TimePressure(int counter)
        {
            int press = counter * 2;
            if (press > 60 && press < 80)
               Console.WriteLine("Normal press");
            if (press < 60)
                Console.WriteLine("Press is low");
            if (press > 80)
                Console.WriteLine("Press is higher");
        }
        

        public void Sleep()
        {
            for (int i = 0; i < 7; i++)
            {
                if (arrfit[i] == "train")
                    Console.WriteLine("In " + i + "day you shoud sleep 10 hour for refuse your power");
                if (arrfit[i] == "hollyday")
                    Console.WriteLine("In " + i + "day you shoud sleep 8 hour for refuse your power");
            }
        }
        public void InformationTrain()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Today : " + arrfit[i]);
            }
        }

        public override void InforamationPerson()
        {
            Console.WriteLine("Name : " + Name + ";" + "Age : " + Age  + ";" + "Weight : " + Weight + ";" + "Height : " + Height + ";" + "ID : " + Id);
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
            WeightDiagnosis = result_diagnosis;
            return result_diagnosis;
        }

        public override  void Plan()
        {
            if (WeightDiagnosis == "low_normal")
            {
                Console.WriteLine("You have a low weight. Eat a more meet high-calorie foods and visite a doctar");
            }
            if (WeightDiagnosis == "normal")
            {
                Console.WriteLine("You have a normal weight.");
            }
            if (WeightDiagnosis == "obesity")
            {
                Console.WriteLine("You have a obesity. Recomendation star a active life");
            }
            if (WeightDiagnosis == "obesity1")
            {
                Console.WriteLine("You have a obesity1. Recomendation star a active life and visite a doctar");
            }
            if (WeightDiagnosis == "obesity2")
            {
                Console.WriteLine("You have a obesity2. Recomendation visite a doctar");
            }
            if (WeightDiagnosis == "obesity3")
            {
                Console.WriteLine("You have a obesity3. Recomendation? I realy don't know bro. May be stop a breath. Also call advise a doctar");
            }
        }

        public int CompareTo(Person o)
        {
            if (this == null && o == null)
                return 0;
            if ((this.Name[0] > o.Name[0]) && (this.Name[0] >= 65 && this.Name[0] <= 90) && (o.Name[0] >= 65 && o.Name[0] <= 90))
                return 1;
            if ((this.Name[0] < o.Name[0]) && (this.Name[0] >= 65 && this.Name[0] <= 90) && (o.Name[0] >= 65 && o.Name[0] <= 90))
                return -1;
            if (this == o)
                return 0;
            if ((this == null && o != null) && (this.Name[0] >= 65 && this.Name[0] <= 90) && (o.Name[0] >= 65 && o.Name[0] <= 90))
                return 1;
            if (this != null && o == null)
                return -1;
            return 0;
        }

        
        public string this[int index]
        {
            get
            {
                if (arrfit[index] != "nothing")
                    return arrfit[index];
                else
                    return null;
            }

            set
            {
                arrfit[index] = value;
            }
        }

        public string Pol
        {
            get
            {
                return Gender;
            }

            set
            {
                Gender = value;
            }
        }

        public int Year
        {
            get
            {
                return Age;
            }

            set
            {
                if (value >= 18)
                    Age = value;
            }
        }
    }

