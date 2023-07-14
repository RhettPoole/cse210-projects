using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();  // Create a list to store activities

        DateTime date1 = new DateTime(2022, 11, 3);
        Running runningActivity = new Running(date1, 30, 3.0);  // Create a running activity
        activities.Add(runningActivity);  // Add the running activity to the list of activities

        DateTime date2 = new DateTime(2022, 11, 3);
        StationaryBicycle bicycleActivity = new StationaryBicycle(date2, 30, 10.0);  // Create a stationary bicycle activity
        activities.Add(bicycleActivity);  // Add the stationary bicycle activity to the list of activities

        DateTime date3 = new DateTime(2022, 11, 3);
        Swimming swimmingActivity = new Swimming(date3, 30, 20);  // Create a swimming activity
        activities.Add(swimmingActivity);  // Add the swimming activity to the list of activities

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();  // Generate a summary for each activity
            Console.WriteLine(summary);  // Print the summary to the console
        }
    }
}
