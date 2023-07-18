
using PCBuilder.Parts;
using PCBuilder.Observer;
using PCBuilder.Future;
using PCBuilder.Filter;

namespace PCBuilder.AbsFactory;

public class IntelFactory : AbstractFactory
{
    public IntelFactory(Inventory inventory) : base(inventory)
    {

    }



    public override PartsFuture CreateCPUs()
    {
        return new PartsFuture(Task.Run(() => RetrieveCPUs()));
    }

    public override PartsFuture CreateMotherboards()
    {
        return new PartsFuture(Task.Run(() => RetrieveMotherboards()));
    }

    List<IPart> RetrieveCPUs()
    {
        List<IPart> cpus = inventory.GetPartsFromDatabaseNonFuture(typeof(CPU));
        cpus = PartFilter.FilterParts(cpus, new SocketSpec(Socket.INTEL));
        return cpus;
    }

    List<IPart> RetrieveMotherboards()
    {
        List<IPart> motherboards = inventory.GetPartsFromDatabaseNonFuture(typeof(Motherboard));
        motherboards = PartFilter.FilterParts(motherboards, new SocketSpec(Socket.INTEL));
        return motherboards;
    }

}