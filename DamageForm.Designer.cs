namespace Paper_Mario
{
    partial class DamageForm
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
            this.damageMessageLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // damageMessageLabel
            // 
            this.damageMessageLabel.AutoSize = true;
            this.damageMessageLabel.Location = new System.Drawing.Point(50, 88);
            this.damageMessageLabel.Name = "damageMessageLabel";
            this.damageMessageLabel.Size = new System.Drawing.Size(173, 13);
            this.damageMessageLabel.TabIndex = 0;
            this.damageMessageLabel.Text = "You took damage! Watch your HP!";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(104, 155);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.damageMessageLabel);
            this.Location = new System.Drawing.Point(700, 50);
            this.Name = "DamageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DamageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label damageMessageLabel;
        private System.Windows.Forms.Button closeButton;
    }
}