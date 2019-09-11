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
        public static void ImprimirPartida(Partida game)
        {
            ImprimirTabuleiro(game.Tab);
            Console.WriteLine();
            ImprimirCapturadas(game);
            Console.WriteLine("\n\nTurno: " + game.Turno);
            Console.WriteLine("Aguardando Jogada: " + game.JogadorAtual);
        }

        public static void ImprimirCapturadas(Partida game)
        {
            Console.WriteLine("\nPeças Capturadas: ");
            Console.Write("Amarelas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(game.ListaCapturadas(Cor.Amarela));
            Console.ForegroundColor = aux;

            Console.Write("\nRosas: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            ImprimirConjunto(game.ListaCapturadas(Cor.Rosa));
            Console.ForegroundColor = aux;
        }

        public static void ImprimirConjunto(HashSet<Peca> aux)
        {
            Console.Write("[");
            foreach(Peca p in aux)
            {
                Console.Write(p + " ");
            }
            Console.Write("]   ");
        }

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
                    ImprimePeca(tab.peca(i, j));
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

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] possiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkBlue;

            int row = tab.Linhas;
            char col = 'A';

            Console.WriteLine();

            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"{row}   ");
                for (int j = 0; j < tab.Linhas; j++)
                {
                    if(possiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimePeca(tab.peca(i, j));
                }
                Console.WriteLine();
                row--;
                Console.BackgroundColor = fundoOriginal;
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
            if (p == null) Console.Write("- ");
            else
            {
                if (p.color == Cor.Branca) Console.Write(p);
                else if (p.color == Cor.Amarela)
                {
                    ConsoleColor aux = Console.ForegroundColor;//grava a cor padrao
                    Console.ForegroundColor = ConsoleColor.Yellow;//troca a cor padrao

                    Console.Write(p);
                    Console.ForegroundColor = aux;//reseta a cor padrao
                }
                else if (p.color == Cor.Rosa)
                {
                    ConsoleColor aux = Console.ForegroundColor;//grava a cor padrao
                    Console.ForegroundColor = ConsoleColor.Magenta;//troca a cor padrao

                    Console.Write(p);
                    Console.ForegroundColor = aux;//reseta a cor padrao
                }
                Console.Write(" ");
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
