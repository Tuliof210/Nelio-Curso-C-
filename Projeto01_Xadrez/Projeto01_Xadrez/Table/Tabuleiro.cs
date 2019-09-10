namespace Table
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Position pos)//sobrecarga
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Position pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Position pos)
        {
            if(ExistePeca(pos))
            {
                throw new TableException("Já existe uma Peça nessa Posição");
            }

            pecas[pos.Linha, pos.Coluna] = p;
            p.position = pos; //nao importa a ordem ja que o objeto em si é o mesmo
        }

        public Peca RetirarPeca(Position pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }

            Peca aux = peca(pos);
            aux.position = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool PosicaoValida(Position pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        
        public void ValidarPosicao(Position pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TableException("Posição Invalida");
            }
        }
    }
}
