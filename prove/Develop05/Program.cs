using System;
// https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
// https://csharp-station.com/
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();

        Console.WriteLine("Thank you for using Eternal Quest. Goodbye!");
    }
}