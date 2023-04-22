using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Prep2 World!");
        */
        /*
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();
        */
            /* Use "int.Parse" to convert string to int, use "{value-name}.ToString()" to convert to a string. 
        int x =  int.Parse(valueFromUser);
        int y = 2;
        
            /*
                || = or
                && = and
            

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x == y)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Greater");
        }
        */


            /*""" Write a program that will determine letter grades """*/

        /* Get input from the user */
        Console.Write("What is your grade percentage?: ");
        string percentage = Console.ReadLine();

        /* Convert input to an integer, I'm just doing this for practice using "int.Parse" */
        int grade = int.Parse(percentage);

        /* If statement to determine if the student passed. */
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time partner.");
        }

        /* Create the "letter" variable */
        string letter = "";

        /* If statement to determine letter grade */
        if (grade >= 90)
        {
            letter = ("A");
        }
        else if (grade <= 90 && grade >= 80)
        {
            letter = ("B");
        }
        else if (grade <= 80 && grade >= 70)
        {
            letter = ("C");
        }
        else if (grade <= 70 && grade >= 60)
        {
            letter = ("D");
        }
        else
        {
            letter = ("F");
        }

        Console.WriteLine($"{letter}");
    }
}