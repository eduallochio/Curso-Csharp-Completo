using System;
using Enumeracaoes_Aula_115.Entities.Enums;

namespace Enumeracaoes_Aula_115.Entities {
    class Order {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrdeStatus Status { get; set; }

        public override string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
