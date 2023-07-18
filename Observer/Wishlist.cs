using PCBuilder.Future;
using PCBuilder.Parts;

namespace PCBuilder.Observer
{
    public class Wishlist : IObserver, IObservable
    {

        IObservable inventory;
        List<IObserver> observers = new List<IObserver>();
        List<IPart> wishlist = new List<IPart>();
        public List<IPart> WishListInStock = new List<IPart>();


        public void Notify()
        {
            HandleNotify();
        }

        async void HandleNotify()
        {
            PartsFuture future = ((Inventory)inventory).ImportNewParts();
            List<IPart> parts = await Task.Run(() =>
            {
                while (!future.IsCompleted())
                {
                    Thread.Sleep(10);
                }
                return future.GetParts();
            });

            foreach(IPart part in parts)
            {
                foreach(IPart wishPart in wishlist)
                {
                    if(wishPart.ToString().Equals(part.ToString()))
                    {
                        WishListInStock.Add(part);
                    }
                }
            }
            if (WishListInStock.Count > 0)
            {
                NotifyObservers();
            }
        }

        void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Notify();
            }
        }


        public void AddToWishlist(IPart part)
        {
            Console.WriteLine("Item has been added to wishlist.");
            wishlist.Add(part);
        }

        public void RemoveFromWishlist(IPart part)
        {
            Console.WriteLine("Item removed from wishlist.");
            wishlist.Remove(part);
        }

        public void SetInventory(IObservable inventory)
        {
            this.inventory = inventory;
            inventory.AddObserver(this);
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}