using System;
using System.Collections.Generic;
using System.Text;


public abstract class ListHealthy
{
    protected string DiseaseStage { get; set; }
    protected string Recommendation { get; set; }
    protected string Treatment { get; set; }
    protected string Disease { get; set; }
    
    public abstract void SetDiagnosis(string disease, string treatment, string disease_stage);

    public abstract void Plan();

    public abstract void InforamationPerson();
};
