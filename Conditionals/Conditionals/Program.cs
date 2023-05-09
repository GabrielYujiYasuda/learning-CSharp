double age;

Console.WriteLine("What is your age?");
//Need to convert the input to integer.
age = Convert.ToInt32(Console.ReadLine());

if (age >= 21)
{
    Console.WriteLine("Fine!!!");
} else if (age < 21 && age >= 0)
{
    Console.WriteLine("You cannot enter!");
} else
{
    Console.WriteLine("Some kind of error");
}