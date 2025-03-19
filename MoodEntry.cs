using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Journal_Winform
{
    internal class MoodEntry
    {
        public DateTime Date { get; set; }
        public int Mood { get; set; }
        public string Notes { get; set; }

        public MoodEntry(DateTime date, int mood, string notes)
        {
            Date = date;
            Mood = mood;
            Notes = notes;
        }
}
