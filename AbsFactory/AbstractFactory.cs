using PCBuilder.Future;
using PCBuilder.Observer;
using PCBuilder.Parts;

namespace PCBuilder.AbsFactory;

public abstract class AbstractFactory : IFactory
{
    protected Inventory inventory;
    public AbstractFactory(Inventory inventory)
    {
        this.inventory = inventory;
    }
    public abstract PartsFuture CreateCPUs();
    public abstract PartsFuture CreateMotherboards();
}
