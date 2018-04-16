namespace _3Harder_Report_Program
{
    partial class ResolveForm
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
            this.resolve_button = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.room_id_box = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.problem_type_box = new System.Windows.Forms.TextBox();
            this.priority_box = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.room_id_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.problem_type_label = new System.Windows.Forms.Label();
            this.priority_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.resolved_description_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resolve_button
            // 
            this.resolve_button.Location = new System.Drawing.Point(12, 433);
            this.resolve_button.Name = "resolve_button";
            this.resolve_button.Size = new System.Drawing.Size(195, 58);
            this.resolve_button.TabIndex = 0;
            this.resolve_button.Text = "Resolve";
            this.resolve_button.UseVisualStyleBackColor = true;
            this.resolve_button.Click += new System.EventHandler(this.resolve_button_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(12, 206);
            this.name_box.Name = "name_box";
            this.name_box.ReadOnly = true;
            this.name_box.Size = new System.Drawing.Size(187, 38);
            this.name_box.TabIndex = 1;
            // 
            // room_id_box
            // 
            this.room_id_box.Location = new System.Drawing.Point(12, 49);
            this.room_id_box.Name = "room_id_box";
            this.room_id_box.ReadOnly = true;
            this.room_id_box.Size = new System.Drawing.Size(187, 38);
            this.room_id_box.TabIndex = 2;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(12, 128);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(187, 38);
            this.date.TabIndex = 3;
            // 
            // problem_type_box
            // 
            this.problem_type_box.Location = new System.Drawing.Point(12, 289);
            this.problem_type_box.Name = "problem_type_box";
            this.problem_type_box.ReadOnly = true;
            this.problem_type_box.Size = new System.Drawing.Size(187, 38);
            this.problem_type_box.TabIndex = 4;
            // 
            // priority_box
            // 
            this.priority_box.Location = new System.Drawing.Point(12, 367);
            this.priority_box.Name = "priority_box";
            this.priority_box.ReadOnly = true;
            this.priority_box.Size = new System.Drawing.Size(187, 38);
            this.priority_box.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(541, 166);
            this.textBox1.TabIndex = 6;
            // 
            // room_id_label
            // 
            this.room_id_label.AutoSize = true;
            this.room_id_label.Location = new System.Drawing.Point(42, 14);
            this.room_id_label.Name = "room_id_label";
            this.room_id_label.Size = new System.Drawing.Size(124, 32);
            this.room_id_label.TabIndex = 7;
            this.room_id_label.Text = "Room ID";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(63, 93);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(75, 32);
            this.date_label.TabIndex = 8;
            this.date_label.Text = "Date";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(63, 171);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(90, 32);
            this.name_label.TabIndex = 9;
            this.name_label.Text = "Name";
            // 
            // problem_type_label
            // 
            this.problem_type_label.AutoSize = true;
            this.problem_type_label.Location = new System.Drawing.Point(8, 254);
            this.problem_type_label.Name = "problem_type_label";
            this.problem_type_label.Size = new System.Drawing.Size(191, 32);
            this.problem_type_label.TabIndex = 10;
            this.problem_type_label.Text = "Problem Type";
            // 
            // priority_label
            // 
            this.priority_label.AutoSize = true;
            this.priority_label.Location = new System.Drawing.Point(54, 332);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(104, 32);
            this.priority_label.TabIndex = 11;
            this.priority_label.Text = "Priority";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(411, 9);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(158, 32);
            this.description_label.TabIndex = 12;
            this.description_label.Text = "Description";
            // 
            // resolved_description_box
            // 
            this.resolved_description_box.Location = new System.Drawing.Point(224, 278);
            this.resolved_description_box.Multiline = true;
            this.resolved_description_box.Name = "resolved_description_box";
            this.resolved_description_box.Size = new System.Drawing.Size(541, 213);
            this.resolved_description_box.TabIndex = 13;
            this.resolved_description_box.TextChanged += new System.EventHandler(this.resolved_description_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Resolved Description";
            // 
            // ResolveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolved_description_box);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.problem_type_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.room_id_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.priority_box);
            this.Controls.Add(this.problem_type_box);
            this.Controls.Add(this.date);
            this.Controls.Add(this.room_id_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.resolve_button);
            this.Name = "ResolveForm";
            this.Text = "ResolveForm";
            this.Load += new System.EventHandler(this.ResolveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resolve_button;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox room_id_box;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox problem_type_box;
        private System.Windows.Forms.TextBox priority_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label room_id_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label problem_type_label;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox resolved_description_box;
        private System.Windows.Forms.Label label1;
    }
}