using System;
using System.Collections.Generic;
using System.Text;


    class InfectedPation : Person
    {
        protected DateTime DataStartQuarantine { get; set; }
        protected DateTime DataEndQuarantine { get; set; }
        protected string OwnDiabed { get; set; }
        protected double BloodSugar1 { get; set; }

        protected double BloodSugar2 { get; set; }
        public InfectedPation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease)
        { }
        public override void Plan(ConsoleKeyInfo k)
        {
            if(k.Key == ConsoleKey.NumPad2)
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
        }

        public override void SetDiagnosis(string disease, string treatment, string disease_stage)
        {
            this.Disease = disease;
            this.Treatment = treatment;
            this.DiseaseStage = disease_stage;
        }
        public override void InforamationPerson(ConsoleKeyInfo k)
        {
            if(k.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("Name : " + Name + ";" + "Age : " + Age + ";" + "Weight : " + Weight + ";" + "Height : " + Height + ";" + "ID : " + Id);
                Console.WriteLine("Treatment : " + Treatment);
                Console.WriteLine("Disease : " + Disease);
                Console.WriteLine("Disease stage : " + DiseaseStage);
                Console.WriteLine("Own diabed : " + OwnDiabed);
            }
           
        }

    
    public void AnalizeBlood(double blood_sugar1, double blood_sugar2)
        {
            this.BloodSugar1 = blood_sugar1;
            this.BloodSugar2 = blood_sugar2;
            if ((blood_sugar1 > 72 && blood_sugar1 < 106) && (blood_sugar2 < 78))
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

