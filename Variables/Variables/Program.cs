using System;

class Program
{
    static void Main(string[] args)
    {
        string closingMessage = "Press enter to close!";
        int age = 32;

        Console.WriteLine("Minha idade é: " + age);

        Console.WriteLine(closingMessage);
        Console.ReadLine();
    }
}