using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gizmox.WebGUI.Forms;

namespace Odin
{
    public interface IModule: IDisposable
    {
        string ModuleName { get; }
        Guid ModuleID { get; }
        ModuleStates ModuleState { get; set; }
        bool isPublic { get; }
        UserControl MainInterface { get; }
        void initialize();
        int Order { get; }
        ModuleGlobal GlobalConfig { get; set; }

    }
}
