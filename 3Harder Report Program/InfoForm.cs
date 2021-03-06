﻿using System;
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
     * The Information Form. Used to display all the information on the selected report selected in ProblemsPanelForm.
     **/
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            Report report = DataManager.GetInstance().viewing;

            report_id_box.Text = report.id;
            date_box.Text = report.dateTime.ToShortDateString();
            submittor_name_box.Text = report.submittorName;
            room_id_box.Text = report.roomNumber;
            description_box.Text = report.description;
            problem_type_box.Text = report.problemType.ToString();
            priority_box.Text = report.priority.ToString();
            time_box.Text = report.dateTime.ToString("HH:mm:ss tt");
            resolved_box.Text = report.resolved ? "yes" : "no";
            resolved_by_box.Text = report.resolvedBy == null ? "N/A" : report.resolvedBy;
            Console.WriteLine("Resolved Date: " + report.resolvedDate);
            resolved_date.Text = report.resolvedDate != -1 ? DateTime.FromBinary(report.resolvedDate).ToShortDateString() : "N/A";
            resolved_description_box.Text = report.resolvedDescription == null ? "N/A" : report.resolvedDescription;
        }

        /**
         * Invoked when this form is closing.
         * 
         * Assigns value 'null' to DataManager#viewing. DataManager#viewing is a field that stores the report currently being viewed in a InfoForm.
         **/
        override
        protected void OnClosing(CancelEventArgs e)
        {
            DataManager manager = DataManager.GetInstance();
            manager.viewing = null;
        }

        private void resolved_description_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
