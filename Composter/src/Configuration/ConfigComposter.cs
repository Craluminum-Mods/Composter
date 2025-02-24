namespace Composter.Configuration;

public class ConfigComposter : IModConfig
{
    public float PerishRate { get; set; } = 500.0f;

    public ConfigComposter(ICoreAPI api, ConfigComposter previousConfig = null)
    {
        if (previousConfig != null)
        {
            PerishRate = previousConfig.PerishRate;
        }
    }
}