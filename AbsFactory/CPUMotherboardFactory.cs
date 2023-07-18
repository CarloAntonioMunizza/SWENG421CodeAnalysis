using PCBuilder.Parts;
using PCBuilder.Observer;

namespace PCBuilder.AbsFactory
{
    public static class CPUMotherboardFactory
    {
        public static IFactory CreateFactory(Socket socket, Inventory inventory)
        {
            if (socket == Socket.AMD)
                return new AMDFactory(inventory);
            else
                return new IntelFactory(inventory);
        }
    }
}

