using System;
using Array;

class exercicio7
{
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor1 = new int[n];
        int[] meuVetor2 = new int[n];
        int[] meuVetor3 = new int[n];

        BibliotecaArray.geraVetor(meuVetor1);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostrarVetor(meuVetor1);
        Console.WriteLine("\n");
        BibliotecaArray.geraVetor(meuVetor2);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostrarVetor(meuVetor2);
        Console.WriteLine("\n\nResultado da Multiplicação \n");

        for (int i = 0; i < meuVetor1.Length; i++)
        {
            meuVetor3[i] = meuVetor1[i] * meuVetor2[i];
            Console.Write($"{meuVetor3[i]}|");
        }
        Console.WriteLine("\n");
    }
}

