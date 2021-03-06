using Microsoft.EntityFrameworkCore;
using Minha3ConexaoJH.Data.Map;
using Minha3ConexaoJH.Domain;
using Minha3ConexaoJH.Domain.Model;

namespace Minha3ConexaoJH.Data
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<TurmaProfessor> TurmaProfessor { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
            
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-MCO4P9I5\SQLEXPRESS; Database=Minha3ConexaoJH; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new TurmaProfessorMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
