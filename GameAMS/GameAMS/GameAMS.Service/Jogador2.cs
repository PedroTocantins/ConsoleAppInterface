using GameAMS.Interface;

namespace GameAMS.Service
{
    public class Jogador2 : IJogador
    {
        public string Chutar()
        {
            return $"Pedro esta chutando";
        }

        public string Correr()
        {
            return $"Pedro esta correndo";
        }

        public string Passar()
        {
            return $"Pedro esta passando a bola";
        }
    }
}