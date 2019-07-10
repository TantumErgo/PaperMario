namespace Paper_Mario
{
    partial class TattleForm
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
            this.tattleNameLabel = new System.Windows.Forms.Label();
            this.tattleMaxHPLabel = new System.Windows.Forms.Label();
            this.tattleAttackLabel = new System.Windows.Forms.Label();
            this.tattleDefenseLabel = new System.Windows.Forms.Label();
            this.tattlePictureBox = new System.Windows.Forms.PictureBox();
            this.tattleTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tattlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tattleNameLabel
            // 
            this.tattleNameLabel.AutoSize = true;
            this.tattleNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tattleNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tattleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tattleNameLabel.Location = new System.Drawing.Point(85, 9);
            this.tattleNameLabel.Name = "tattleNameLabel";
            this.tattleNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.tattleNameLabel.Size = new System.Drawing.Size(108, 32);
            this.tattleNameLabel.TabIndex = 0;
            this.tattleNameLabel.Text = "Name here";
            // 
            // tattleMaxHPLabel
            // 
            this.tattleMaxHPLabel.AutoSize = true;
            this.tattleMaxHPLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tattleMaxHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tattleMaxHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tattleMaxHPLabel.Location = new System.Drawing.Point(43, 58);
            this.tattleMaxHPLabel.Name = "tattleMaxHPLabel";
            this.tattleMaxHPLabel.Padding = new System.Windows.Forms.Padding(2);
            this.tattleMaxHPLabel.Size = new System.Drawing.Size(72, 19);
            this.tattleMaxHPLabel.TabIndex = 1;
            this.tattleMaxHPLabel.Text = "MaxHP here";
            // 
            // tattleAttackLabel
            // 
            this.tattleAttackLabel.AutoSize = true;
            this.tattleAttackLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tattleAttackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tattleAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tattleAttackLabel.Location = new System.Drawing.Point(43, 81);
            this.tattleAttackLabel.Name = "tattleAttackLabel";
            this.tattleAttackLabel.Padding = new System.Windows.Forms.Padding(2);
            this.tattleAttackLabel.Size = new System.Drawing.Size(70, 19);
            this.tattleAttackLabel.TabIndex = 2;
            this.tattleAttackLabel.Text = "Attack Here";
            // 
            // tattleDefenseLabel
            // 
            this.tattleDefenseLabel.AutoSize = true;
            this.tattleDefenseLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tattleDefenseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tattleDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tattleDefenseLabel.Location = new System.Drawing.Point(43, 105);
            this.tattleDefenseLabel.Name = "tattleDefenseLabel";
            this.tattleDefenseLabel.Padding = new System.Windows.Forms.Padding(2);
            this.tattleDefenseLabel.Size = new System.Drawing.Size(77, 19);
            this.tattleDefenseLabel.TabIndex = 3;
            this.tattleDefenseLabel.Text = "Defense here";
            // 
            // tattlePictureBox
            // 
            this.tattlePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tattlePictureBox.Location = new System.Drawing.Point(157, 81);
            this.tattlePictureBox.Name = "tattlePictureBox";
            this.tattlePictureBox.Size = new System.Drawing.Size(100, 50);
            this.tattlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tattlePictureBox.TabIndex = 5;
            this.tattlePictureBox.TabStop = false;
            // 
            // tattleTextbox
            // 
            this.tattleTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.tattleTextbox.Location = new System.Drawing.Point(29, 133);
            this.tattleTextbox.Multiline = true;
            this.tattleTextbox.Name = "tattleTextbox";
            this.tattleTextbox.ReadOnly = true;
            this.tattleTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tattleTextbox.Size = new System.Drawing.Size(111, 117);
            this.tattleTextbox.TabIndex = 6;
            this.tattleTextbox.TabStop = false;
            this.tattleTextbox.Text = "Tattle text here";
            // 
            // TattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tattleTextbox);
            this.Controls.Add(this.tattlePictureBox);
            this.Controls.Add(this.tattleDefenseLabel);
            this.Controls.Add(this.tattleAttackLabel);
            this.Controls.Add(this.tattleMaxHPLabel);
            this.Controls.Add(this.tattleNameLabel);
            this.Name = "TattleForm";
            this.Text = "TattleForm";
            ((System.ComponentModel.ISupportInitialize)(this.tattlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tattleNameLabel;
        private System.Windows.Forms.Label tattleMaxHPLabel;
        private System.Windows.Forms.Label tattleAttackLabel;
        private System.Windows.Forms.Label tattleDefenseLabel;
        private System.Windows.Forms.PictureBox tattlePictureBox;
        private System.Windows.Forms.TextBox tattleTextbox;
    }
}