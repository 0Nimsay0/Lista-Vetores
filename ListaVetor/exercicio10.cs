using System;
using Array;
class exercicio10
{
    static void Main()
    {
        int n, f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0;
        Console.WriteLine("Quantas vezes vai tacar o dado? ");
        n = int.Parse(Console.ReadLine());
        int[] meuvetor = new int[n];

        for (int i = 0; i < meuvetor.Length; i++)
        {
            Console.WriteLine("Registe os Valores: ");
            meuvetor[i] = int.Parse(Console.ReadLine());
            if (meuvetor[i] > 6 || meuvetor[i] < 0)
            {
                Console.WriteLine("Numero Invalido");
                i--;
            }

        }

        for (int i = 0; i < meuvetor.Length; i++)
        {
            switch (meuvetor[i])
            {
                case 1:
                    f1++;
                    break;
                case 2:
                    f2++;
                    break;
                case 3:
                    f3++;
                    break;
                case 4:
                    f4++;
                    break;
                case 5:
                    f5++;
                    break;
                case 6:
                    f6++;
                    break;

            }
        }
        Console.WriteLine($"face 1 = {f1}x, face 2 = {f2}x, face 3 = {f3}x, face 4 = {f4}x,  face 5 = {f5}x, face 6 = {f6}x");
    }
}