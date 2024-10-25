using Array;
using System;

class exercicio6
{
    static int procura(int[] vetor, int num)
    {
        int qtd = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == num)
            {
                Console.WriteLine($"\n\nO numero aparece na posição {i}");
                qtd++;
            }
        }
        return qtd;

    }
    static void Main()
    {
        int n, qtd = 0, num;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];

        Console.WriteLine("Digite um numero: ");
        num = int.Parse(Console.ReadLine());

        BibliotecaArray.geraVetor(meuVetor);
        Console.WriteLine("Vetor gerado:");
        BibliotecaArray.mostrarVetor(meuVetor);

        qtd = procura(meuVetor, num);

        Console.WriteLine($"\n\nO numero informado aparece {qtd}x");
    }
}


