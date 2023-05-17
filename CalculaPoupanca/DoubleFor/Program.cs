for (int countRows = 0; countRows < 10; countRows++)
{
    for (int countColumns = 0; countColumns < 10; countColumns++)
    {
        Console.Write("*");

        if (countColumns >= countRows)
            break;
    }

    Console.WriteLine();
}