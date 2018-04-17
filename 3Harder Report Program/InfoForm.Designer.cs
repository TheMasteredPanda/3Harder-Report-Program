namespace _3Harder_Report_Program
{
    partial class InfoForm
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
            this.report_id_box = new System.Windows.Forms.TextBox();
            this.date_box = new System.Windows.Forms.TextBox();
            this.submittor_name_box = new System.Windows.Forms.TextBox();
            this.room_id_box = new System.Windows.Forms.TextBox();
            this.problem_type_box = new System.Windows.Forms.TextBox();
            this.priority_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.resolved_description_box = new System.Windows.Forms.TextBox();
            this.resolved_box = new System.Windows.Forms.TextBox();
            this.resolved_by_box = new System.Windows.Forms.TextBox();
            this.resolved_date = new System.Windows.Forms.TextBox();
            this.resolved_label = new System.Windows.Forms.Label();
            this.resolved_by_label = new System.Windows.Forms.Label();
            this.resolved_date_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.priority_label = new System.Windows.Forms.Label();
            this.report_id_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.room_id_label = new System.Windows.Forms.Label();
            this.problem_type_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time_box = new System.Windows.Forms.TextBox();
            this.time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // report_id_box
            // 
            this.report_id_box.Location = new System.Drawing.Point(12, 45);
            this.report_id_box.Name = "report_id_box";
            this.report_id_box.ReadOnly = true;
            this.report_id_box.Size = new System.Drawing.Size(186, 38);
            this.report_id_box.TabIndex = 0;
            // 
            // date_box
            // 
            this.date_box.Location = new System.Drawing.Point(12, 127);
            this.date_box.Name = "date_box";
            this.date_box.ReadOnly = true;
            this.date_box.Size = new System.Drawing.Size(186, 38);
            this.date_box.TabIndex = 1;
            // 
            // submittor_name_box
            // 
            this.submittor_name_box.Location = new System.Drawing.Point(12, 206);
            this.submittor_name_box.Name = "submittor_name_box";
            this.submittor_name_box.ReadOnly = true;
            this.submittor_name_box.Size = new System.Drawing.Size(186, 38);
            this.submittor_name_box.TabIndex = 2;
            // 
            // room_id_box
            // 
            this.room_id_box.Location = new System.Drawing.Point(12, 300);
            this.room_id_box.Name = "room_id_box";
            this.room_id_box.ReadOnly = true;
            this.room_id_box.Size = new System.Drawing.Size(186, 38);
            this.room_id_box.TabIndex = 3;
            // 
            // problem_type_box
            // 
            this.problem_type_box.Location = new System.Drawing.Point(12, 386);
            this.problem_type_box.Name = "problem_type_box";
            this.problem_type_box.ReadOnly = true;
            this.problem_type_box.Size = new System.Drawing.Size(186, 38);
            this.problem_type_box.TabIndex = 4;
            // 
            // priority_box
            // 
            this.priority_box.Location = new System.Drawing.Point(245, 45);
            this.priority_box.Name = "priority_box";
            this.priority_box.ReadOnly = true;
            this.priority_box.Size = new System.Drawing.Size(186, 38);
            this.priority_box.TabIndex = 5;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(245, 146);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.ReadOnly = true;
            this.description_box.Size = new System.Drawing.Size(543, 288);
            this.description_box.TabIndex = 6;
            // 
            // resolved_description_box
            // 
            this.resolved_description_box.Location = new System.Drawing.Point(12, 587);
            this.resolved_description_box.Multiline = true;
            this.resolved_description_box.Name = "resolved_description_box";
            this.resolved_description_box.ReadOnly = true;
            this.resolved_description_box.Size = new System.Drawing.Size(776, 205);
            this.resolved_description_box.TabIndex = 7;
            this.resolved_description_box.TextChanged += new System.EventHandler(this.resolved_description_box_TextChanged);
            // 
            // resolved_box
            // 
            this.resolved_box.Location = new System.Drawing.Point(12, 495);
            this.resolved_box.Name = "resolved_box";
            this.resolved_box.ReadOnly = true;
            this.resolved_box.Size = new System.Drawing.Size(186, 38);
            this.resolved_box.TabIndex = 8;
            // 
            // resolved_by_box
            // 
            this.resolved_by_box.Location = new System.Drawing.Point(304, 495);
            this.resolved_by_box.Name = "resolved_by_box";
            this.resolved_by_box.ReadOnly = true;
            this.resolved_by_box.Size = new System.Drawing.Size(186, 38);
            this.resolved_by_box.TabIndex = 9;
            // 
            // resolved_date
            // 
            this.resolved_date.Location = new System.Drawing.Point(602, 495);
            this.resolved_date.Name = "resolved_date";
            this.resolved_date.ReadOnly = true;
            this.resolved_date.Size = new System.Drawing.Size(186, 38);
            this.resolved_date.TabIndex = 10;
            // 
            // resolved_label
            // 
            this.resolved_label.AutoSize = true;
            this.resolved_label.Location = new System.Drawing.Point(39, 460);
            this.resolved_label.Name = "resolved_label";
            this.resolved_label.Size = new System.Drawing.Size(134, 32);
            this.resolved_label.TabIndex = 11;
            this.resolved_label.Text = "Resolved";
            // 
            // resolved_by_label
            // 
            this.resolved_by_label.AutoSize = true;
            this.resolved_by_label.Location = new System.Drawing.Point(310, 462);
            this.resolved_by_label.Name = "resolved_by_label";
            this.resolved_by_label.Size = new System.Drawing.Size(174, 32);
            this.resolved_by_label.TabIndex = 12;
            this.resolved_by_label.Text = "Resolved By";
            // 
            // resolved_date_label
            // 
            this.resolved_date_label.AutoSize = true;
            this.resolved_date_label.Location = new System.Drawing.Point(596, 460);
            this.resolved_date_label.Name = "resolved_date_label";
            this.resolved_date_label.Size = new System.Drawing.Size(201, 32);
            this.resolved_date_label.TabIndex = 13;
            this.resolved_date_label.Text = "Resolved Date";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(433, 102);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(158, 32);
            this.description_label.TabIndex = 14;
            this.description_label.Text = "Description";
            // 
            // priority_label
            // 
            this.priority_label.AutoSize = true;
            this.priority_label.Location = new System.Drawing.Point(281, 10);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(104, 32);
            this.priority_label.TabIndex = 15;
            this.priority_label.Text = "Priority";
            // 
            // report_id_label
            // 
            this.report_id_label.AutoSize = true;
            this.report_id_label.Location = new System.Drawing.Point(39, 10);
            this.report_id_label.Name = "report_id_label";
            this.report_id_label.Size = new System.Drawing.Size(134, 32);
            this.report_id_label.TabIndex = 16;
            this.report_id_label.Text = "Report ID";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(67, 92);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(75, 32);
            this.date_label.TabIndex = 17;
            this.date_label.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Submittor Name";
            // 
            // room_id_label
            // 
            this.room_id_label.AutoSize = true;
            this.room_id_label.Location = new System.Drawing.Point(39, 265);
            this.room_id_label.Name = "room_id_label";
            this.room_id_label.Size = new System.Drawing.Size(124, 32);
            this.room_id_label.TabIndex = 19;
            this.room_id_label.Text = "Room ID";
            // 
            // problem_type_label
            // 
            this.problem_type_label.AutoSize = true;
            this.problem_type_label.Location = new System.Drawing.Point(12, 351);
            this.problem_type_label.Name = "problem_type_label";
            this.problem_type_label.Size = new System.Drawing.Size(191, 32);
            this.problem_type_label.TabIndex = 20;
            this.problem_type_label.Text = "Problem Type";
            this.problem_type_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Report Description";
            // 
            // time_box
            // 
            this.time_box.Location = new System.Drawing.Point(474, 45);
            this.time_box.Name = "time_box";
            this.time_box.ReadOnly = true;
            this.time_box.Size = new System.Drawing.Size(186, 38);
            this.time_box.TabIndex = 22;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(519, 7);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(78, 32);
            this.time_label.TabIndex = 23;
            this.time_label.Text = "Time";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 804);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.time_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.problem_type_label);
            this.Controls.Add(this.room_id_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.report_id_label);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.resolved_date_label);
            this.Controls.Add(this.resolved_by_label);
            this.Controls.Add(this.resolved_label);
            this.Controls.Add(this.resolved_date);
            this.Controls.Add(this.resolved_by_box);
            this.Controls.Add(this.resolved_box);
            this.Controls.Add(this.resolved_description_box);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.priority_box);
            this.Controls.Add(this.problem_type_box);
            this.Controls.Add(this.room_id_box);
            this.Controls.Add(this.submittor_name_box);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.report_id_box);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox report_id_box;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.TextBox submittor_name_box;
        private System.Windows.Forms.TextBox room_id_box;
        private System.Windows.Forms.TextBox problem_type_box;
        private System.Windows.Forms.TextBox priority_box;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.TextBox resolved_description_box;
        private System.Windows.Forms.TextBox resolved_box;
        private System.Windows.Forms.TextBox resolved_by_box;
        private System.Windows.Forms.TextBox resolved_date;
        private System.Windows.Forms.Label resolved_label;
        private System.Windows.Forms.Label resolved_by_label;
        private System.Windows.Forms.Label resolved_date_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label report_id_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label room_id_label;
        private System.Windows.Forms.Label problem_type_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_box;
        private System.Windows.Forms.Label time_label;
    }
}