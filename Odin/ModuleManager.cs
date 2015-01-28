using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odin
{
    public class ModuleManager
    {
        private List<IModule> m_AvailableModules = new List<IModule>();

        public List<IModule> AvailableModules
        {
            get { return m_AvailableModules; }
            set { m_AvailableModules = value; }
        }

        public IModule GetModuleByName(string Module)
        {
            return AvailableModules.Find(m => m.ModuleName.Equals(Module, StringComparison.InvariantCultureIgnoreCase));
        }

        public IModule GetModuleByID(Guid ModuleID)
        {
            return AvailableModules.Find(m=>m.ModuleID.Equals(ModuleID));
        }

        public void AddModule(IModule Module)
        {
            if (GetModuleByID(Module.ModuleID) == null)
                AvailableModules.Add(Module);
        }

        public void RemoveModule(IModule Module)
        {
            if (GetModuleByID(Module.ModuleID) == null)
                AvailableModules.Remove(Module);
        }
    }
}