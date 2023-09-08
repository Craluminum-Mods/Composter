namespace Composter;

public class Config
{
    public float PerishRate { get; set; } = 500.0f;

    public Config()
    {
    }
    public Config(Config previousConfig)
    {
        PerishRate = previousConfig.PerishRate;
    }
}