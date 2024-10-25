using System;

class exercico12
{
    static void Main()
    {
        Console.WriteLine("Digite as 5 notas recebidas: (valores a cima de 5.0 e abaixo de 10.0");
        double[] notas = new double[5];
        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = double.Parse(Console.ReadLine());
            if (notas[i] < 5 || notas[i] > 10)
            {
                i--;
            }
        }
        double soma = 0, menor = 0, maior = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (menor == 0 || notas[i] < menor)
            {
                menor = notas[i];
            }
            if (notas[i] > maior)
            {
                maior = notas[i];
            }
        }
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }

        soma = soma - menor - maior;

        Console.WriteLine($"Nota final: {soma:F1}");
    }

}
