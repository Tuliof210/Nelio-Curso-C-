using System;
using Table;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p = new Position(3, 4);
            Tabuleiro t = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(t);

            //Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
