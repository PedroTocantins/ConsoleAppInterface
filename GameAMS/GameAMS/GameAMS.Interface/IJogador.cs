namespace GameAMS.Interface
{
    public interface IJogador
    {
        //Interface com as assinaturas dos metodos dos jogadores
        //É daqui que o projeto chama os metodos
         string Chutar();
         string Correr();
         string Passar();
    }
}