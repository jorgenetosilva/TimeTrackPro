using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timer.Core.Models; // Garanta que está referenciando o namespace correto do seu modelo

namespace Timer.Data.Configurations;

public class EmpresaEnderecoConfiguration : IEntityTypeConfiguration<EmpresaEndereco>
{
    public void Configure(EntityTypeBuilder<EmpresaEndereco> builder)
    {
        builder.ToTable("empresa_endereco");

        builder.HasKey(x => new { x.EmpresaId, x.CidadeId });

        builder.Property(x => x.EmpresaId).HasColumnName("empresa_id").IsRequired();
        builder.Property(x => x.CidadeId).HasColumnName("cidade_id").IsRequired();
        builder.Property(x => x.Endereco).HasColumnName("endereco").IsRequired();
        builder.Property(x => x.Cep).HasColumnName("cep").IsRequired();
        builder.Property(x => x.Bairro).HasColumnName("bairro").IsRequired();
        builder.Property(x => x.Estado).HasColumnName("estado").IsRequired();
        builder.Property(x => x.Complemento).HasColumnName("complemento");

        builder.HasOne(x => x.Empresa).WithMany().HasForeignKey(x => x.EmpresaId);
        builder.HasOne(x => x.Cidade).WithMany().HasForeignKey(x => x.CidadeId);
    }
}
