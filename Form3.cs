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
    public partial class form3 : Form
    {
        public int editMood { get; set; }
        public string editNotes { get; set; }
        public int mood { get; set; }
        public string notes { get; set; }

        public form3()
        {
            InitializeComponent();

            editNotesText.Text = editNotes;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            editMood = mood;
            editNotesText.Text = editNotes;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (amazingButton.Checked) editMood = 1;
            else if (goodButton.Checked) editMood = 2;
            else if (okayButton.Checked) editMood = 3;
            else if (badButton.Checked) editMood = 4;
            else if (terribleButton.Checked) editMood = 5;
            else
            {
                MessageBox.Show("Please select a mood.");
                return;
            }

            editNotes = editNotesText.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
