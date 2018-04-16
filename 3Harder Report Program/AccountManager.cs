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
    }
}
