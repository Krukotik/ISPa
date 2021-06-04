using System;
using System.Collections.Generic;
using System.Text;

class PsychotherapiyPation : Person
{
    protected DateTime DataStartDisease { get; set; }
    protected DateTime DataEndDisease { get; set; }

    protected string[] days_treatment = new string[7] { "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing" };
    public PsychotherapiyPation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
    : base(gender, age, name, weight, height, id, list_disease)
    { }
    public override void Plan(ConsoleKeyInfo k)
    {
        if(k.Key == ConsoleKey.NumPad2)
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
            Console.WriteLine("Disease start : " + DataStartDisease);
            Console.WriteLine("Disease end : " + DataEndDisease);
        }
       
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
