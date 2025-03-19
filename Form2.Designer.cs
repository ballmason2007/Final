namespace Mood_Journal_Winform
{
    partial class newEntryForm
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
            pictureBox1 = new PictureBox();
            moodLabel = new Label();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            amazingButton = new RadioButton();
            goodButton = new RadioButton();
            okayButton = new RadioButton();
            badButton = new RadioButton();
            terribleButton = new RadioButton();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 213);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // moodLabel
            // 
            moodLabel.AutoSize = true;
            moodLabel.Location = new Point(24, 26);
            moodLabel.Name = "moodLabel";
            moodLabel.Size = new Size(72, 15);
            moodLabel.TabIndex = 3;
            moodLabel.Text = "Mood Scale:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(24, 152);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(41, 15);
            notesLabel.TabIndex = 4;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(102, 149);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(433, 23);
            notesTextBox.TabIndex = 8;
            // 
            // amazingButton
            // 
            amazingButton.AutoSize = true;
            amazingButton.Location = new Point(102, 24);
            amazingButton.Name = "amazingButton";
            amazingButton.Size = new Size(72, 19);
            amazingButton.TabIndex = 9;
            amazingButton.TabStop = true;
            amazingButton.Text = "Amazing";
            amazingButton.UseVisualStyleBackColor = true;
            // 
            // goodButton
            // 
            goodButton.AutoSize = true;
            goodButton.Location = new Point(102, 49);
            goodButton.Name = "goodButton";
            goodButton.Size = new Size(54, 19);
            goodButton.TabIndex = 10;
            goodButton.TabStop = true;
            goodButton.Text = "Good";
            goodButton.UseVisualStyleBackColor = true;
            // 
            // okayButton
            // 
            okayButton.AutoSize = true;
            okayButton.Location = new Point(102, 74);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(52, 19);
            okayButton.TabIndex = 11;
            okayButton.TabStop = true;
            okayButton.Text = "Okay";
            okayButton.UseVisualStyleBackColor = true;
            // 
            // badButton
            // 
            badButton.AutoSize = true;
            badButton.Location = new Point(102, 99);
            badButton.Name = "badButton";
            badButton.Size = new Size(45, 19);
            badButton.TabIndex = 12;
            badButton.TabStop = true;
            badButton.Text = "Bad";
            badButton.UseVisualStyleBackColor = true;
            // 
            // terribleButton
            // 
            terribleButton.AutoSize = true;
            terribleButton.Location = new Point(102, 124);
            terribleButton.Name = "terribleButton";
            terribleButton.Size = new Size(64, 19);
            terribleButton.TabIndex = 13;
            terribleButton.TabStop = true;
            terribleButton.Text = "Terrible";
            terribleButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(446, 190);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 14;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(365, 190);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // newEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 237);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(terribleButton);
            Controls.Add(badButton);
            Controls.Add(okayButton);
            Controls.Add(goodButton);
            Controls.Add(amazingButton);
            Controls.Add(notesTextBox);
            Controls.Add(notesLabel);
            Controls.Add(moodLabel);
            Controls.Add(pictureBox1);
            Name = "newEntryForm";
            Text = "New Entry";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label moodLabel;
        private Label notesLabel;
        private TextBox notesTextBox;
        private RadioButton amazingButton;
        private RadioButton goodButton;
        private RadioButton okayButton;
        private RadioButton badButton;
        private RadioButton terribleButton;
        private Button saveButton;
        private Button cancelButton;
    }
}