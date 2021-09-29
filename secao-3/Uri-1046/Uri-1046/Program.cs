using System;

namespace Uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal ;
            
            int duracao;

            horaInicial = int.Parse(Console.ReadLine());
            horaFinal = int.Parse(Console.ReadLine());

             if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo Duro " + duracao + "Horas(s)");
        }
    }
}
