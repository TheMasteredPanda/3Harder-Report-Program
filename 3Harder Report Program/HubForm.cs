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
    public partial class HubForm : Form
    {

        public HubForm()
        {
            InitializeComponent();
        }

        private void HubForm_Load(object sender, EventArgs e)
        {

        }

        private void report_button_Click(object sender, EventArgs e)
        {
            new ReportProblemForm().Show();
            Close();
        }

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
    }
}
