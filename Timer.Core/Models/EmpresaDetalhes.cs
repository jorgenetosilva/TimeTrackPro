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

    public List<string> Validate()
    {
        var errors = new List<string>();

        if (string.IsNullOrEmpty(Empresa))
            errors.Add("Empresa é obrigatório!");

        if (string.IsNullOrEmpty(Cidade))
            errors.Add("Cidade é obrigatório!");

        if (string.IsNullOrEmpty(Endereco))
            errors.Add("Endereço é obrigatório!");

        if (string.IsNullOrEmpty(Cep))
            errors.Add("CEP é obrigatório!");

        return errors;
    }
}