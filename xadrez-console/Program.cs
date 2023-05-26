﻿using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 1));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 1));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 2));
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
