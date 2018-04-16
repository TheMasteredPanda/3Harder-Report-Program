namespace _3Harder_Report_Program
{
    partial class ForgotPasswordForm
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
            this.password_box = new System.Windows.Forms.TextBox();
            this.admin_password_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(18, 67);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(328, 38);
            this.username_box.TabIndex = 0;
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(18, 175);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(328, 38);
            this.password_box.TabIndex = 1;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // admin_password_box
            // 
            this.admin_password_box.Location = new System.Drawing.Point(17, 275);
            this.admin_password_box.Name = "admin_password_box";
            this.admin_password_box.Size = new System.Drawing.Size(328, 38);
            this.admin_password_box.TabIndex = 2;
            this.admin_password_box.TextChanged += new System.EventHandler(this.admin_password_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "An Administrators Password";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(18, 336);
            this.reset_button.Name = "reset_button";
            this.reset_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reset_button.Size = new System.Drawing.Size(344, 47);
            this.reset_button.TabIndex = 6;
            this.reset_button.Text = "Reset Password";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 399);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_password_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox admin_password_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reset_button;
    }
}