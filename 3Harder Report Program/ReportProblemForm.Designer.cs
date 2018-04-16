namespace _3Harder_Report_Program
{
    partial class ReportProblemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submit_report_button = new System.Windows.Forms.Button();
            this.room_id_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.room_id_label = new System.Windows.Forms.Label();
            this.severity_label = new System.Windows.Forms.Label();
            this.priority_list = new System.Windows.Forms.ComboBox();
            this.problem_type_label = new System.Windows.Forms.Label();
            this.problem_type_list = new System.Windows.Forms.ComboBox();
            this.description_of_problem_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit_report_button
            // 
            this.submit_report_button.Location = new System.Drawing.Point(528, 367);
            this.submit_report_button.Name = "submit_report_button";
            this.submit_report_button.Size = new System.Drawing.Size(260, 71);
            this.submit_report_button.TabIndex = 0;
            this.submit_report_button.Text = "Submit";
            this.submit_report_button.UseVisualStyleBackColor = true;
            this.submit_report_button.Click += new System.EventHandler(this.submit_report_button_Click);
            // 
            // room_id_box
            // 
            this.room_id_box.Location = new System.Drawing.Point(12, 56);
            this.room_id_box.Name = "room_id_box";
            this.room_id_box.Size = new System.Drawing.Size(242, 38);
            this.room_id_box.TabIndex = 3;
            this.room_id_box.TextChanged += new System.EventHandler(this.room_id_box_TextChanged);
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(289, 50);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(499, 293);
            this.description_box.TabIndex = 4;
            this.description_box.TextChanged += new System.EventHandler(this.description_box_TextChanged);
            // 
            // room_id_label
            // 
            this.room_id_label.AutoSize = true;
            this.room_id_label.Location = new System.Drawing.Point(70, 19);
            this.room_id_label.Name = "room_id_label";
            this.room_id_label.Size = new System.Drawing.Size(124, 32);
            this.room_id_label.TabIndex = 5;
            this.room_id_label.Text = "Room ID";
            // 
            // severity_label
            // 
            this.severity_label.AutoSize = true;
            this.severity_label.Location = new System.Drawing.Point(70, 104);
            this.severity_label.Name = "severity_label";
            this.severity_label.Size = new System.Drawing.Size(118, 32);
            this.severity_label.TabIndex = 6;
            this.severity_label.Text = "Severity";
            // 
            // priority_list
            // 
            this.priority_list.FormattingEnabled = true;
            this.priority_list.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.priority_list.Location = new System.Drawing.Point(12, 142);
            this.priority_list.Name = "priority_list";
            this.priority_list.Size = new System.Drawing.Size(242, 39);
            this.priority_list.TabIndex = 7;
            this.priority_list.SelectedIndexChanged += new System.EventHandler(this.priority_list_SelectedIndexChanged);
            // 
            // problem_type_label
            // 
            this.problem_type_label.AutoSize = true;
            this.problem_type_label.Location = new System.Drawing.Point(32, 193);
            this.problem_type_label.Name = "problem_type_label";
            this.problem_type_label.Size = new System.Drawing.Size(191, 32);
            this.problem_type_label.TabIndex = 8;
            this.problem_type_label.Text = "Problem Type";
            // 
            // problem_type_list
            // 
            this.problem_type_list.FormattingEnabled = true;
            this.problem_type_list.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Telecommunnications"});
            this.problem_type_list.Location = new System.Drawing.Point(12, 232);
            this.problem_type_list.Name = "problem_type_list";
            this.problem_type_list.Size = new System.Drawing.Size(242, 39);
            this.problem_type_list.TabIndex = 9;
            this.problem_type_list.SelectedIndexChanged += new System.EventHandler(this.problem_type_list_SelectedIndexChanged);
            // 
            // description_of_problem_label
            // 
            this.description_of_problem_label.AutoSize = true;
            this.description_of_problem_label.Location = new System.Drawing.Point(346, 9);
            this.description_of_problem_label.Name = "description_of_problem_label";
            this.description_of_problem_label.Size = new System.Drawing.Size(369, 32);
            this.description_of_problem_label.TabIndex = 10;
            this.description_of_problem_label.Text = "Description of Your Problem";
            // 
            // ReportProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description_of_problem_label);
            this.Controls.Add(this.problem_type_list);
            this.Controls.Add(this.problem_type_label);
            this.Controls.Add(this.priority_list);
            this.Controls.Add(this.severity_label);
            this.Controls.Add(this.room_id_label);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.room_id_box);
            this.Controls.Add(this.submit_report_button);
            this.Name = "ReportProblemForm";
            this.Text = "ReportProblemForm";
            this.Load += new System.EventHandler(this.ReportProblemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_report_button;
        private System.Windows.Forms.TextBox room_id_box;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.Label room_id_label;
        private System.Windows.Forms.Label severity_label;
        private System.Windows.Forms.ComboBox priority_list;
        private System.Windows.Forms.Label problem_type_label;
        private System.Windows.Forms.ComboBox problem_type_list;
        private System.Windows.Forms.Label description_of_problem_label;
    }
}