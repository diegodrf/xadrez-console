using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(var linha=0; linha < tabuleiro.Linhas; linha++)
            {
                for(var coluna=0; coluna<tabuleiro.Colunas; coluna++)
                {
                    var peca = tabuleiro.Peca(linha, coluna);
                    if (peca is null)
                        Console.Write("- ");
                    Console.Write($"{peca} ");
                }
                Console.WriteLine();
            }
        }
    }
}
