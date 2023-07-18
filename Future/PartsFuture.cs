using PCBuilder.Parts;

namespace PCBuilder.Future;

public class PartsFuture
{
    Task<List<IPart>> partsTask;

    public PartsFuture(Task<List<IPart>> partsTask)
    {
        this.partsTask = partsTask;
    }

    public List<IPart> GetParts()
    {
        return partsTask.Result;
    }

    public bool IsCompleted()
    {
        return partsTask.IsCompleted;
    }

    List<IPart> ReadPartsFromFile(PartEnum part)
    {
        return new List<IPart>();
    }
}