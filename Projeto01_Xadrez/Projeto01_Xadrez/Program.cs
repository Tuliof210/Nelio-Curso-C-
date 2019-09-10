using System;
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
                Partida game = new Partida();

                while (!game.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(game.Tab);


                    Console.Write("\n\nOrigem: ");
                    Position origem = Tela.Ler().ToPosition();
                    Console.Write("Destino: ");
                    Position destino = Tela.Ler().ToPosition();

                    game.ExecutaMovimento(origem, destino);
                }
            }
            catch(TableException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
