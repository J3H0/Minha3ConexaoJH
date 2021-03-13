namespace Minha3ConexaoJH.Domain.Model
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public string Perfil { get; set; }
    }
}
