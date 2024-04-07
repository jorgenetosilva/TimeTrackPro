using Timer.Core.Interfaces.Helpers;

namespace Timer.Core.Models;

public class UsuarioCookie
{
    public int Codigo { get; set; }
    public string Nome { get; set; }

    public bool IsValid(INotification notification)
    {
        if (Codigo == default)
            notification.Add("Obrigatório informar o campo 'Codigo'");

        if (string.IsNullOrWhiteSpace(Nome))
            notification.Add("Obrigatório informar o campo 'Nome'");

        return !notification.Any();
    }
}
