using GameAMS.Interface.IJogador;

namespace GameAMS.Aplication
{
    public class JogoAMS
    {

        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
        public JogoAMS(IJogador jogadorA,IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;

        }
        public void IniciarJogo(){
            System.Console.WriteLine($"Jogo Iniciado pelo jogador A \n{_jogadorA.Chutar()}");
            System.Console.WriteLine($"{_jogadorA.Correr()}");
            System.Console.WriteLine($"{_jogadorA.Passar()}");
            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Jogo Iniciado pelo jogador B \n{_jogadorB.Chutar()}");
            System.Console.WriteLine($"{_jogadorB.Correr()}");
            System.Console.WriteLine($"{_jogadorB.Passar()}");
        }
    }
}