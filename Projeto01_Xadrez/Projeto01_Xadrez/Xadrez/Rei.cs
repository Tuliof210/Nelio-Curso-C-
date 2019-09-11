using Table;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        private bool PodeMover(Position pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.color != color;
        } 

        public override bool[,] MovimentosPosiveis()
        {
            bool[,] aux = new bool[tab.Linhas, tab.Colunas];

            Position pos = new Position(0, 0);

            //norte
            pos.DefinirValores(position.Linha - 1, position.Coluna);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            //nordeste
            pos.DefinirValores(position.Linha - 1, position.Coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            //leste
            pos.DefinirValores(position.Linha, position.Coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            //sudeste
            pos.DefinirValores(position.Linha + 1, position.Coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            //sul
            pos.DefinirValores(position.Linha + 1, position.Coluna);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            //sudoeste
            pos.DefinirValores(position.Linha + 1, position.Coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            //oeste
            pos.DefinirValores(position.Linha, position.Coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            //noroeste
            pos.DefinirValores(position.Linha - 1, position.Coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos)) aux[pos.Linha, pos.Coluna] = true;

            return aux;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
