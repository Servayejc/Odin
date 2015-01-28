#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Common.Resources;
using Gizmox.WebGUI.Forms;
using Odin;
using Odin.DataClasses;

#endregion

namespace Viking
{
    public partial class ctlMainInterface : UserControl
    {
        List<ImageResourceHandle> Images = new List<ImageResourceHandle>();
        IModule Module;
        int lastidx = -1;
        public ctlMainInterface(IModule Module)
        {
            this.Module = Module;
            InitializeComponent();
            Images.Add(new ImageResourceHandle("Viking.gif"));
            Images.Add(new ImageResourceHandle("graphics-vikings-958347.gif"));
            Images.Add(new ImageResourceHandle("image01.gif"));
            Images.Add(new ImageResourceHandle("laughing11.gif"));
            Random rnd = new Random();
            int idx = rnd.Next(0, 3);
            pictureBox1.Image = Images[idx];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int idx = rnd.Next(0, 3);
            while (idx == lastidx)
            {
                idx = rnd.Next(0, 3);
            }
            lastidx = idx;
            pictureBox1.Image = Images[idx];
        }

    }
}