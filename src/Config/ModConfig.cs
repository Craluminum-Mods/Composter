namespace Composter;

public static class ModConfig
{
    public static Config ReadConfig(ICoreAPI api)
    {
        Config config;

        try
        {
            config = LoadConfig(api);

            if (config == null)
            {
                GenerateConfig(api);
                config = LoadConfig(api);
            }
            else
            {
                GenerateConfig(api, config);
            }
        }
        catch
        {
            GenerateConfig(api);
            config = LoadConfig(api);
        }

        return config;
    }
    private static Config LoadConfig(ICoreAPI api)
    {
        return api.LoadModConfig<Config>(Constants.ConfigName);
    }
    private static void GenerateConfig(ICoreAPI api)
    {
        api.StoreModConfig(new Config(), Constants.ConfigName);
    }
    private static void GenerateConfig(ICoreAPI api, Config previousConfig)
    {
        api.StoreModConfig(new Config(previousConfig), Constants.ConfigName);
    }
}