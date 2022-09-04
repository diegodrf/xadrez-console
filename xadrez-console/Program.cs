using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                var partida = new PartidaDeXadrez();

                while(!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    var posicaoOrigem = Tela.LerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    var posicaoDestino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutarMovimento(posicaoOrigem, posicaoDestino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}