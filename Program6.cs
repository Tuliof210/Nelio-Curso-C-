using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 129.99;
            double desconto = (price < 100.0) ? price * 0.1 : price * 0.05;

            Console.WriteLine(desconto.ToString("F2"));
            Console.ReadKey();
        }
    }
}
