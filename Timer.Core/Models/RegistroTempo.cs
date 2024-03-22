namespace Timer.Core.Models;
public class RegistroTempo
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int AtividadeId { get; set; }
    public int EmpresaId { get; set; }
    public TimeSpan TempoGasto { get; set; }

    public Usuario Usuario { get; set; }
    public Atividade Atividade { get; set; }
    public EmpresaDetalhes EmpresaDetalhes { get; set; }
}

