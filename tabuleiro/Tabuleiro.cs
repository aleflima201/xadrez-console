namespace tabuleiro
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            this.linha = linha;
            this.colunas = coluna;
            pecas = new Peca[linha, coluna];
        }
    }
}