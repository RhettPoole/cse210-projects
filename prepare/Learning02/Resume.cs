using System;

public class Resume
{
    public string _name;

    // Initializing list to a new list before using it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Use of the custom data type "Job" in a "foreach" loop.
        foreach (Job job in _jobs)
        {
            // This calls the display method on each job
            job.Display();
        }
    }
}