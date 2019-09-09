using System;
using Curso.Exception;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entities
{
    class CalculaData
    {
        public DateTime Data1 { get; set; }
        public DateTime Data2 { get; set; }

        public CalculaData(DateTime data1, DateTime data2)
        {
            Data1 = data1;
            Data2 = data2;
        }

        public double Subtract()
        {
            if (Data2 > Data1) throw new DomainException("A Segunda data nao pode ser maior");

            TimeSpan ts = Data1.Subtract(Data2);
            return ts.TotalMinutes;
        }
    }
}
