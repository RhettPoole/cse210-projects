using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        // Creating the first job.
        Job job1 = new Job();
        job1._company = "Bish's RV";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2023;

        // Creating the second job.
        Job job2 = new Job();
        job2._company = "Tesla";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2021;

        // Initialize the first resume.
        Resume myResume = new Resume();
        myResume._name = "Rhett Poole";

        // add the jobs into the list.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}