namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca(Posicao posicao, Tabuleiro tab, cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtdeMovimentos = 0;
        }
        


    }
}
