using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get;protected set; }
        public int qtdMovimento { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
        }


    }
}
