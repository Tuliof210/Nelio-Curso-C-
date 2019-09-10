using Table;

namespace Xadrez
{
    class MatrizXadrez // Classe auxiliar nas posiçoes
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public MatrizXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Position ToPosition()
        {
            return new Position(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }
    }
}
