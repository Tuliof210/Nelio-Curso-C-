using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Table;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            char row = '\u0041';

            Console.WriteLine();

            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"{row}   ");
                for (int j = 0; j < tab.Linhas; j++)
                {
                    if (tab.peca(i, j) == null) Console.Write("- ");
                    else Console.Write(tab.peca(i,j) + " ");
                }
                Console.WriteLine();
                row++;
            }
            Console.WriteLine("\n    1 2 3 4 5 6 7 8\n"); //deixar a tela mais organizada
        }
    }
}
