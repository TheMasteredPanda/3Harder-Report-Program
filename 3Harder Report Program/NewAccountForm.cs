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
    public partial class NewAccountForm : Form
    {
        private string username;
        private string password;
        private bool admin;

        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text == null)
            {
                MessageBox.Show("Username cannot be null.");
                box.BackColor = Color.Red;
                return;
            } else
            {
                box.BackColor = Color.White;
            }

            username = box.Text;
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text == null)
            {
                MessageBox.Show("Password cannot be null.");
                box.BackColor = Color.Red;
                return;
            } else
            {
                box.BackColor = Color.White;
            }

            password = box.Text;
        }

        private void admin_account_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            admin = ((CheckBox)sender).Checked;
        }

        private void create_account_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            if (manager.IsAccountUsername(username))
            {
                MessageBox.Show("Username already taken.");
                username_box.BackColor = Color.Red;
                return;
            } else
            {
                username_box.BackColor = Color.White;
            }

            if (manager.IsPasswordTaken(password))
            {
                MessageBox.Show("Password already taken.");
                password_box.BackColor = Color.Red;
                return;
            } else
            {
                password_box.BackColor = Color.White;
            }

            Account account = new Account(username, password, admin);
            manager.AddAccount(account);

            foreach(Form f in Application.OpenForms)
            {
                if (!(f is AccountManager))
                {
                    continue;
                }

                ((AccountManager)f).RefreshAccountList();
            }

            Close();
        }
    }
}
