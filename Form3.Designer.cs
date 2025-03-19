namespace Mood_Journal_Winform
{
    partial class form3
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
            cancelButton = new Button();
            saveButton = new Button();
            terribleButton = new RadioButton();
            badButton = new RadioButton();
            okayButton = new RadioButton();
            goodButton = new RadioButton();
            amazingButton = new RadioButton();
            editNotesText = new TextBox();
            notesLabel = new Label();
            moodLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(365, 190);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 26;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(446, 190);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 25;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // terribleButton
            // 
            terribleButton.AutoSize = true;
            terribleButton.Location = new Point(102, 124);
            terribleButton.Name = "terribleButton";
            terribleButton.Size = new Size(64, 19);
            terribleButton.TabIndex = 24;
            terribleButton.TabStop = true;
            terribleButton.Text = "Terrible";
            terribleButton.UseVisualStyleBackColor = true;
            // 
            // badButton
            // 
            badButton.AutoSize = true;
            badButton.Location = new Point(102, 99);
            badButton.Name = "badButton";
            badButton.Size = new Size(45, 19);
            badButton.TabIndex = 23;
            badButton.TabStop = true;
            badButton.Text = "Bad";
            badButton.UseVisualStyleBackColor = true;
            // 
            // okayButton
            // 
            okayButton.AutoSize = true;
            okayButton.Location = new Point(102, 74);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(52, 19);
            okayButton.TabIndex = 22;
            okayButton.TabStop = true;
            okayButton.Text = "Okay";
            okayButton.UseVisualStyleBackColor = true;
            // 
            // goodButton
            // 
            goodButton.AutoSize = true;
            goodButton.Location = new Point(102, 49);
            goodButton.Name = "goodButton";
            goodButton.Size = new Size(54, 19);
            goodButton.TabIndex = 21;
            goodButton.TabStop = true;
            goodButton.Text = "Good";
            goodButton.UseVisualStyleBackColor = true;
            // 
            // amazingButton
            // 
            amazingButton.AutoSize = true;
            amazingButton.Location = new Point(102, 24);
            amazingButton.Name = "amazingButton";
            amazingButton.Size = new Size(72, 19);
            amazingButton.TabIndex = 20;
            amazingButton.TabStop = true;
            amazingButton.Text = "Amazing";
            amazingButton.UseVisualStyleBackColor = true;
            // 
            // editNotesText
            // 
            editNotesText.Location = new Point(102, 149);
            editNotesText.Name = "editNotesText";
            editNotesText.Size = new Size(433, 23);
            editNotesText.TabIndex = 19;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(24, 152);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(41, 15);
            notesLabel.TabIndex = 18;
            notesLabel.Text = "Notes:";
            // 
            // moodLabel
            // 
            moodLabel.AutoSize = true;
            moodLabel.Location = new Point(24, 26);
            moodLabel.Name = "moodLabel";
            moodLabel.Size = new Size(72, 15);
            moodLabel.TabIndex = 17;
            moodLabel.Text = "Mood Scale:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 214);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 238);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(terribleButton);
            Controls.Add(badButton);
            Controls.Add(okayButton);
            Controls.Add(goodButton);
            Controls.Add(amazingButton);
            Controls.Add(editNotesText);
            Controls.Add(notesLabel);
            Controls.Add(moodLabel);
            Controls.Add(pictureBox1);
            Name = "form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private RadioButton terribleButton;
        private RadioButton badButton;
        private RadioButton okayButton;
        private RadioButton goodButton;
        private RadioButton amazingButton;
        private TextBox editNotesText;
        private Label notesLabel;
        private Label moodLabel;
        private PictureBox pictureBox1;
    }
}