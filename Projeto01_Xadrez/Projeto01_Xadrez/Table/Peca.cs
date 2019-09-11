namespace Table
{
    abstract class Peca
    {
        public Position position { get; set; }
        public Cor color { get; protected set; }
        public int QuantMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Cor color, Tabuleiro tab)
        {
            this.position = null;
            this.color = color;
            QuantMovimentos = 0;
            this.tab = tab;
        }

        public abstract bool[,] MovimentosPosiveis();

        public void IncrementarQuantMovimentos()
        {
            QuantMovimentos++;
        }
    }
}
