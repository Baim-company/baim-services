using Shared.Configuration.Internal;

namespace Shared.Configuration.Settings;

public class ConnectionStringsSettings
{
    public string IdentityDb => EnvReader.Get("IDENTITY_DB_CONNECTION_STRING");
    public string AccountDb => EnvReader.Get("ACOUNT_DB_CONNECTION_STRING");
    public string VacancyDb => EnvReader.Get("VACANCY_DB_CONNECTION_STRING");
    public string MarketingDb => EnvReader.Get("MARKETING_DB_CONNECTION_STRING");
}
