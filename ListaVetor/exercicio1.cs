using System;
using Array;

class exercicio1
{
    static int somaVetor(int[] vetor)
    {
        int soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma;

    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];

        BibliotecaArray.geraVetor(meuVetor);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostrarVetor(meuVetor);

        Console.WriteLine($"\n\nSoma = {somaVetor(meuVetor)}");

    }
}
