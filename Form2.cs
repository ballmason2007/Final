using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Journal_Winform
{
    public partial class newEntryForm : Form
    {
        public int mood { get; set; }
        public string notes { get; set; }

        public newEntryForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void amazingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (amazingButton.Checked) mood = 1;
        }

        private void goodButton_CheckedChanged(object sender, EventArgs e)
        {
            if (goodButton.Checked) mood = 2;
        }

        private void okayButton_CheckedChanged(object sender, EventArgs e)
        {
            if (okayButton.Checked) mood = 3;
        }

        private void badButton_CheckedChanged(object sender, EventArgs e)
        {
            if (badButton.Checked) mood = 4;
        }

        private void terribleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (terribleButton.Checked) mood = 5;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (amazingButton.Checked) mood = 1;
            else if (goodButton.Checked) mood = 2;
            else if (okayButton.Checked) mood = 3;
            else if (badButton.Checked) mood = 4;
            else if (terribleButton.Checked) mood = 5;
            else
            {
                MessageBox.Show("Please select a mood.");
                return;
            }

            notes = notesTextBox.Text;

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
