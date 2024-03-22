using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timer.Core.Models;

namespace Timer.Data.Configurations;

public class EmpresaDetalhesConfiguration : IEntityTypeConfiguration<EmpresaDetalhes>
{
    public void Configure(EntityTypeBuilder<EmpresaDetalhes> builder)
    {
        builder.ToTable("empresa_detalhes");

        builder.HasKey(x => x.EmpresaId);

        builder.Property(x => x.EmpresaId).HasColumnName("empresa_id").IsRequired();
        builder.Property(x => x.Empresa).HasColumnName("nome_empresa").IsRequired();
        builder.Property(x => x.Cidade).HasColumnName("nome_cidade").IsRequired();
        builder.Property(x => x.Endereco).HasColumnName("endereco").IsRequired();
        builder.Property(x => x.Cep).HasColumnName("cep").IsRequired();
        builder.Property(x => x.Bairro).HasColumnName("bairro").IsRequired();
        builder.Property(x => x.Estado).HasColumnName("estado").IsRequired();
        builder.Property(x => x.Complemento).HasColumnName("complemento");
    }
}
