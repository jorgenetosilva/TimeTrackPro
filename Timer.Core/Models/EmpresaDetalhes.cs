using Timer.Core.Interfaces.Helpers;

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

    public bool IsValid(INotification notification)
    {
        if (string.IsNullOrEmpty(Empresa))
            notification.Add("Empresa é obrigatório!");

        if (string.IsNullOrEmpty(Cidade))
            notification.Add("Cidade é obrigatório!");

        if (string.IsNullOrEmpty(Endereco))
            notification.Add("Endereço é obrigatório!");

        if (string.IsNullOrEmpty(Cep))
            notification.Add("CEP é obrigatório!");

        return !notification.Any();
    }
}