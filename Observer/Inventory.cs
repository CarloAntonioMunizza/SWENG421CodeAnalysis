using PCBuilder.Parts;
using PCBuilder.Future;
namespace PCBuilder.Observer;

public class Inventory : IObservable
{
    static readonly object lockObject = new object();
    List<IObserver> observers = new List<IObserver>();

    bool imported;

    public PartsFuture GetPartsFromDatabase(Type type)
    {
        return new PartsFuture(Task.Run(() => GetPartsFromDatabaseNonFuture(type)));
    }

    public PartsFuture ImportNewParts()
    {
        if(imported == false)
        {
            imported = true;
            NotifyObservers();

        }
        
        return new PartsFuture(Task.Run(() => ReadPartsFromFile("NewParts.txt")));
    }

    public PartsFuture GetPartsNotInStock(Type type)
    {
        return new PartsFuture(Task.Run(() => {
            List<IPart> parts = new List<IPart>();
            parts = ReadPartsFromFile("PartsNotInStock.txt");
            return parts.Where(x => x.GetType() == type).ToList();
        }));
        
    }

    public List<IPart> GetPartsFromDatabaseNonFuture(Type type)
    {
        List<IPart> parts = new List<IPart>();
        parts = ReadPartsFromFile("Parts.txt");
        return parts.Where(x => x.GetType() == type || x.GetType().IsSubclassOf(type)).ToList();
    }

    List<IPart> ReadPartsFromFile(string path)
    {

        List<IPart> parts = new List<IPart>();
        path = Path.Combine(Application.StartupPath, path);
        try
        {
            using (var fs = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    lock(lockObject)
                    {
                        parts.Add(CreateItemFromString(line));

                    }


                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }



        return parts;
    }


    IPart CreateItemFromString(string line)
    {
        object[] attributes = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .Select(x => ParseStringToType(x))
            .ToArray();
        Console.WriteLine((string)attributes[0]);

        object instance = Activator.CreateInstance(Type.GetType((string)attributes[0]), attributes.Where((x, i) => i > 0).ToArray());

        if (instance == null)
        {
            Console.WriteLine($"Failed to create an instance of '{attributes[0]}'.");
            return null;
        }

        IPart part = (IPart)instance;
        Console.WriteLine($"Instance of '{attributes[0]}' created");
        return part;
    }

    object ParseStringToType(string input)
    {
        int intValue;
        float floatValue;

        if (int.TryParse(input, out intValue))
        {
            return intValue;
        }
        else if (float.TryParse(input, out floatValue))
        {
            return floatValue;
        }
        else
        {
            return input;
        }
    }


    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Notify();
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }


}