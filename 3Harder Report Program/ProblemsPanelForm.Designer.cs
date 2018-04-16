namespace _3Harder_Report_Program
{
    partial class ProblemsPanelForm
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
            this.search_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reports_list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubmittorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProblemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.resolve_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(12, 59);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(229, 38);
            this.search_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // reports_list
            // 
            this.reports_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Date,
            this.SubmittorName,
            this.RoomID,
            this.ProblemType,
            this.Priority});
            this.reports_list.FullRowSelect = true;
            this.reports_list.GridLines = true;
            this.reports_list.Location = new System.Drawing.Point(260, 59);
            this.reports_list.Name = "reports_list";
            this.reports_list.Size = new System.Drawing.Size(862, 379);
            this.reports_list.TabIndex = 2;
            this.reports_list.UseCompatibleStateImageBehavior = false;
            this.reports_list.View = System.Windows.Forms.View.Details;
            this.reports_list.SelectedIndexChanged += new System.EventHandler(this.reports_list_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Report ID";
            this.ID.Width = 137;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 81;
            // 
            // SubmittorName
            // 
            this.SubmittorName.Text = "Submittor Name";
            this.SubmittorName.Width = 207;
            // 
            // RoomID
            // 
            this.RoomID.Text = "Room ID";
            this.RoomID.Width = 125;
            // 
            // ProblemType
            // 
            this.ProblemType.Text = "Problem Type";
            this.ProblemType.Width = 200;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 108;
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(12, 103);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(229, 63);
            this.info_button.TabIndex = 3;
            this.info_button.Text = "More Info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(12, 172);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(229, 71);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Delete Report";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // resolve_button
            // 
            this.resolve_button.Location = new System.Drawing.Point(12, 249);
            this.resolve_button.Name = "resolve_button";
            this.resolve_button.Size = new System.Drawing.Size(229, 72);
            this.resolve_button.TabIndex = 5;
            this.resolve_button.Text = "Resolve";
            this.resolve_button.UseVisualStyleBackColor = true;
            this.resolve_button.Click += new System.EventHandler(this.resolve_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(12, 327);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(229, 70);
            this.refresh_button.TabIndex = 6;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // ProblemsPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.resolve_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.reports_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_box);
            this.Name = "ProblemsPanelForm";
            this.Text = "ProblemsPanelForm";
            this.Load += new System.EventHandler(this.ProblemsPanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView reports_list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader SubmittorName;
        private System.Windows.Forms.ColumnHeader RoomID;
        private System.Windows.Forms.ColumnHeader ProblemType;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button resolve_button;
        private System.Windows.Forms.Button refresh_button;
    }
}