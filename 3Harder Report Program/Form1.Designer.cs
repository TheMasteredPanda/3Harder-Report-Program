namespace _3Harder_Report_Program
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.forgot_password_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(91, 65);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(389, 38);
            this.username_box.TabIndex = 1;
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(91, 159);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(389, 38);
            this.password_box.TabIndex = 2;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(55, 221);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(156, 53);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // forgot_password_button
            // 
            this.forgot_password_button.Location = new System.Drawing.Point(217, 221);
            this.forgot_password_button.Name = "forgot_password_button";
            this.forgot_password_button.Size = new System.Drawing.Size(316, 53);
            this.forgot_password_button.TabIndex = 5;
            this.forgot_password_button.Text = "Forgot Password?";
            this.forgot_password_button.UseVisualStyleBackColor = true;
            this.forgot_password_button.Click += new System.EventHandler(this.forgot_password_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.forgot_password_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button forgot_password_button;
    }
}

