using System;

class Program
{
    static void Main(string[] args)
    {
         // Create addresses
        Address baseballAddress = new Address("4 Jersey St", "Boston", "Massachusetts", "United States of America");
        Address address2 = new Address("456 Elm St", "City 2", "State 2", "Country 2");
        Address address3 = new Address("789 Oak St", "City 3", "State 3", "Country 3");

        // Create events
        BaseballGame baseballGame = new BaseballGame("Baseball Game", "The Red Sox will be playing against the Yankees at Fenway Park on the date listed below.", "2023-08-17", "4:00 PM", baseballAddress, "Red Sox vs. Yankees", 37755);
        GeneralConference generalConference = new GeneralConference("General Conference - Latter Day Saints", "General conference is the worldwide gathering of The Church of Jesus Christ of Latter-day Saints. Twice a year, during the first weekend of April and the first weekend of October, Church leaders from around the world share messages or sermons focused on the living Christ and His gospel.", "2023-10-07", "10:00 AM", address2, "ticket-recipient@gmail.com");
        PoolParty poolParty = new PoolParty("Pool Party", "This is for a pool party that will be held at Cindy's house.", "2023-07-28", "12:00 PM", address3, "Sunny");

        // Generate marketing messages
        Console.WriteLine(baseballGame.GetStandardDetails());
        Console.WriteLine(baseballGame.GetFullDetails());
        Console.WriteLine(baseballGame.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(generalConference.GetStandardDetails());
        Console.WriteLine(generalConference.GetFullDetails());
        Console.WriteLine(generalConference.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(poolParty.GetStandardDetails());
        Console.WriteLine(poolParty.GetFullDetails());
        Console.WriteLine(poolParty.GetShortDescription());
    }
}