using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Calcula Poupanca!");

        double investimento = 0;
        double juros = 0.005;
        int contador = 1;
        int qtdMeses;
        string mensagemMeses = "";

        Console.Write("Digite o valor que deseja investir: R$");
        investimento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por quantos meses desejas investir: ");
        qtdMeses = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        while (contador <= qtdMeses)
        {
            switch (contador)
            {
                case 1:
                    mensagemMeses = "janeiro";
                    break;
                case 2:
                    mensagemMeses = "fevereiro";
                    break;
                case 3:
                    mensagemMeses = "marco";
                    break;
                case 4:
                    mensagemMeses = "abril";
                    break;
                case 5:
                    mensagemMeses = "maio";
                    break;
                case 6:
                    mensagemMeses = "junho";
                    break;
                case 7:
                    mensagemMeses = "julho";
                    break;
                case 8:
                    mensagemMeses = "agosto";
                    break;
                case 9:
                    mensagemMeses = "setembro";
                    break;
                case 10:
                    mensagemMeses = "outubro";
                    break;
                case 11:
                    mensagemMeses = "novembro";
                    break;
                case 12:
                    mensagemMeses = "dezembro";
                    break;
            }

            investimento = investimento + (investimento * juros);

            Console.WriteLine("No mes de {0} voce estava com R${1:0.00}", mensagemMeses, investimento);
            // Console.WriteLine("No mês " + mensagemMeses + " você estava com R$" + investimento);

            contador++;
        }

        Console.WriteLine("\nSeu total é: {0:0.00}", investimento);
    }
}