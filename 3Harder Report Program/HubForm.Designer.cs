namespace _3Harder_Report_Program
{
    partial class HubForm
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
            this.problems_button = new System.Windows.Forms.Button();
            this.report_button = new System.Windows.Forms.Button();
            this.account_manager_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // problems_button
            // 
            this.problems_button.Location = new System.Drawing.Point(12, 159);
            this.problems_button.Name = "problems_button";
            this.problems_button.Size = new System.Drawing.Size(357, 141);
            this.problems_button.TabIndex = 0;
            this.problems_button.Text = "Problems";
            this.problems_button.UseVisualStyleBackColor = true;
            this.problems_button.Click += new System.EventHandler(this.problems_button_Click);
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(12, 12);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(357, 141);
            this.report_button.TabIndex = 0;
            this.report_button.Text = "Report a Problem ";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // account_manager_button
            // 
            this.account_manager_button.Location = new System.Drawing.Point(12, 306);
            this.account_manager_button.Name = "account_manager_button";
            this.account_manager_button.Size = new System.Drawing.Size(357, 141);
            this.account_manager_button.TabIndex = 1;
            this.account_manager_button.Text = "Account Manager";
            this.account_manager_button.UseVisualStyleBackColor = true;
            this.account_manager_button.Click += new System.EventHandler(this.account_manager_button_Click);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 460);
            this.Controls.Add(this.account_manager_button);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.problems_button);
            this.Name = "HubForm";
            this.Text = "HubForm";
            this.Load += new System.EventHandler(this.HubForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button problems_button;
        private System.Windows.Forms.Button report_button;
        private System.Windows.Forms.Button account_manager_button;
    }
}