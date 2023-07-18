using PCBuilder.Parts;

namespace PCBuilder.Filter;

public class SocketSpec : ISpecification
{
    private readonly Socket requiredSocket;

    public SocketSpec(Socket requiredSocket)
    {
        this.requiredSocket = requiredSocket;
    }

    public bool IsSatisfied(IPart part)
    {
        if (part is CPU cpu)
        {
            if (cpu is IntelCPU && requiredSocket == Socket.INTEL)
            {
                return true;
            }
            else if (cpu is AMDCPU && requiredSocket == Socket.AMD)
            {
                return true;
            }

        }
        else if (part is Motherboard mobo) {
                if (mobo is IntelMotherboard && requiredSocket == Socket.INTEL)
                {
                    return true;
                }
                else if (mobo is AMDMotherboard && requiredSocket == Socket.AMD)
                {
                    return true;
                }
            }
        return false;
    }
}