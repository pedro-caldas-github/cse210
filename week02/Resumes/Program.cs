using System;

class Program
{
    
    static void Main(string[] args)
    {
        Job job1 = new();
        Job job2 = new();
        job1._jobTitle = "Software Developer";
        job2._jobTitle = "Senior Software Developer";
        job1._company = "Tech Solutions";
        job2._company = "Innovative Apps";
        job1._startYear = 2018;
        job1._endYear = 2020;
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume._name = "José Pedro";

        myResume.DisplayResume();
    }
}