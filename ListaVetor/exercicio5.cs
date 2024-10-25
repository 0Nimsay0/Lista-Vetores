
using System;
using Array;

class exercicio5
{
    static void Main()
    {
        
        Console.WriteLine("Digite quantas bases da fita de DNA vai inserir: ");
        int qtd =  int.Parse(Console.ReadLine());
        char[] dna = new char[qtd];
        for (int i = 0; i < dna.Length; i++)
        {
            Console.Write($"{i}:");
            dna[i] = char.Parse(Console.ReadLine());
        }
        char[] dna2 = new char[qtd];
        for (int i = 0; i < dna.Length; i++)
        {
            if (dna[i] == 't')
            {
                dna2[i] = 'a';
            }
            else if (dna[i] == 'a')
            {
                dna2[i] = 't';
            }
            else if (dna[i] == 'c')
            {
                dna2[i] = 'g';
            }
            else if (dna[i] == 'g')
            {
                dna2[i] = 'c';
            }
        }
        Console.WriteLine("\n");
        BibliotecaArray.mostrarVetor(dna2);
        Console.WriteLine("\n");
    }
}
