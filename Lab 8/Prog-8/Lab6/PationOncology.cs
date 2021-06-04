using System;
using System.Collections.Generic;
using System.Text;

class OncologyPation : Person
{
        protected DateTime DataStartDisease { get; set; }
protected DateTime DataEndDisease { get; set; }

public OncologyPation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease)
        { }
public override void Plan(ConsoleKeyInfo k)
{
        if(k.Key == ConsoleKey.NumPad2)
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
    }
