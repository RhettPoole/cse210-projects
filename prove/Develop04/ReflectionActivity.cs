using System;
using System.Collections.Generic;
using System.Threading;

/// Sources: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
/// Sources: https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0 
/// Sources: https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0

public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions; // List to store random questions

    public ReflectionActivity(string name, string description, int durationInSeconds)
        : base(name, description, durationInSeconds)
    {
        questions = new List<string>(GetRandomQuestions());
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Take a moment to reflect...");
        Console.WriteLine("Press any key to start answering questions.");

        Console.ReadKey();
        Console.Clear();

        AskQuestions();

        DisplayEndingMessage();
    }
    
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    private string[] GetRandomQuestions()
    {
        string[] allQuestions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        List<string> randomQuestions = new List<string>(allQuestions);

        // Shuffle the questions randomly.
        for (int i = 0; i < allQuestions.Length - 1; i++)
        {
            int randomIndex = random.Next(i, allQuestions.Length);
            string temp = randomQuestions[i];
            randomQuestions[i] = randomQuestions[randomIndex];
            randomQuestions[randomIndex] = temp;
        }

        return randomQuestions.ToArray();
    }

    private void AskQuestions()
    {
        int questionCounter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Loop until the time runs out or all questions are asked.
        while (DateTime.Now < endTime && questions.Count > 0)
        {
            string question = questions[0];
            questions.RemoveAt(0);

            Console.WriteLine($"{questionCounter + 1}. {question}");
            Console.WriteLine("Take a moment to think...");
            CountdownTimer(3); // Pause for a few seconds

            // Get user's response or continue to the next question
            Console.WriteLine("Press Enter to continue to the next question.");
            Console.ReadLine();
            Console.Clear();

            questionCounter++;
        }
    }

    private void CountdownTimer(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r{i} second{(i > 1 ? "s" : "")} remaining...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
