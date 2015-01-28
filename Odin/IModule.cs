using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odin
{
    public interface IModule
    {
        string ModuleName { get; }
        Guid ModuleID { get; }
        ModuleStates ModuleState { get; set; }
        bool isPublic { get; }
    }
}
