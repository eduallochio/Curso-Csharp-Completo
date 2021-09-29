using System;
using System.Globalization;

namespace Uri_1008_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, qHoras;
            double vHora, salario;
            


            num = int.Parse(Console.ReadLine());
            qHoras = int.Parse(Console.ReadLine());
            vHora = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            salario =  vHora *  qHoras;

            Console.WriteLine("Numero = " + num);
            Console.WriteLine("Salario = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine();
        }
    }
}
