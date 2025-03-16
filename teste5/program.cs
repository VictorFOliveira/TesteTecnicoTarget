using System;

class Program
{
    static void Main(string[] args)
    {
        string frase = "uma frase como exemplos";

        string frase_invertida = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
            frase_invertida += frase[i];
        }

        Console.WriteLine(frase_invertida);
    }
}
