namespace _3Harder_Report_Program
{
    partial class AccountManager
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
            System.Windows.Forms.ColumnHeader headerAdmin;
            this.account_list = new System.Windows.Forms.ListView();
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remove_account_button = new System.Windows.Forms.Button();
            this.add_account_button = new System.Windows.Forms.Button();
            this.make_admin_button = new System.Windows.Forms.Button();
            this.revoke_admin_button = new System.Windows.Forms.Button();
            headerAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // headerAdmin
            // 
            headerAdmin.Text = "Admin";
            headerAdmin.Width = 196;
            // 
            // account_list
            // 
            this.account_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerName,
            this.headerPassword,
            headerAdmin});
            this.account_list.Location = new System.Drawing.Point(12, 137);
            this.account_list.Name = "account_list";
            this.account_list.Size = new System.Drawing.Size(620, 301);
            this.account_list.TabIndex = 0;
            this.account_list.UseCompatibleStateImageBehavior = false;
            this.account_list.View = System.Windows.Forms.View.Details;
            this.account_list.SelectedIndexChanged += new System.EventHandler(this.account_list_SelectedIndexChanged);
            // 
            // headerName
            // 
            this.headerName.Text = "Name";
            this.headerName.Width = 156;
            // 
            // headerPassword
            // 
            this.headerPassword.Text = "Password";
            this.headerPassword.Width = 243;
            // 
            // remove_account_button
            // 
            this.remove_account_button.Location = new System.Drawing.Point(12, 12);
            this.remove_account_button.Name = "remove_account_button";
            this.remove_account_button.Size = new System.Drawing.Size(277, 47);
            this.remove_account_button.TabIndex = 1;
            this.remove_account_button.Text = "Remove Account";
            this.remove_account_button.UseVisualStyleBackColor = true;
            this.remove_account_button.Click += new System.EventHandler(this.remove_account_button_Click);
            // 
            // add_account_button
            // 
            this.add_account_button.Location = new System.Drawing.Point(355, 12);
            this.add_account_button.Name = "add_account_button";
            this.add_account_button.Size = new System.Drawing.Size(277, 47);
            this.add_account_button.TabIndex = 2;
            this.add_account_button.Text = "Add Account";
            this.add_account_button.UseVisualStyleBackColor = true;
            this.add_account_button.Click += new System.EventHandler(this.add_account_button_Click);
            // 
            // make_admin_button
            // 
            this.make_admin_button.Location = new System.Drawing.Point(12, 76);
            this.make_admin_button.Name = "make_admin_button";
            this.make_admin_button.Size = new System.Drawing.Size(277, 47);
            this.make_admin_button.TabIndex = 3;
            this.make_admin_button.Text = "Made Admin";
            this.make_admin_button.UseVisualStyleBackColor = true;
            this.make_admin_button.Click += new System.EventHandler(this.make_admin_button_Click);
            // 
            // revoke_admin_button
            // 
            this.revoke_admin_button.Location = new System.Drawing.Point(355, 84);
            this.revoke_admin_button.Name = "revoke_admin_button";
            this.revoke_admin_button.Size = new System.Drawing.Size(277, 47);
            this.revoke_admin_button.TabIndex = 4;
            this.revoke_admin_button.Text = "Revoke Admin";
            this.revoke_admin_button.UseVisualStyleBackColor = true;
            this.revoke_admin_button.Click += new System.EventHandler(this.revoke_admin_button_Click);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.revoke_admin_button);
            this.Controls.Add(this.make_admin_button);
            this.Controls.Add(this.add_account_button);
            this.Controls.Add(this.remove_account_button);
            this.Controls.Add(this.account_list);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView account_list;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerPassword;
        private System.Windows.Forms.Button remove_account_button;
        private System.Windows.Forms.Button add_account_button;
        private System.Windows.Forms.Button make_admin_button;
        private System.Windows.Forms.Button revoke_admin_button;
    }
}