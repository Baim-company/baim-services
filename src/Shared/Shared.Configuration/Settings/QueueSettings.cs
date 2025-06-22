using Shared.Configuration.Internal;

namespace Shared.Configuration.Settings;

public class QueueSettings
{
    public string Host => EnvReader.Get("RABBITMQ_HOST");
    public int Port => EnvReader.GetInt("RABBITMQ_PORT");
    public string User => EnvReader.Get("RABBITMQ_USER");
    public string Password => EnvReader.Get("RABBITMQ_PASSWORD");
}
