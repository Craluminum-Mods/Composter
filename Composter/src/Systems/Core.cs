global using Vintagestory.API.Common;
global using Vintagestory.API.Config;
global using Vintagestory.API.MathTools;
global using Vintagestory.GameContent;
using Composter.Configuration;
using Vintagestory.API.Server;

namespace Composter;

public class Core : ModSystem
{
    public static ICoreServerAPI serverApi;

    public ConfigComposter Config { get; private set; }

    public override void StartPre(ICoreAPI api)
    {
        if (!api.Side.IsServer())
        {
            return;
        }

        Config = ModConfig.ReadConfig<ConfigComposter>(api, "Composter.json");
        api.World.Config.SetFloat("composter-perish-rate", Config.PerishRate);
    }

    public override void Start(ICoreAPI api)
    {
        api.RegisterBlockClass("Composter.BlockComposter", typeof(BlockComposter));
        api.RegisterBlockEntityClass("Composter.BlockEntityComposter", typeof(BlockEntityComposter));
        Mod.Logger.Event("started '{0}' mod", Mod.Info.Name);
    }

    public override void StartServerSide(ICoreServerAPI api)
    {
        serverApi = api;
    }
}