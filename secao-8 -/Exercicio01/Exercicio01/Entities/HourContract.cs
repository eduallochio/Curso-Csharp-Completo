using System;


namespace Exercicio01.Entities {
    class HourContract {
        public DateTime Date { get; set; }
        public Double ValourPerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() {

        }

        public HourContract(DateTime date, double valourPerHour, int hours) {
            Date = date;
            ValourPerHour = valourPerHour;
            Hours = hours;
        }

        public double Totalvalue() {
            
            return Hours * ValourPerHour;
        }
    }
}
