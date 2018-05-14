namespace CST_117_ProgrammingExercise_3
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.statsTextBox = new System.Windows.Forms.TextBox();
            this.statsLabel = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "file.txt";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(24, 12);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Choose File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statsTextBox
            // 
            this.statsTextBox.Location = new System.Drawing.Point(24, 70);
            this.statsTextBox.Multiline = true;
            this.statsTextBox.Name = "statsTextBox";
            this.statsTextBox.Size = new System.Drawing.Size(268, 103);
            this.statsTextBox.TabIndex = 9;
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(21, 54);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(49, 13);
            this.statsLabel.TabIndex = 10;
            this.statsLabel.Text = "Statistics";
            // 
            // saveFile
            // 
            this.saveFile.FileName = "stats.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.statsTextBox);
            this.Controls.Add(this.openFileButton);
            this.Name = "Form1";
            this.Text = "File Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox statsTextBox;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

