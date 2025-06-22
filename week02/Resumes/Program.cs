using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs = new List<Job>();
        // Adding jobs to the resume
        myResume._jobs.Add(new Job { _company = "Google", _jobTitle = "Software Engineer", _startYear = 2015, _endYear = 2020 });
        myResume._jobs.Add(new Job { _company = "Microsoft", _jobTitle = "Systems Analyst", _startYear = 2020, _endYear = 2023 });

        myResume.DisplayResume();
    }
}