#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Odin.DataClasses;

#endregion

namespace CustomerData
{
    public delegate void OnPopClose();
    public partial class frmPopup : Form
    {
        bool dirty = false;
        bool closing = false;
        private ContactItem m_Contact;

        public ContactItem Contact
        {
            get { return m_Contact; }
        }
        public event OnPopClose ClosePop;
        public frmPopup()
        {
            InitializeComponent();
        }

        public void UpdateForm(ContactItem Contact)
        {
            m_Contact = Contact;
        }

        private void frmPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
                btnCancel_Click(sender, new EventArgs());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (!dirty)
            {
                if (ClosePop != null)
                    ClosePop();
                closing = true;
            }
            else
            {
                MessageBox.Show("You have not saved your modifications. Are you certain you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, new EventHandler(ConfirmAction));
            }
        }

        private void ConfirmAction(object sender, EventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.Yes)
            {
                if (ClosePop != null)
                    ClosePop();
                closing = true;
                this.Close();
            }
            else
            {
                closing = false;
            }
        }


    }


}