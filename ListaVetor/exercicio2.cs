using System;
using Array;

class exercicio2
{
    static double maiorVetor(double[] vetor)
    {
        double maior = vetor[0];
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
                maior = vetor[i];
        }
        return maior;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        double[] meuVetor = new double[n];

        BibliotecaArray.geraVetor(meuVetor);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostrarVetor(meuVetor);

        Console.WriteLine($"\nMaior Numero = {maiorVetor(meuVetor):F2}");

    }
}

