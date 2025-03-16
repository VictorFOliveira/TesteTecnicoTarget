using System;

class Program
{
    static void Main(string[] args)
    {
        int indice = 13,
            soma = 0,
            k = 0;

        while (k < indice)
        {
            k += 1;
            soma += k;
        }

        Console.WriteLine(soma);  // O resultado é 91
    }
}
