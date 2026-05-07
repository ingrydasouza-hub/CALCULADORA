using System;

class Program
{
    static void Main()
    {
        // Solicita o primeiro número
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        // Solicita o segundo número
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        // Calcula a soma
        int resultado = num1 + num2;

        // Exibe o resultado
        Console.WriteLine("Resultado: " + resultado);
    }
}
