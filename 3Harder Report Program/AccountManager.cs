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

            account.admin = !account.admin;
            MessageBox.Show("Made user " + account.username + " an admin.");
        }

        private void revoke_admin_button_Click(object sender, EventArgs e)
        {

        }




        private void remove_account_button_Click(object sender, EventArgs e)
        {

        }

        private void add_account_button_Click(object sender, EventArgs e)
        {

        }

        private void RefreshAccountList()
        {
            foreach (Account a in DataManager.GetInstance().accounts.Values)
            {
                ListViewItem item = new ListViewItem(a.username);
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                subItem.Add(a.password);
                subItem.Add(a.admin ? "yes" : "no");
            }
        }
    }
}
