using System;
using System.Threading;
using Hospital;

namespace Hospital
{
    public class Person
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

        public virtual void InforamationPerson()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("ID : " + Id);
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

        public virtual void Plan()
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
}
namespace Type
{
    abstract class ListHealthy : Person
    {
        protected string DiseaseStage { get; set; }
        protected string Recommendation { get; set; }
        protected string Treatment { get; set; }
        protected string Disease { get; set; }
        public ListHealthy(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease) { }
        public abstract void SetDiagnosis(string disease, string treatment, string disease_stage);
    };
    class InfectedPation : ListHealthy
    {
        protected DateTime DataStartQuarantine { get; set; }
        protected DateTime DataEndQuarantine { get; set; }
        protected string OwnDiabed { get; set; }
        protected double BloodSugar1 { get; set; }

        protected double BloodSugar2 { get; set; }
        public InfectedPation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease)
        { }
        public override void Plan()
        {
            if (DiseaseStage == "easy")
            {
                Recommendation = "Person don't need be in the hospital";
                Console.WriteLine(Recommendation);
            }
            if (DiseaseStage == "hard medium")
            {
                Recommendation = "Person shoud be in the hospital";
                Console.WriteLine(Recommendation);
            }
            if (DiseaseStage == "hard stage")
            {
                Recommendation = "Person must be in the hospital";
                Console.WriteLine(Recommendation);
            }
        }

        public override void SetDiagnosis(string disease, string treatment, string disease_stage)
        {
            this.Disease = disease;
            this.Treatment = treatment;
            this.DiseaseStage = disease_stage;
        }
        public override void InforamationPerson()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Treatment : " + Treatment);
            Console.WriteLine("Disease : " + Disease);
            Console.WriteLine("Disease stage : " + DiseaseStage);
            Console.WriteLine("Own diabed : " + OwnDiabed);
        }

        public void AnalizeBlood(double blood_sugar1, double blood_sugar2)
        {
            this.BloodSugar1 = blood_sugar1;
            this.BloodSugar2 = blood_sugar2;
            if ((blood_sugar1 > 72 && blood_sugar1 < 106) && (blood_sugar2 < 7.8))
            {
                OwnDiabed = "Absent";
            }
            if ((blood_sugar1 > 90 && blood_sugar1 < 126) && (blood_sugar2 > 90 && blood_sugar2 < 162))
            {
                OwnDiabed = "Diabets 1 type";
            }
            if ((blood_sugar1 > 90 && blood_sugar1 < 126) && (blood_sugar2 > 90 && blood_sugar2 < 153))
            {
                OwnDiabed = "Diabets 2 type";
            }
        }
        public void SetQuarantine(int year, int mounth, int day, string stage)
        {
            if (stage == "start")
                DataStartQuarantine = new DateTime(year, mounth, day);
            if (stage == "end")
                DataEndQuarantine = new DateTime(year, mounth, day);
        }
    }

    class OncologyPation : ListHealthy
    {
        protected DateTime DataStartDisease { get; set; }
        protected DateTime DataEndDisease { get; set; }

        public OncologyPation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease)
        { }
        public override void Plan()
        {
            if (DiseaseStage == "easy")
            {
                Recommendation = "Surgical treatment - includes complete or partial removal of the tumor, as well as the collection of its tissue for histological examination.";
                Console.WriteLine(Recommendation);
            }
            if (DiseaseStage == "hard medium")
            {
                Recommendation = "Radiation therapy is performed to reduce the size of a malignant neoplasm or prevent recurrence after surgery. " +
                    "This is a targeted tumor removal that does not require surgical intervention - a directed stream of ionizing radiation" +
                    " reaches the tumor through intact skin.";
                Console.WriteLine(Recommendation);
            }
            if (DiseaseStage == "hard stage")
            {
                Recommendation = "Chemotherapy - includes the appointment of drugs that block the multiplication of cancer cells. " +
                    "Unfortunately, in addition to this, chemotherapy drugs also affect healthy tissue.";
                Console.WriteLine(Recommendation);
            }
        }

        public override void SetDiagnosis(string disease, string treatment, string disease_stage)
        {
            this.Disease = disease;
            this.Treatment = treatment;
            this.DiseaseStage = disease_stage;
        }
        public override void InforamationPerson()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Treatment : " + Treatment);
            Console.WriteLine("Disease : " + Disease);
            Console.WriteLine("Disease stage : " + DiseaseStage);
            Console.WriteLine("Disease start : " + DataStartDisease);
            Console.WriteLine("Disease end : " + DataEndDisease);
        }

        public void SetStarEndDisease(int year, int mounth, int day, string stage)
        {
            if (stage == "start")
                DataStartDisease = new DateTime(year, mounth, day);
            if (stage == "end")
                DataEndDisease = new DateTime(year, mounth, day);
        }
    }

    class PsychotherapiyPation : ListHealthy
    {
        protected DateTime DataStartDisease { get; set; }
        protected DateTime DataEndDisease { get; set; }

        protected string[] days_treatment = new string[7] { "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing" };
        public PsychotherapiyPation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease)
        { }
        public override void Plan()
        {
            if (DiseaseStage == "easy")
            {
                Recommendation = "Person don't need be antidepressants";
                Console.WriteLine(Recommendation);
            }
            if (DiseaseStage == "hard medium")
            {
                Recommendation = "Person may use some antidepressants";
                Console.WriteLine(Recommendation);
            }
            if (DiseaseStage == "hard stage")
            {
                Recommendation = "Person must use antidepressants for care about himself healthy";
                Console.WriteLine(Recommendation);
            }
        }

        public override void SetDiagnosis(string disease, string treatment, string disease_stage)
        {
            this.Disease = disease;
            this.Treatment = treatment;
            this.DiseaseStage = disease_stage;
        }
        public override void InforamationPerson()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Treatment : " + Treatment);
            Console.WriteLine("Disease : " + Disease);
            Console.WriteLine("Disease stage : " + DiseaseStage);
            Console.WriteLine("Disease start : " + DataStartDisease);
            Console.WriteLine("Disease end : " + DataEndDisease);
        }

        public void SetStarEndDisease(int year, int mounth, int day, string stage)
        {
            if (stage == "start")
                DataStartDisease = new DateTime(year, mounth, day);
            if (stage == "end")
                DataEndDisease = new DateTime(year, mounth, day);
        }

        public string this[int index]
        {
            get
            {
                if (days_treatment[index] == "Nothing")
                    return days_treatment[index];
                else
                    return null;
            }
            set
            {
                days_treatment[index] = value;
            }
        }


    }
}
namespace Lab5
{

