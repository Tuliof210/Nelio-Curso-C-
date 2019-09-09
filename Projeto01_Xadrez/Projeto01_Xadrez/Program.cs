﻿using System;
using Table;
using Xadrez;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Position p = new Position(3, 4);
                Tabuleiro t = new Tabuleiro(8, 8);

                t.ColocarPeca(new Torre(t, Cor.Amarela), new Position(0, 0));
                t.ColocarPeca(new Torre(t, Cor.Amarela), new Position(1, 3));
                t.ColocarPeca(new Rei(t, Cor.Amarela), new Position(-1, 0));

                Tela.ImprimirTabuleiro(t);
            }
            catch(TableException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
