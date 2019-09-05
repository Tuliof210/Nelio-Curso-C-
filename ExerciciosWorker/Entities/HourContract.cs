using System;

namespace Empresa.Entities
{
    class HourContract
    {
        public DateTime Date { get; private set; }
        public double ValuePerHour { get; private set; }
        public int Hours { get; private set; }

        public HourContract(){}
        public HourContract(DateTime date, double valuehour, int hours)
        {
            this.Date = date;
            this.ValuePerHour = valuehour;
            this.Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
