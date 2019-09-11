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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(game);

                        Console.Write("\nOrigem: ");
                        Position origem = Tela.Ler().ToPosition();
                        game.ValidarPosOrigem(origem);

                        bool[,] possiveis = game.Tab.peca(origem).MovimentosPosiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(game.Tab, possiveis);
                        Console.WriteLine("\n\nTurno: " + game.Turno);
                        Console.WriteLine("Aguardando Jogada: " + game.JogadorAtual);

                        Console.Write("\nDestino: ");
                        Position destino = Tela.Ler().ToPosition();

                        game.RealizaJogada(origem, destino);
                    }
                    catch (TableException e)
                    {
                        Console.Write($"{e.Message}, digite uma tecla para continuar...");
                        Console.ReadKey();
                    }
                    catch (Exception e)
                    {
                        Console.Write($"{e.Message}\ndigite uma tecla para continuar...");
                        Console.ReadKey();
                    }
                }
            }
            catch(TableException e)
            {
                Console.WriteLine($"\n{e.Message}");
            }
            Console.ReadKey();
        }
    }
}
