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
     * The Hub Form, used for navigating between the Account Manager, Problems Panel, and Reporting a Problem.
     **/
    public partial class HubForm : Form
    {

        public HubForm()
        {
            InitializeComponent();
        }

        private void HubForm_Load(object sender, EventArgs e)
        {

        }

        /**
         * Invoked when the 'Report' button is clicked.
         * 
         * Creates a new instance of 'ReportProblemForm'.
         **/
        private void report_button_Click(object sender, EventArgs e)
        {
            new ReportProblemForm().Show();
            Close();
        }

        /**
         * Invoked when the 'Problems' button is clicked.
         * 
         * Creates a new instance of 'ProblemsPanelForm'.
         **/
        private void problems_button_Click(object sender, EventArgs e)
        {
            if (!DataManager.GetInstance().currentAccount.admin)
            {
                MessageBox.Show("You must be an admin to get access to this.");
                return;
            }

            new ProblemsPanelForm().Show();
            Close();
        }

        /**
         * INvoked when the 'Account Manager' button is clicked.
         * 
         * Creates a new instance of 'Account Manager'.
         **/
        private void account_manager_button_Click(object sender, EventArgs e)
        {
            if (!DataManager.GetInstance().currentAccount.admin)
            {
                MessageBox.Show("You must be an admin to get access to this.");
                return;
            }

            new AccountManager().Show();
            Close();
        }

        /**
         * Logs the current user off when the 'Log off' button is clicked.
         **/
        private void log_off_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();
            manager.currentAccount = null;
            Close();
        }
    }
}
