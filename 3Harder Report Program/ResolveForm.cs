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
    public partial class ResolveForm : Form
    {
        private string description;

        public ResolveForm()
        {
            InitializeComponent();
        }

        private void resolved_description_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text == null || box.Text.Length == 0)
            {
                MessageBox.Show("Description cannot be null.");
                return;
            }

            description = box.Text;
        }

        private void resolve_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            Report report = manager.resolving;
            report.resolved = true;
            Console.WriteLine("Resolved: " + report.resolved);
            report.resolvedBy = manager.currentAccount.username;
            report.resolvedDate = DateTime.Now.ToBinary();
            manager.Resolve(report);
            Close();
        }

        private void ResolveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
