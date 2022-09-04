using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (var linha = 0; linha < tabuleiro.Linhas; linha++)
            {
                Console.Write($"{8 - linha} ");
                for (var coluna = 0; coluna < tabuleiro.Colunas; coluna++)
                {
                    var peca = tabuleiro.Peca(linha, coluna);
                    if (peca is null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(peca);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h ");
            Console.WriteLine();
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = currentColor;
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            var userInput = Console.ReadLine()!;
            var coluna = userInput.ElementAt(0);
            var linha = int.Parse(userInput.ElementAt(1).ToString());
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
