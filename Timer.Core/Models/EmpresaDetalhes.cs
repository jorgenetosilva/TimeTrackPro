namespace Timer.Core.Models;

public class EmpresaDetalhes
{
    public int EmpresaId { get; set; }
    public string Empresa { get; set; }
    public string Cidade { get; set; }
    public string Endereco { get; set; }
    public string Cep { get; set; }
    public short? Status { get; set; }
    public string Bairro { get; set; }
    public string Estado { get; set; }
    public string Complemento { get; set; }
}