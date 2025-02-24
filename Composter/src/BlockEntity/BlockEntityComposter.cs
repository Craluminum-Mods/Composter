
using Composter.Configuration;

namespace Composter;

public class BlockEntityComposter : BlockEntityGenericTypedContainer
{
    protected override void InitInventory(Block block)
    {
        base.InitInventory(block);

        if (Api == null || !Api.Side.IsServer())
        {
            return;
        }

        ConfigComposter config = Core.GetInstance(Api).Config;
        if (config == null)
        {
            return;
        }

        container.Inventory.OnAcquireTransitionSpeed += (type, stack, mul) =>
        {
            return type == EnumTransitionType.Perish ? config.PerishRate : container.GetPerishRate();
        };
    }
}