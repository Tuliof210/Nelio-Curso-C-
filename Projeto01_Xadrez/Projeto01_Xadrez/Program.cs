using System;
using Tabuleiro;
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

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
