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
using Odin;
using Odin.DataClasses;

#endregion

namespace CustomerData
{
    public enum mode
    {
        edit,
        newitem
    }

    public delegate void OnPopClose();
    public partial class frmPopup : Form
    {
        bool dirty = false;
        bool closing = false;

        private mode m_DialogMode;

        public mode DialogMode
        {
            get { return m_DialogMode; }
            set { m_DialogMode = value; }
        }

        
        private ContactItem m_Contact;

        public ContactItem Contact
        {
            get { return m_Contact; }
        }
        public event OnPopClose ClosePop;
        private IModule Module;
        public frmPopup(IModule Module, ContactItem Contact, mode filemode)
        {
            m_DialogMode = filemode;
            m_Contact = Contact;
            this.Module = Module;
            InitializeComponent();
            UpdateForm(Contact);
        }

        public void UpdateForm(ContactItem Contact)
        {
            m_Contact = Contact;
            txtDetails.Text = Contact.Details;
            txtReason.Text = Contact.Reason;
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
                this.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
                this.Close();
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
                this.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            }
            else
            {
                closing = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = Gizmox.WebGUI.Forms.DialogResult.OK;       
            dirty = false;

            Contact.Details = txtDetails.Text;
            Contact.Reason = txtReason.Text;
            Contact.DateContact = DateTime.Now;
            Contact.UserName = Module.GlobalConfig.User;

            if (ClosePop != null)
                ClosePop();
            closing = true;
            this.Close();
        }


    }


}