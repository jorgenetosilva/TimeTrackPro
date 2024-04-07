using System.IdentityModel.Tokens.Jwt;
using Timer.Core.Models;
using Timer.Core.Settings;

namespace Timer.Web.Configurations.Extensions;

public static class HttpContextExtensions
{
    private static readonly string AppSettingsError = "Não foi possivel recuperar as configurações da aplicação";

    // public static void LogIn(this HttpContext httpContext, UsuarioCookie user)
    // {
    //     var settings = httpContext.RequestServices.GetService<AppSettings>();
    //     if (settings == null)
    //         throw new Exception(AppSettingsError);

    //     var json = user.ToJson(JsonFactory.DefaultSettings());
    //     var jwt = JwtHelper.Create(settings.Web.CookieKey, json, settings.Web.CookieDurationInHours);
    //     var token = jwt.Compress();

    //     httpContext.Response.Cookies.Append(settings.Web.CookieName, token, new CookieOptions
    //     {
    //         Domain = settings.Web.CookieDomain,
    //         Expires = DateTime.UtcNow.AddHours(settings.Web.CookieDurationInHours)
    //     });
    // }
}
