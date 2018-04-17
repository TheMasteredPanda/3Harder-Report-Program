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
     * The Resolve Form. This form is used to resolve a report. An administrator
     * will be able to write a description of the resolution before clicking 
     * the resolve button to resolve the report.
     **/
    public partial class ResolveForm : Form
    {
        private string description;

        public ResolveForm()
        {
            InitializeComponent();
        }

        /**
         * Invoked when the 'Description' text box content is manipulated.
         **/
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

        /**
         * Invoked when the 'Resolve' button is clicked.
         * 
         * Updates the report with the resolution description, who resolved it, and when it was resolved.
         **/
        private void resolve_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            Report report = manager.resolving;
            report.resolved = true;
            Console.WriteLine("Resolved: " + report.resolved);
            report.resolvedBy = manager.currentAccount.username;
            report.resolvedDate = DateTime.Now.ToBinary();
            report.resolvedDescription = description;
            manager.Resolve(report);
            Close();
        }

        private void ResolveForm_Load(object sender, EventArgs e)
        {
            Report report = DataManager.GetInstance().resolving;

            room_id_box.Text = report.id;
            date.Text = report.dateTime.ToShortDateString();
            name_box.Text = report.submittorName;
            problem_type_box.Text = report.problemType.ToString();
            priority_box.Text = report.priority.ToString();
            time_box.Text = report.dateTime.ToString("hh:mm:ss tt");
            description_box.Text = report.description;
        }

        /**
         * Invoked when this form is closing.
         * 
         * Assigns value 'null' to DataManager#resolving. DataManger#resolving is a field assigned the report that is being resolved by a ResolveForm.
         **/
        override
        protected void OnClosing(CancelEventArgs e)
        {
            DataManager manager = DataManager.GetInstance();
            manager.resolving = null;
        }
    }
}
