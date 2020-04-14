
namespace tabuleiro
{
    abstract class Peca
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

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j< tabuleiro.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis() [pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarMovimento()
        {
            QtdeMovimentos++;
        }

        public void DecrementarMovimento()
        {
            QtdeMovimentos--;
        }
    }
}
