using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Amarelo;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarMovimento();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p,destino);

        }

        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Amarelo), new PosicaoXadrez('c', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Amarelo), new PosicaoXadrez('e', 1).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Amarelo), new PosicaoXadrez('d', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Amarelo), new PosicaoXadrez('c', 2).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Amarelo), new PosicaoXadrez('e', 2).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Amarelo), new PosicaoXadrez('d', 2).ToPosicao());

            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('c', 8).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('e', 8).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Azul), new PosicaoXadrez('d', 8).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('c', 7).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('e', 7).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Azul), new PosicaoXadrez('d', 7).ToPosicao());





        }
    }
}
