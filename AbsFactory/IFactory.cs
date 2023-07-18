using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCBuilder.Future;
using PCBuilder.Parts;

namespace PCBuilder.AbsFactory
{
    public interface IFactory
    {
        PartsFuture CreateMotherboards();
        PartsFuture CreateCPUs();
    }
}
