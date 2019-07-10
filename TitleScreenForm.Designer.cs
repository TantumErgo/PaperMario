namespace Paper_Mario
{
    partial class TitleScreenForm
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
            this.selectProgramLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.tattleLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectProgramLabel
            // 
            this.selectProgramLabel.AutoSize = true;
            this.selectProgramLabel.Location = new System.Drawing.Point(78, 33);
            this.selectProgramLabel.Name = "selectProgramLabel";
            this.selectProgramLabel.Size = new System.Drawing.Size(132, 13);
            this.selectProgramLabel.TabIndex = 0;
            this.selectProgramLabel.Text = "Select the Program to Run";
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(105, 68);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 52);
            this.launchButton.TabIndex = 1;
            this.launchButton.Text = "Start the Game";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // tattleLogButton
            // 
            this.tattleLogButton.Location = new System.Drawing.Point(105, 151);
            this.tattleLogButton.Name = "tattleLogButton";
            this.tattleLogButton.Size = new System.Drawing.Size(75, 55);
            this.tattleLogButton.TabIndex = 2;
            this.tattleLogButton.Text = "Open Tattle Log";
            this.tattleLogButton.UseVisualStyleBackColor = true;
            this.tattleLogButton.Click += new System.EventHandler(this.tattleLogButton_Click);
            // 
            // TitleScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tattleLogButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.selectProgramLabel);
            this.Name = "TitleScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitleScreenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectProgramLabel;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button tattleLogButton;
    }
}