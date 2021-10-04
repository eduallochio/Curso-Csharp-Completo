using System;

namespace Uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num, Ano = 360, mes = 30, dia = 1;

            Num = int.Parse(Console.ReadLine());

            Ano = Num / 365;
            mes = (Num % 365) / 30;
            dia = (Num % 365) % 30;

            Console.WriteLine(Ano + " ano(s)\r\n" + mes + " mes(es)\r\n" + dia + " dia(s)\r\n");




        }
    }
}
