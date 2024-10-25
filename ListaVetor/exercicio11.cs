using System;
using Array;

class exercico11
{
    static void Main()
    {
        Console.WriteLine("Digite a frase codificada:");
        string frase = Console.ReadLine();

        for (int i = 1; i < frase.Length; i++)
        {


            if (frase[i] != 'p')
            {

                Console.Write(frase[i]);

            }

            else if (frase[i - 1] == 'p' && frase[i + 1] == 'p')
            {
                Console.Write(frase[i]);
            }

        }

    }
}
