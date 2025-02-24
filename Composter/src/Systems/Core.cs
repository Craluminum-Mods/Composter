global using Vintagestory.API.Common;
global using Vintagestory.API.Config;
global using Vintagestory.API.MathTools;
global using Vintagestory.GameContent;
using Composter.Configuration;

namespace Composter;

public class Core : ModSystem
{
    public ConfigComposter Config { get; private set; }

    public static Core GetInstance(ICoreAPI api) => api.ModLoader.GetModSystem<Core>();

    public override void StartPre(ICoreAPI api)
    {
        if (!api.Side.IsServer())
        {
            return;
        }

        Config = ModConfig.ReadConfig<ConfigComposter>(api, "Composter.json");
    }

    public override void Start(ICoreAPI api)
    {
        api.RegisterBlockClass("Composter.BlockComposter", typeof(BlockComposter));
        api.RegisterBlockEntityClass("Composter.BlockEntityComposter", typeof(BlockEntityComposter));
        Mod.Logger.Event("started '{0}' mod", Mod.Info.Name);
    }
}