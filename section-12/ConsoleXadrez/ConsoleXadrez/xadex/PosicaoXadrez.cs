using ConsoleXadrez.tabuleiro;
using System;

namespace xadex
{
    internal class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toposicao()
        {
            return new Posicao(coluna - 'a', 8 - linha);
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
