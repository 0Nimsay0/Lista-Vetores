using System;

namespace Array
{
    public class BibliotecaArray
    {
        public static void readArray(int[] vetor) // criando funçaõ para ler numeros
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void mostrarVetor(int[] vetor) // mostrando nuemros
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]}| ");

            }
        }

        public static void geraVetor(int[] vetor) //gera numeros
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        }

        public static void readArray(double[] vetor) // criando funçaõ para ler numeros
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]: ");
                vetor[i] = int.Parse(Console.ReadLine()) ;
            }
        }

        public static void mostrarVetor(double[] vetor) // mostrando nuemros
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]:F2}| ");

            }
        }

        public static void geraVetor(double[] vetor) //gera numeros
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100) + random.NextDouble();
            }
        }

        public static void mostrarVetor(char[] vetor) // mostrando nuemros
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]:F2}| ");

            }
        }
    }
}
