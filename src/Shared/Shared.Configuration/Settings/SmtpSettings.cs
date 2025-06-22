using Shared.Configuration.Internal;

namespace Shared.Configuration.Settings;

public class SmtpSettings
{
    public string Host => EnvReader.Get("SMTP_HOST");
    public int Port => EnvReader.GetInt("SMTP_PORT");
    public string User => EnvReader.Get("SMTP_USER");
    public string Password => EnvReader.Get("SMTP_PASSWORD");
}
