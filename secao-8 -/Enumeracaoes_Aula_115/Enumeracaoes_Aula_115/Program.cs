using System;
using Enumeracaoes_Aula_115.Entities.Enums;
using Enumeracaoes_Aula_115.Entities;

namespace Enumeracaoes_Aula_115 {
    class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrdeStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrdeStatus.PendingPayment.ToString();

            OrdeStatus os = Enum.Parse<OrdeStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);


        }
    }
}
