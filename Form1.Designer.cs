namespace Mood_Journal_Winform
{
    partial class moodJournal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newEntryButton = new Button();
            entryList = new DataGridView();
            dateColumn = new DataGridViewTextBoxColumn();
            moodColumn = new DataGridViewTextBoxColumn();
            notesColumn = new DataGridViewTextBoxColumn();
            editButton = new Button();
            ((System.ComponentModel.ISupportInitialize)entryList).BeginInit();
            SuspendLayout();
            // 
            // newEntryButton
            // 
            newEntryButton.Location = new Point(400, 12);
            newEntryButton.Name = "newEntryButton";
            newEntryButton.Size = new Size(94, 23);
            newEntryButton.TabIndex = 2;
            newEntryButton.Text = "New Entry";
            newEntryButton.UseVisualStyleBackColor = true;
            // 
            // entryList
            // 
            entryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            entryList.Columns.AddRange(new DataGridViewColumn[] { dateColumn, moodColumn, notesColumn });
            entryList.Location = new Point(12, 50);
            entryList.Name = "entryList";
            entryList.Size = new Size(493, 431);
            entryList.TabIndex = 3;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.Name = "dateColumn";
            dateColumn.Width = 150;
            // 
            // moodColumn
            // 
            moodColumn.HeaderText = "Mood";
            moodColumn.Name = "moodColumn";
            moodColumn.Width = 150;
            // 
            // notesColumn
            // 
            notesColumn.HeaderText = "Notes";
            notesColumn.Name = "notesColumn";
            notesColumn.Width = 150;
            // 
            // editButton
            // 
            editButton.Location = new Point(300, 12);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 23);
            editButton.TabIndex = 4;
            editButton.Text = "Edit Entry";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // moodJournal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 493);
            Controls.Add(editButton);
            Controls.Add(entryList);
            Controls.Add(newEntryButton);
            Name = "moodJournal";
            Text = "Mood Journal";
            ((System.ComponentModel.ISupportInitialize)entryList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button newEntryButton;
        private DataGridView entryList;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn moodColumn;
        private DataGridViewTextBoxColumn notesColumn;
        private Button editButton;
    }
}
