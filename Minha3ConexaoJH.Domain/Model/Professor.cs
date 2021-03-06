using System;
using System.Collections.Generic;
using System.Text;

namespace Minha3ConexaoJH.Domain
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Turno Turno { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public List<TurmaProfessor> TurmaProfessor { get; set; }
    }
    public enum Turno
    {
        Manha,
        Tarde,
        Noite,
        Integral
    }
}
