using System;

class Program
{
    static bool EPerfeito(int numero)
    {
        if (numero <= 1)
            return false;

        int sd = 1;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                sd += i;

                if (i != numero / i)
                {
                    sd += numero / i;
                }
            }
        }

        return sd == numero;
    }

    static void Main()
    {
        Console.Write("Digite um número para verificar se é perfeito: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (EPerfeito(numero))
        {
            Console.WriteLine($"{numero} é um número perfeito.");
        }
        else
        {
            Console.WriteLine($"{numero} não é um número perfeito.");
        }
    }
}
//Feito por Bernardo Meneguzzi dos Santos e Arthur Andrade
