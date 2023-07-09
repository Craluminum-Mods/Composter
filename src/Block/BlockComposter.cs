using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace Composter;

public class BlockComposter : BlockGenericTypedContainer
{
    const string Name = "composter:block-composter";

    public override string GetHeldItemName(ItemStack itemStack)
    {
        var part = itemStack.Attributes.GetString("type");
        var translatedPart = Lang.Get("material-" + part);
        return Lang.Get(Name, translatedPart);
    }

    public override string GetPlacedBlockName(IWorldAccessor world, BlockPos pos)
    {
        var becomposter = world.BlockAccessor.GetBlockEntity<BlockEntityComposter>(pos);
        if (becomposter == null) return base.GetPlacedBlockName(world, pos);

        var part = becomposter.type;
        var translatedPart = Lang.Get("material-" + part);
        return Lang.GetMatchingIfExists(Name, translatedPart);
    }
}