using System;
using Array;

class exercicio3
{
    static double maiorVetor(double[] vetor)
    {
        double menor = vetor[0];
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
                menor = vetor[i];
        }
        return menor;
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

        Console.WriteLine($"\nMenor Numero = {maiorVetor(meuVetor):F2}");

    }
}


