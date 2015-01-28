using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gizmox.WebGUI.Forms;
using Odin;

namespace Billing
{
    public class CustomerModule:IModule
    {
        #region IModule Members
        private ModuleStates m_state = ModuleStates.Unknown;
        private UserControl maininterface;
        private ModuleGlobal m_ModuleGlobal;

        public string ModuleName
        {
            get { return "Billing"; }
        }

        public Guid ModuleID
        {
            get { return new Guid("C426B36F-81FB-4184-8F18-CD490A1951D7"); }
        }

        public ModuleStates ModuleState
        {
            get { return m_state; }
            set { m_state = value; }
        }

        public bool isPublic
        {
            get { return true; }
        }

        public UserControl MainInterface
        {
            get { return maininterface; }
        }

        public void initialize()
        {
            maininterface = new ctlMainInterface(this);
        }

        public void Dispose()
        {
            maininterface.Dispose();
        }      


        public int Order
        {
            get { return 3; }
        }

        public ModuleGlobal GlobalConfig
        {
            get { return m_ModuleGlobal; }
            set { m_ModuleGlobal = value; }
        }

        #endregion
    }
}
