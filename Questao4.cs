using System;

class Program
{
    static void Main()
    {
        Console.Write("Dite um numero: ");
        string entrada = Console.ReadLine();
        if (int.TryParse(entrada, out int numero))
        {
            Console.WriteLine(numero);
        }
        else
        {
            Console.WriteLine("Erro");
        }
    }
}
