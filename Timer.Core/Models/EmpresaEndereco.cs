namespace Timer.Core.Models;

public class EmpresaEndereco
{
    public int EmpresaId { get; set; }
    public int CidadeId { get; set; }
    public string Endereco { get; set; }
    public string Cep { get; set; }
    public string Bairro { get; set; }
    public string Estado { get; set; }
    public string Complemento { get; set; }

    public Empresa Empresa { get; set; }
    public Cidade Cidade { get; set; }
}