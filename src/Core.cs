using Vintagestory.API.Common;

[assembly: ModInfo("Composter")]

namespace Composter;

class Core : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        base.Start(api);
        api.RegisterBlockClass("Composter.BlockComposter", typeof(BlockComposter));
        api.RegisterBlockEntityClass("Composter.BlockEntityComposter", typeof(BlockEntityComposter));
        api.World.Logger.Event("started 'Composter' mod");
    }
}