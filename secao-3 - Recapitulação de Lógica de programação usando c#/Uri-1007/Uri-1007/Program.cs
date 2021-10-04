using System;

namespace Uri_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            soma = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + soma);

        }
    }
}
