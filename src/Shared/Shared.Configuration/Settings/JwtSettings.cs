using Shared.Configuration.Internal;

namespace Shared.Configuration.Settings;

public class JwtSettings
{
    public string Issuer => EnvReader.Get("JWT_ISSUER");
    public string Audience => EnvReader.Get("JWT_AUDIENCE");
    public string Secret => EnvReader.Get("JWT_SECRET");
}
