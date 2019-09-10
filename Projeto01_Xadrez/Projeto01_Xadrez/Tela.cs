using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Table;
using Xadrez;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            int row = tab.Linhas;
            char col = 'A';

            Console.WriteLine();

            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"{row}   ");
                for (int j = 0; j < tab.Linhas; j++)
                {
                    if (tab.peca(i, j) == null) Console.Write("- ");
                    else
                    {
                        ImprimePeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                row--;
            }

            Console.Write("\n    ");
            for (int i = 0; i < tab.Colunas; i++)
            {
                Console.Write(col + " ");
                col++;
            }
        }

        public static void ImprimePeca(Peca p)
        {
            if (p.color == Cor.Branca) Console.Write(p);
            else
            {
                ConsoleColor aux = Console.ForegroundColor;//grava a cor padrao
                Console.ForegroundColor = ConsoleColor.Yellow;//troca a cor padrao

                Console.Write(p);
                Console.ForegroundColor = aux;//reseta a cor padrao
            }
        }

        public static MatrizXadrez Ler()
        {
            string s = Console.ReadLine();

            char c = s[0];
            int l = int.Parse(s[1] + "");
            return new MatrizXadrez(c, l);
        }
    }
}
