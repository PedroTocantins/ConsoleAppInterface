using System;
using GameAMS.Service;

namespace GameAMS.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoAMS(
                
                new Jogador1("Felipe"),
                new Jogador2()
            );
            jogo.IniciarJogo(); 
            Console.WriteLine(" ");
        }
    }

}
