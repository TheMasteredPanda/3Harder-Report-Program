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
    public partial class ForgotPasswordForm : Form
    {
        private string username;
        private string newPassword;
        private string adminPassword;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            username = box.Text;
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            newPassword = box.Text;
        }

        private void admin_password_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            adminPassword = box.Text;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            if (username == null)
            {
                username_box.BackColor = Color.Red;
                MessageBox.Show("Username cannot be null.");
                return;
            }

            if (newPassword == null)
            {
                password_box.BackColor = Color.Red;
                MessageBox.Show("Password cannot be null.");
                return;
            } else
            {
                password_box.BackColor = Color.White;
            }

            if (adminPassword == null)
            {
                admin_password_box.BackColor = Color.Red;
                MessageBox.Show("Admin password cannot be null.");
                return;
            } else
            {
                admin_password_box.BackColor = Color.White;
            }

            if (!manager.IsAccountUsername(username))
            {
                username_box.BackColor = Color.Red;
                MessageBox.Show("Username not affiliated with any known account.");
                return;
            } else
            {
                username_box.BackColor = Color.White;
            }

            if (manager.IsPasswordTaken(newPassword))
            {
                password_box.BackColor = Color.Red;
                MessageBox.Show("Password already taken.");
                return;
            } else
            {
                password_box.BackColor = Color.White;
            }

            foreach(Account a in manager.accounts.Values)
            {
                if (!a.password.Equals(newPassword))
                {
                    continue;
                }

                if (!a.admin)
                {
                    admin_password_box.BackColor = Color.Red;
                    MessageBox.Show("Not an admin password.");
                }
            }

            manager.ChangePassword(username, newPassword);
            MessageBox.Show("Changed password for " + username + ".");
            Close();
        }
    }
}
