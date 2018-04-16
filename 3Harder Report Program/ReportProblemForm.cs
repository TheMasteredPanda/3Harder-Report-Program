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
    public partial class ReportProblemForm : Form
    {
        private Priority priority;
        private ProblemType type;
        private string roomId;
        private string description;

        public ReportProblemForm()
        {
            InitializeComponent();
        }

        private void ReportProblemForm_Load(object sender, EventArgs e)
        {

        }

        override
        protected void OnClosing(CancelEventArgs e)
        {
            new HubForm().Show();
        }

        private void room_id_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text == null)
            {
                room_id_box.BackColor = Color.Red;
                MessageBox.Show("Room ID cannot be null.");
                return;
            }

            roomId = box.Text;
        }

        private void priority_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Enum.TryParse(priority_list.GetItemText(priority_list.SelectedItem).ToUpper(), out priority);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("A priority must be picked.");
                priority_list.BackColor = Color.Red;
                return;
            }

            priority_list.BackColor = Color.White;
        }

        private void problem_type_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Enum.TryParse(problem_type_list.GetItemText(problem_type_list.SelectedItem).ToUpper(), out type);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("A type must be picked.");
                problem_type_list.BackColor = Color.Red;
                return;
            }

            problem_type_list.BackColor = Color.White;
        }

        private void description_box_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text == null)
            {
                MessageBox.Show("Description cannot be null.");
                description_box.BackColor = Color.Red;
                return;
            }

            description_box.BackColor = Color.White;

            description = box.Text;
        }

        private void submit_report_button_Click(object sender, EventArgs e)
        {
            DataManager manager = DataManager.GetInstance();

            Account account = manager.currentAccount;

            Report report = new Report(
                null,
                DateTime.Now,
                account.username,
                roomId,
                type,
                priority,
                description,
                false,
                null,
                null,
                -1 
                );

            manager.Insert(report);
            Close();
        }
    }
}
