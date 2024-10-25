using System;
using Array;

class exercicio4
{

    static int Par_Impar(int[] vetor)
    {
        int impar = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 1)
            {
                impar++;
            }

        }

        return impar;
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

        Console.WriteLine($"\nFoi gerado {Par_Impar(meuVetor)} numeros impares");
    }

}