    class Hospital
    {
        public static void Print(string disease, string treatment, string disease_stage, Type.ListHealthy pation)
        {
            if (pation is Type.PsychotherapiyPation)
            {
                Console.WriteLine("Pation of psychotherapiy");
                pation.SetDiagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();
            }
            if (pation is Type.OncologyPation)
            {
                Console.WriteLine("Pation of oncology");
                pation.SetDiagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();
            }
            if (pation is Type.InfectedPation)
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
            int age, heigth, weigth, id;

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

            heigths = Console.ReadLine();
            while (!Int32.TryParse(heigths, out heigth))
                heigths = Console.ReadLine();

            weigths = Console.ReadLine();
            while (!Int32.TryParse(weigths, out weigth))
                weigths = Console.ReadLine();

            ids = Console.ReadLine();
            while (!Int32.TryParse(ids, out id))
                ids = Console.ReadLine();

            Type.InfectedPation firstpation = new Type.InfectedPation(gender, age, name, heigth, weigth, id);

            Console.WriteLine("Input result bloods:");
            string str = Console.ReadLine();
            while (!double.TryParse(str, out bloodsugar1))
                str = Console.ReadLine();
            string str2 = Console.ReadLine();
            while (!double.TryParse(str, out bloodsugar2))
                str = Console.ReadLine();

            firstpation.AnalizeBlood(bloodsugar1, bloodsugar2);

            Type.OncologyPation secondpation = new Type.OncologyPation("Woman", 19, "Rose", 50, 170, 0001, "remisson");

            secondpation.SetStarEndDisease(2020, 6, 4, "start");
            secondpation.SetStarEndDisease(2021, 12, 2, "end");

            Console.WriteLine("Input your training treatment:");
            Type.PsychotherapiyPation thirdpation = new Type.PsychotherapiyPation("Woman", 20, "Scarlet", 56, 170, 0002);
            for (int i = 0; i < 7; i++)
            {
                thirdpation[i] = Console.ReadLine();
            }

            Print("good", "nothing", "easy", firstpation);
            Print("good", "nothing", "easy", secondpation);
            Print("good", "nothing", "easy", thirdpation);
        }
    }
}
