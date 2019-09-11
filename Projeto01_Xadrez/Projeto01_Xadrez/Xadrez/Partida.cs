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
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        private HashSet<Peca> PecasInGame;
        private HashSet<Peca> PecasCapturadas;

        public Partida()
        {
            PecasInGame = new HashSet<Peca>();
            PecasCapturadas = new HashSet<Peca>();

            Terminada = false;
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Amarela;
            Iniciar();
        }

        public void ColocarNovaPeca(char col, int row, Peca p)
        {
            Tab.ColocarPeca(p, new MatrizXadrez(col, row).ToPosition());
            PecasInGame.Add(p);
        }

        public void Iniciar()
        {
            ColocarNovaPeca('c', 1, new Torre(Tab, Cor.Amarela));
            ColocarNovaPeca('c', 2, new Torre(Tab, Cor.Amarela));
            ColocarNovaPeca('d', 2, new Torre(Tab, Cor.Amarela));
            ColocarNovaPeca('e', 2, new Torre(Tab, Cor.Amarela));
            ColocarNovaPeca('e', 1, new Torre(Tab, Cor.Amarela));
            ColocarNovaPeca('d', 1, new Rei(Tab, Cor.Amarela));

            ColocarNovaPeca('c', 8, new Torre(Tab, Cor.Rosa));
            ColocarNovaPeca('c', 7, new Torre(Tab, Cor.Rosa));
            ColocarNovaPeca('d', 7, new Torre(Tab, Cor.Rosa));
            ColocarNovaPeca('e', 7, new Torre(Tab, Cor.Rosa));
            ColocarNovaPeca('e', 8, new Torre(Tab, Cor.Rosa));
            ColocarNovaPeca('d', 8, new Rei(Tab, Cor.Rosa));
        }
        
        public void RealizaJogada(Position origem, Position destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();
        }

        public void ValidarPosOrigem(Position pos)
        {
            if (Tab.peca(pos) == null) throw new TableException("Não existe peça nessa posição");
            if(JogadorAtual != Tab.peca(pos).color) throw new TableException("A pessoa escolhida não é sua");
            if(!Tab.peca(pos).ExisteMovimentosPossiveis()) throw new TableException("Não há movimentos possíveis para essa peça");
        }

        private void MudaJogador()
        {
            if (JogadorAtual == Cor.Amarela) JogadorAtual = Cor.Rosa;
            else JogadorAtual = Cor.Amarela;
        }

        public void ExecutaMovimento(Position origem, Position destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQuantMovimentos();
            Peca capturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
            if (capturada != null)
            {
                PecasCapturadas.Add(capturada);
            }
        }

        public HashSet<Peca> ListaCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach(Peca x in PecasCapturadas)
            {
                if (x.color == cor) aux.Add(x);
            }
            return aux;
        }

        public HashSet<Peca> ListaInGame(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in PecasInGame)
            {
                if (x.color == cor) aux.Add(x);
            }
            aux.ExceptWith(ListaCapturadas(cor));
            return aux;
        }
    }
}
