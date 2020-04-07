using System;
using tabuleiro;

namespace JogoXadrezConsole
{
    class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i =0; i< tab.Linhas; i++)
            {
                ConsoleColor aux2 = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(8 - i + "  ");
                Console.ForegroundColor = aux2;
               
                for (int j = 0; j < tab.Colunas; j++)
                {                 
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   a b c d e f g h ");
            Console.ForegroundColor = aux;
            
        }

        public static void ImprimirPeca(Peca peca)
        {
          if (peca.cor == Cor.Amarelo)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else if (peca.cor == Cor.Azul)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            
            else if (peca.cor == Cor.Verde)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else if (peca.cor == Cor.Vermelho)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }

            else
            {
                
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                
            }
        } 
    }
}
