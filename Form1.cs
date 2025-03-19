using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Mood_Journal_Winform
{
    public partial class moodJournal : Form
    {
        public moodJournal()
        {
            InitializeComponent();
        }

        private List<MoodEntry> moodEntries = new List<MoodEntry>();

        private void newEntryButton_Click(object sender, EventArgs e)
        {
            var newEntry = new newEntryForm();
            var result = newEntry.ShowDialog();

            if (result == DialogResult.OK)
            {
                DateTime date = DateTime.Now;
                int mood = newEntry.mood;
                string notes = newEntry.notes;

                moodEntries.Add(new MoodEntry(date, mood, notes));

                entryList.Rows.Add(date, mood, notes);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (entryList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = entryList.SelectedRows[0];
                int selectedIndex = selectedRow.Index;

                int editMood = Convert.ToInt32(selectedRow.Cells["moodColumn"].Value);
                string editNotes = selectedRow.Cells["notesColumn"].Value.ToString();

                var editEntryForm = new form3();
                editEntryForm.editMood = editMood;
                editEntryForm.editNotes = editNotes;

                var result = editEntryForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int newMood = editEntryForm.editMood;
                    string newNotes = editEntryForm.editNotes;

                    moodEntries[selectedIndex] = new MoodEntry(DateTime.Now, newMood, newNotes);

                    selectedRow.Cells["moodColumn"].Value = newMood;
                    selectedRow.Cells["notesColumn"].Value = newNotes;
                }
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }
    }
}
