namespace Timer.Core.Models;
public class RegistroTempo
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int AtividadeId { get; set; }
    public int EmpresaCidadeEmpresaId { get; set; }
    public int EmpresaCidadeCidadeId { get; set; }
    public TimeSpan TempoGasto { get; set; }

    public Usuario Usuario { get; set; }
    public Atividade Atividade { get; set; }
    public EmpresaEndereco EmpresaEndereco { get; set; }
}
