using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 4;

        if (NumeroPertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool NumeroPertenceFibonacci(int numero)
    {
        int a = 0, b = 1;

        if (numero == a || numero == b)
        {
            return true;
        }

        while (b < numero)
        {
            int temp = b;
            b = a + b;
            a = temp;

            if (b == numero)
            {
                return true;
            }
        }

        return false;
    }
}
