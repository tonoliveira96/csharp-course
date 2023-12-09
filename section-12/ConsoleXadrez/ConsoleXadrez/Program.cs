using ConsoleXadrez.tabuleiro;
using xadex;

namespace ConsoleXadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));

                Tela.imprimirTabuleiro(tab);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
