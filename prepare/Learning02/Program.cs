using System;
//Clayton Redding
//02-21-2023
//Brother Comeau
//CSE210
class Program
{
    static void Main(string[] args)
    {
        //First instance of Job Class
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.DisplayJobDetails();

        Console.WriteLine();

        //Second instance of Job class
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Data Analyst";
        job2._startYear = 2014;
        job2._endYear = 2018;
        job2.DisplayJobDetails();

        Console.WriteLine();

        //Instance of Resume
        Resume resume1 = new Resume();
        resume1._name = "Clayton Redding";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();

    }
}