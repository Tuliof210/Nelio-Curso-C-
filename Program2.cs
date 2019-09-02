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
            int a = Soma(2, 3, 4);
            int b = Soma(4, 10);

            Console.WriteLine($"{a} e {b}");


            Console.ReadKey();
        }

        static int Soma(params int[] x)//exemplo de metodo que recebe quantidade variavel de parametros
        {
            int s = 0;

            foreach(int a in x)
            {
                s += a;
            }
            return s;
        }
    }
}
