namespace Shared.Configuration.Internal;

public static class EnvReader
{
    public static string Get(string key)
    {
        var value = Environment.GetEnvironmentVariable(key);
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidOperationException($"Missing env var: {key}");

        return value;
    }

    public static int GetInt(string key) => int.Parse(Get(key));
    public static bool GetBool(string key) => bool.Parse(Get(key));
}
