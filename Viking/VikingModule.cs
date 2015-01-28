using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gizmox.WebGUI.Forms;
using Odin;

namespace Viking
{
    public class CustomerModule:IModule
    {
        #region IModule Members
        private ModuleStates m_state = ModuleStates.Unknown;
        private UserControl maininterface;
        private ModuleGlobal m_ModuleGlobal;

        public string ModuleName
        {
            get { return "VIKINGS!"; }
        }

        public Guid ModuleID
        {
            get { return new Guid("C2647FCB-5485-4EB9-921C-31039FD4D9BC"); }
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
            get { return 2; }
        }

        #endregion


        #region IModule Members


        public ModuleGlobal GlobalConfig
        {
            get { return m_ModuleGlobal; }
            set { m_ModuleGlobal = value; }
        }

        #endregion
    }
}
