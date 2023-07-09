using Vintagestory.GameContent;

namespace Composter;

public class BlockEntityComposter : BlockEntityGenericTypedContainer
{
    public override float GetPerishRate() => 500f;
}