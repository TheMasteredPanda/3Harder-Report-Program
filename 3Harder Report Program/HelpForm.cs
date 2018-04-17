using System;
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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void next_button_0_Click(object sender, EventArgs e)
        {
            first_panel.Visible = true;
        }

        private void previous_button_0_Click(object sender, EventArgs e)
        {
            first_panel.Visible = false;
        }

        private void next_button_1_Click(object sender, EventArgs e)
        {
            second_panel.Visible = true;
        }

        private void previous_button_1_Click(object sender, EventArgs e)
        {
            second_panel.Visible = false;
        }

        private void next_button_2_Click(object sender, EventArgs e)
        {
            third_panel.Visible = true;
        }

        private void previous_button_2_Click(object sender, EventArgs e)
        {
            third_panel.Visible = false;
        }

        private void next_button_3_Click(object sender, EventArgs e)
        {
            fourth_panel.Visible = true;
        }

        private void previous_button_3_Click(object sender, EventArgs e)
        {
            fourth_panel.Visible = false;
        }

        private void next_button_4_Click(object sender, EventArgs e)
        {
            fifth_panel.Visible = true;
        }

        private void previous_button_4_Click(object sender, EventArgs e)
        {
            fifth_panel.Visible = false;
        }

        private void next_button_5_Click(object sender, EventArgs e)
        {
            sixth_panel.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void previous_button_5_Click(object sender, EventArgs e)
        {
            sixth_panel.Visible = false;
        }

        private void next_button_6_Click(object sender, EventArgs e)
        {
            seventh_panel.Visible = true;
        }

        private void previous_button_6_Click(object sender, EventArgs e)
        {
            seventh_panel.Visible = false;
        }

        private void next_button_7_Click(object sender, EventArgs e)
        {
            eighth_panel.Visible = true;
        }

        private void previous_button_7_Click(object sender, EventArgs e)
        {
            eighth_panel.Visible = false;
        }

        private void next_button_8_Click(object sender, EventArgs e)
        {
            ninth_panel.Visible = true;
        }

        private void previous_button_8_Click(object sender, EventArgs e)
        {
            ninth_panel.Visible = false;
        }

   }
}
