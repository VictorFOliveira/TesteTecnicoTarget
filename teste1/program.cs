using System;

class Program
{
    static void Main()
    {
        int indice = 13,
            SOMA = 0,
            K = 0;

        while (K < indice)
        {
            K += 1;
            SOMA += K;
        }

        Console.WriteLine(SOMA); // O resultado é 91
    }
}
