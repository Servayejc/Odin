using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odin
{
    public class ModuleGlobal
    {
        private string m_User;

        public string User
        {
            get { return m_User; }
            set { m_User = value; }
        }
    }
}