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
     * The first form of the program.
     * 
     * The login form. Form that allows a user to login.
     **/
    public partial class Form1 : Form
    {
        private String username;
        private String password;

        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Invoked when the 'Username Box' content is manipulated.
         **/
        private void username_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            username = box.Text;
        }

        /**
         * Invoked when the 'Password Box' content is manipulated.
         **/
        private void password_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            password = box.Text;
        }

        /**
         * Invoked when the 'Login Button' is clicked.
         * 
         * If the username and password is correct, it will log the player into that account on the system.
         **/
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

            if (manager.currentAccount != null)
            {
                MessageBox.Show("Somebody is already logged in on this instance!");
                return;
            }

            Account account = manager.accounts[username];
            manager.currentAccount = account;
            manager.currentAccount.active = true;
            username_box.Text = "";
            password_box.Text = "";
            new HubForm().Show();
        }

        /**
         * Invoked when the 'Forgot Password?' button is invoked.
         * 
         * Creates a new instance of 'ForgotPasswordForm' form.
         **/
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
