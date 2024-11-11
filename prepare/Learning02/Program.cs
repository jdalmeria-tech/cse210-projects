using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Fullstack Developer";
        job2._startYear = 2019;
        job2._endYear = 2023;

        // job1.DisplayInfo();
        // job2.DisplayInfo();

        Resume myResume = new Resume();
        myResume._name = "Joseph Almeria";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayInfo();
    }
}