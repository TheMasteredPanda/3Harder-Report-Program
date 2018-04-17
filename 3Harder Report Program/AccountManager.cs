using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Harder_Report_Program
{
    /**
     * Form for managing accounts. Here you'll be able to create, delete, promote, and demote accounts.
     **/
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            RefreshAccountList();
        }

        private void account_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /**
         * Invoked when the 'Make Admin' button is clicked.
         * 
         * Makes a standard account an admin account.
         **/
        private void make_admin_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            Account account = manager.accounts[account_list.SelectedItems[0].SubItems[0].Text];
            
            if (account.admin)
            {
                MessageBox.Show("User " + account.username + " is already an admin");
                return;
            }

            manager.SetAdmin(account.username, true);
            MessageBox.Show("Made user " + account.username + " an admin.");
            RefreshAccountList();
        }

        /**
         * Invoked when the 'Remove Admin' button is clicked.
         * 
         * Demotes an admin account to a standard account.
         **/
        private void revoke_admin_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            if (account_list.SelectedItems[0].SubItems[0] == null)
            {
                return;
            }

            Account account = manager.accounts[account_list.SelectedItems[0].SubItems[0].Text];

            if (!account.admin)
            {
                MessageBox.Show("User " + account.username + " isn't an admin.");
                return;
            }

            manager.SetAdmin(account.username, false);
            MessageBox.Show("User " + account.username + " is no longer an admin.");
            RefreshAccountList();
        }

        /**
         * Invoked when the 'Remove Account' button is clicked.
         * 
         * Removes an account from the system.
         **/
        private void remove_account_button_Click(object sender, EventArgs e)
        {
            if (account_list.SelectedItems[0].SubItems[0] == null)
            {
                return;
            }

            DataManager manager = DataManager.GetInstance();
            Account account = manager.accounts[account_list.SelectedItems[0].SubItems[0].Text];

            if (account.active)
            {
                MessageBox.Show("You cannot remove an account that is active. Ask the account holder to get off of the account before deleting it.");
                return;
            }

            manager.RemoveAccount(account.username);
            RefreshAccountList();
        }

        /**
         * Invoked when the 'Add Account' button is clicked.
         * 
         * Creates, and opens, a new instance of the 'NewAccountForm' form.
         **/
        private void add_account_button_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (!(f is NewAccountForm))
                {
                    continue;
                }

                return;
            }

            new NewAccountForm().Show();
        }

        /**
         * Refreshes the list of content shown in the 'Account List'.
         **/
        public void RefreshAccountList()
        {
            account_list.Items.Clear();

            foreach (Account a in DataManager.GetInstance().accounts.Values)
            {
                ListViewItem item = new ListViewItem(a.username);
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                subItem.Add(a.password);
                subItem.Add(a.admin ? "yes" : "no");
                account_list.Items.Add(item);
            }
        }

        /**
         * Invoked when this form is closing.
         * 
         * Opens a new instance of HubForm when this form is closing.
         **/
        override
        protected void OnClosing(CancelEventArgs e)
        {
            new HubForm().Show();
        }
    }
}
