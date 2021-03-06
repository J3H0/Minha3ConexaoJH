using Microsoft.EntityFrameworkCore;
using Minha3ConexaoJH.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Minha3ConexaoJH.Data.Map
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .IsRequired();
        }
    }
}
