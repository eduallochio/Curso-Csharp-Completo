using System;

namespace Uri_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002 )
            {
                Console.WriteLine("Senha Invalida!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
