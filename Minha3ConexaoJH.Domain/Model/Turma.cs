using System.Collections.Generic;

namespace Minha3ConexaoJH.Domain
{
    public class Turma : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<TurmaProfessor> TurmaProfessor { get; set; }
    }
}
