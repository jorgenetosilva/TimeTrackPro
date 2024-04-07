using Timer.Core.Interfaces.Helpers;

namespace Timer.Web.ViewModels.Login;

public class LoginViewModel
{
    public string Usuario { get; set; }
    public string Senha { get; set; }

    public bool IsValid(INotification _notification)
    {
        if (string.IsNullOrEmpty(Usuario))
            _notification.Add("Obrigatório informar o usuário");

        if (string.IsNullOrEmpty(Senha))
            _notification.Add("Obrigatório informar a senha");

        return !_notification.Any();
    }
}