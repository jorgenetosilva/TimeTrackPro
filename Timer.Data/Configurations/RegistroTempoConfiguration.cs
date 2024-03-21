using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timer.Core.Models;

namespace Timer.Data.Configurations;

public class RegistroTempoConfiguration : IEntityTypeConfiguration<RegistroTempo>
{
    public void Configure(EntityTypeBuilder<RegistroTempo> builder)
    {
        builder.ToTable("registro_tempo");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired();
        builder.Property(x => x.UsuarioId).HasColumnName("usuario_id").IsRequired();
        builder.Property(x => x.AtividadeId).HasColumnName("atividade_id").IsRequired();
        builder.Property(x => x.EmpresaCidadeEmpresaId).HasColumnName("empresa_cidade_empresa_id").IsRequired();
        builder.Property(x => x.EmpresaCidadeCidadeId).HasColumnName("empresa_cidade_cidade_id").IsRequired();
        builder.Property(x => x.TempoGasto).HasColumnName("tempo_gasto").IsRequired();

        builder.HasOne(x => x.Usuario).WithMany().HasForeignKey(x => x.UsuarioId);
        builder.HasOne(x => x.Atividade).WithMany().HasForeignKey(x => x.AtividadeId);
        // Nota: Se a entidade EmpresaEndereco estiver configurada corretamente, ajuste a linha abaixo conforme necessário
        builder.HasOne(x => x.EmpresaDetalhes).WithMany().HasForeignKey(x => new { x.EmpresaCidadeEmpresaId, x.EmpresaCidadeCidadeId });
    }
}
