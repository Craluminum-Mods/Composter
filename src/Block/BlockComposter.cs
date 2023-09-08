namespace Composter;

public class BlockComposter : BlockGenericTypedContainer
{
    const string Name = "composter:block-composter";

    public override string GetHeldItemName(ItemStack itemStack)
    {
        string part = itemStack.Attributes.GetString("type");
        string translatedPart = Lang.Get("material-" + part);
        return Lang.Get(Name, translatedPart);
    }

    public override string GetPlacedBlockName(IWorldAccessor world, BlockPos pos)
    {
        BlockEntityComposter becomposter = world.BlockAccessor.GetBlockEntity<BlockEntityComposter>(pos);
        if (becomposter == null)
        {
            return base.GetPlacedBlockName(world, pos);
        }

        string part = becomposter.type;
        string translatedPart = Lang.Get("material-" + part);
        return Lang.GetMatchingIfExists(Name, translatedPart);
    }
}