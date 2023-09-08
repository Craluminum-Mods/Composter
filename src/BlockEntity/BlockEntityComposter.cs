namespace Composter;

public class BlockEntityComposter : BlockEntityGenericTypedContainer
{
    public override float GetPerishRate() => Core.Config.PerishRate;
}