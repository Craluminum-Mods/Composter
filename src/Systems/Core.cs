global using Vintagestory.API.Common;
global using Vintagestory.API.Config;
global using Vintagestory.API.MathTools;
global using Vintagestory.GameContent;

[assembly: ModInfo(name: "Composter", modID: "composter", Side = "Universal")]

namespace Composter;

public class Core : ModSystem
{
    public static Config Config { get; private set; }

    public override void StartPre(ICoreAPI api)
    {
        base.StartPre(api);
        Config = ModConfig.ReadConfig(api);
    }

    public override void Start(ICoreAPI api)
    {
        base.Start(api);
        api.RegisterBlockClass("Composter.BlockComposter", typeof(BlockComposter));
        api.RegisterBlockEntityClass("Composter.BlockEntityComposter", typeof(BlockEntityComposter));
        api.World.Logger.Event("started '{0}' mod", Mod.Info.Name);
    }
}