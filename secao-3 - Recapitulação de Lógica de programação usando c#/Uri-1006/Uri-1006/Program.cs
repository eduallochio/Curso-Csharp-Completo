using System;
using System.Globalization;
namespace Uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = (double)(A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));




        }
    }
}
