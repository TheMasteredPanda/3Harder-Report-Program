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
    public partial class Form1 : Form
    {
        private String username;
        private String password;

        public Form1()
        {
            InitializeComponent();
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            username = box.Text;
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            password = box.Text;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            if (username == null)
            {
                username_box.BackColor = Color.Red;
                MessageBox.Show("Username cannot be null.");
                return;
            } else
            {
                username_box.BackColor = Color.White;
            }

            if (password == null)
            {
                password_box.BackColor = Color.Red;
                MessageBox.Show("Password cannot be null.");
            } else
            {
                password_box.BackColor = Color.White;
            }

            if (!manager.IsAccountUsername(username))
            {
                username_box.BackColor = Color.Red;
                MessageBox.Show("Username is incorrect.");
                return;
            } else
            {
                username_box.BackColor = Color.White;
            }

            if (!manager.IsPasswordCorrect(username, password))
            {
                password_box.BackColor = Color.Red;
                MessageBox.Show("Password is incorrect.");
                return;
            } else
            {
                password_box.BackColor = Color.White;
            }
            
            manager.currentAccount = manager.accounts[username];
            username_box.Text = "";
            password_box.Text = "";
            new HubForm().Show();
        }

        private void forgot_password_button_Click(object sender, EventArgs e)
        {
            FormCollection collection = Application.OpenForms;

            foreach (Form fc in collection)
            {
                if (!(fc is ForgotPasswordForm))
                {
                    continue;
                }

                return;
            }

            new ForgotPasswordForm().Show();
        }
    }
}
