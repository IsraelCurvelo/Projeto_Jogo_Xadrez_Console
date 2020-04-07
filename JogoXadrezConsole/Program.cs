using System;
using tabuleiro;
using xadrez;

namespace JogoXadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Turquesa), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Amarelo), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Verde), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Vermelho), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(4, 5));
                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
