using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities;
using Curso.Exception;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2020, 5, 22);
            DateTime dt2 = new DateTime(2019, 5, 22);

            try
            {
                CalculaData cd = new CalculaData(dt1, dt2);

                Console.WriteLine(cd.Subtract());
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
