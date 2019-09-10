using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Table;

namespace Xadrez
{
    class Partida
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public Partida()
        {
            Terminada = false;
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Iniciar();
        }

        public void Iniciar()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Amarela), new MatrizXadrez('c', 1).ToPosition());
            Tab.ColocarPeca(new Torre(Tab, Cor.Amarela), new MatrizXadrez('c', 2).ToPosition());
            Tab.ColocarPeca(new Torre(Tab, Cor.Amarela), new MatrizXadrez('d', 2).ToPosition());
            Tab.ColocarPeca(new Torre(Tab, Cor.Amarela), new MatrizXadrez('e', 2).ToPosition());
            Tab.ColocarPeca(new Torre(Tab, Cor.Amarela), new MatrizXadrez('e', 1).ToPosition());
            Tab.ColocarPeca(new Rei(Tab, Cor.Amarela), new MatrizXadrez('d', 1).ToPosition());
        }

        public void ExecutaMovimento(Position origem, Position destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQuantMovimentos();
            Peca capturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }
    }
}
