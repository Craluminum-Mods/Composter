namespace Composter;

public class BlockEntityComposter : BlockEntityGenericTypedContainer
{
    protected override void InitInventory(Block block)
    {
        base.InitInventory(block);

        if (Core.serverApi == null) // Blockentity.Api is always null
        {
            return;
        }

        float customPerishRate = Core.serverApi.World.Config.GetFloat("composter-perish-rate");

        container.Inventory.OnAcquireTransitionSpeed += (type, stack, mul) =>
        {
            return type == EnumTransitionType.Perish ? customPerishRate : container.GetPerishRate();
        };
    }
}