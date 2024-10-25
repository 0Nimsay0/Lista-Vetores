using System;
using Array;
class exercicio8
{
    static void Main()
    {
        int n;
        Console.WriteLine("Quantos caracter?");
        n = int.Parse(Console.ReadLine());

        char[] meuVetor = new char[n];
        Console.WriteLine("\nDigite os caracter");

        for (int i = 0; i < meuVetor.Length; i++)
        {
            meuVetor[i] = Console.ReadKey().KeyChar;
        }

        Console.WriteLine("\n\nOrdem Inversa\n");
        for (int i = meuVetor.Length - 1; i >= 0; i--)
        {
            Console.Write(meuVetor[i] + " ");
        }
        Console.WriteLine("\n");
        Console.ReadKey();

    }
}
