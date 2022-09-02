using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao? Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QuantidadeDeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Cor = cor;
            QuantidadeDeMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
