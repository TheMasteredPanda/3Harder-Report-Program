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
    public partial class ProblemsPanelForm : Form
    {
        public ProblemsPanelForm()
        {
            InitializeComponent();
        }

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

        private void resolve_button_Click(object sender, EventArgs e)
        {
            if (reports_list.SelectedItems[0].SubItems[0] == null)
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
