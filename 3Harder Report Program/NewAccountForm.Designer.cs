namespace _3Harder_Report_Program
{
    partial class NewAccountForm
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
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.admin_account_checkbox = new System.Windows.Forms.CheckBox();
            this.create_account_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(12, 56);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(268, 38);
            this.username_box.TabIndex = 0;
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(12, 151);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(268, 38);
            this.password_box.TabIndex = 2;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(65, 116);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(139, 32);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Password";
            // 
            // admin_account_checkbox
            // 
            this.admin_account_checkbox.AutoSize = true;
            this.admin_account_checkbox.Location = new System.Drawing.Point(18, 220);
            this.admin_account_checkbox.Name = "admin_account_checkbox";
            this.admin_account_checkbox.Size = new System.Drawing.Size(260, 36);
            this.admin_account_checkbox.TabIndex = 4;
            this.admin_account_checkbox.Text = "Admin Account?";
            this.admin_account_checkbox.UseVisualStyleBackColor = true;
            this.admin_account_checkbox.CheckedChanged += new System.EventHandler(this.admin_account_checkbox_CheckedChanged);
            // 
            // create_account_button
            // 
            this.create_account_button.Location = new System.Drawing.Point(18, 271);
            this.create_account_button.Name = "create_account_button";
            this.create_account_button.Size = new System.Drawing.Size(260, 46);
            this.create_account_button.TabIndex = 5;
            this.create_account_button.Text = "Create Account";
            this.create_account_button.UseVisualStyleBackColor = true;
            this.create_account_button.Click += new System.EventHandler(this.create_account_button_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 346);
            this.Controls.Add(this.create_account_button);
            this.Controls.Add(this.admin_account_checkbox);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_box);
            this.Name = "NewAccountForm";
            this.Text = "NewAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.CheckBox admin_account_checkbox;
        private System.Windows.Forms.Button create_account_button;
    }
}