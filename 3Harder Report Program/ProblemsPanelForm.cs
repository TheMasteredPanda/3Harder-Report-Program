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
     * Displays all stored reports.
     **/
    public partial class ProblemsPanelForm : Form
    {
        public ProblemsPanelForm()
        {
            InitializeComponent();
        }

        /**
         * Invoked when the 'More Info' button is clicked.
         * 
         * Shows all the information on the selected report.
         **/
        private void info_button_Click(object sender, EventArgs e)
        {
            if (reports_list.SelectedItems[0].SubItems[0] == null)
            {
                MessageBox.Show("No report selected.");
                return;
            }

            DataManager.GetInstance().viewing = DataManager.GetInstance().reports[reports_list.SelectedItems[0].SubItems[0].Text];
            new InfoForm().Show();
        }

        /**
         * Invoked when button 'Delete' is clicked.
         * 
         * Deletea the selected report.
         **/
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (reports_list.SelectedItems[0].SubItems[0] == null)
            {
                MessageBox.Show("No report selected.");
                return;
            }

            string id = reports_list.SelectedItems[0].SubItems[0].Text;
            DataManager.GetInstance().RemoveReport(id);
            RefreshReportList();
        }

        /**
          * Invoked when button 'Resolve' is clicked.
          * 
          * Allows an administrator to resolve a report. The main function of this being that if the
          * problem occurs again another administrator can find the resolution of the problem.
          **/
        private void resolve_button_Click(object sender, EventArgs e)
        {
            if (reports_list.SelectedItems[0] == null)
            {
                MessageBox.Show("No report selected.");
                return;
            }

            DataManager.GetInstance().resolving = DataManager.GetInstance().reports[reports_list.SelectedItems[0].SubItems[0].Text];
            
            foreach (Form f in Application.OpenForms)
            {
                if (f is ResolveForm)
                {
                    return;
                }
            }

            new ResolveForm().Show();
        }

        /**
         * Invoked when the button 'Refresh' is clicked.
         * 
         * Refreshes the report list. It sometimes required when a user submits a
         * report and the problem panel is open.
         **/
        private void refresh_button_Click(object sender, EventArgs e)
        {
            RefreshReportList();
        }

        public void RefreshReportList()
        {
            reports_list.Items.Clear();

            foreach(Report report in DataManager.GetInstance().reports.Values)
            {
                ListViewItem item = new ListViewItem(report.id);
                ListViewItem.ListViewSubItemCollection subList = item.SubItems;
                subList.Add(report.dateTime.ToLongDateString());
                subList.Add(report.submittorName);
                subList.Add(report.roomNumber);
                subList.Add(report.problemType.ToString());
                subList.Add(report.priority.ToString());

                reports_list.Items.Add(item);
            }
        }

        private void ProblemsPanelForm_Load(object sender, EventArgs e)
        {
            RefreshReportList();
        }

        /**
         * An overridden method. WHen this form his closing a new instance of HubForm will be made. 
         **/
        override
        protected void OnClosing(CancelEventArgs e)
        {
            new HubForm().Show();
        }

        private void reports_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
