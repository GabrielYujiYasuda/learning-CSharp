using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LONG TERM INVESTING!");

        double juros = 1.005;
        double investimento = 1000;

        for (int ano = 1; ano <= 5; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= juros;
            }

            juros += 0.001;
        }

        Console.WriteLine("Seu total foi: R${0:0.0}", investimento);
    }
}