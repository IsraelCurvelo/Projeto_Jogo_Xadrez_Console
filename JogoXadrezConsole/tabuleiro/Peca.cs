﻿
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get;protected set; }

        public Peca( Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            QtdeMovimentos = 0;
        }

        public void IncrementarMovimento()
        {
            QtdeMovimentos++;
        }
    }
}
