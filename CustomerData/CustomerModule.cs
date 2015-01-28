using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gizmox.WebGUI.Forms;
using Odin;

namespace CustomerData
{
    public class CustomerModule:IModule
    {
        #region IModule Members
        private ModuleStates m_state = ModuleStates.Unknown;
        private UserControl maininterface = new ctlMainInterface();

        public string ModuleName
        {
            get { return "Customer Data"; }
        }

        public Guid ModuleID
        {
            get { return new Guid("59005544-A469-4575-B1AA-052934D73724"); }
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
            maininterface = new ctlMainInterface();
        }

        public void Dispose()
        {
            maininterface.Dispose();
        }      


        public int Order
        {
            get { return 1; }
        }

        #endregion
    }
}
