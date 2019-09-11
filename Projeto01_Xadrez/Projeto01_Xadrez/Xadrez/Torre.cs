using Table;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab) { }

        private bool PodeMover(Position pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.color != color;
        }

        public override bool[,] MovimentosPosiveis()
        {
            bool[,] aux = new bool[tab.Linhas, tab.Colunas];

            Position pos = new Position(0, 0);

            //acima
            pos.DefinirValores(position.Linha - 1, position.Coluna);
            while(tab.PosicaoValida(pos) && PodeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).color != color) break;
                pos.Linha -= 1;
            }

            //abaixo
            pos.DefinirValores(position.Linha + 1, position.Coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).color != color) break;
                pos.Linha += 1;
            }

            //direita
            pos.DefinirValores(position.Linha, position.Coluna + 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).color != color) break;
                pos.Coluna += 1;
            }

            //esquerda
            pos.DefinirValores(position.Linha, position.Coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).color != color) break;
                pos.Coluna -= 1;
            }

            return aux;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
