using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            IModule module = GetModuleByID(Module.ModuleID);
            if (module != null)
            {
                module.Dispose();
                AvailableModules.Remove(Module);
            }
        }

        public void LoadModules()
        {
            DirectoryInfo di = new DirectoryInfo(Gizmox.WebGUI.Common.Global.Context.Config.GetDirectory("Modules"));

            FileInfo[] Files = di.GetFiles("*.dll", SearchOption.TopDirectoryOnly);
            
            foreach (FileInfo file in Files)
            { 
                Assembly assembly = Assembly.LoadFrom(file.FullName);
                Type[] AssemblyTypes = assembly.GetTypes();
                foreach (Type t in AssemblyTypes)
                {
                    if (t.IsPublic)
                    {
                        Type moduleinterface = t.GetInterface("Odin.IModule");
                        if (moduleinterface != null)
                        {
                            AddModule(CreateModule(assembly, t));
                            break;
                        }
                       
                    }
                }
                AssemblyTypes = null;
                assembly = null;


            }

            AvailableModules.Sort((x, y) => x.Order.CompareTo(y.Order));
        }

        private IModule CreateModule(Assembly assembly, Type t)
        {
            IModule module = (IModule)Activator.CreateInstance(t);
            module.initialize();
            return module;
        }
    }
}