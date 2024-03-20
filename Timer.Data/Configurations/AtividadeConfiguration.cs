using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timer.Core.Models;

namespace Timer.Data.Configurations;

public class AtividadeConfiguration : IEntityTypeConfiguration<Atividade>
{
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
        builder.ToTable("atividade");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired();
        builder.Property(x => x.Nome).HasColumnName("nome").IsRequired();
        builder.Property(x => x.CategoriaId).HasColumnName("categoria_id").IsRequired();

        builder.HasOne(x => x.Categoria).WithMany().HasForeignKey(x => x.CategoriaId);
    }
}
