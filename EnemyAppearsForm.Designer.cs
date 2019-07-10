namespace Paper_Mario
{
    partial class EnemyAppearsForm
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
            this.EnemyAppearedLabel = new System.Windows.Forms.Label();
            this.enterNumberLabel = new System.Windows.Forms.Label();
            this.userFirstStrikeLabel = new System.Windows.Forms.Label();
            this.enemyStrikesFirstLabel = new System.Windows.Forms.Label();
            this.firstStrikeButton = new System.Windows.Forms.Button();
            this.userNumberTextbox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.GoombaLosesPicture = new System.Windows.Forms.PictureBox();
            this.GoombaWinsPicture = new System.Windows.Forms.PictureBox();
            this.GoombaAppearsPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GoombaLosesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoombaWinsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoombaAppearsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyAppearedLabel
            // 
            this.EnemyAppearedLabel.AutoSize = true;
            this.EnemyAppearedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyAppearedLabel.Location = new System.Drawing.Point(209, 48);
            this.EnemyAppearedLabel.Name = "EnemyAppearedLabel";
            this.EnemyAppearedLabel.Size = new System.Drawing.Size(162, 17);
            this.EnemyAppearedLabel.TabIndex = 3;
            this.EnemyAppearedLabel.Text = "A Goomba Appeared!";
            // 
            // enterNumberLabel
            // 
            this.enterNumberLabel.AutoSize = true;
            this.enterNumberLabel.BackColor = System.Drawing.SystemColors.Control;
            this.enterNumberLabel.Location = new System.Drawing.Point(223, 269);
            this.enterNumberLabel.Name = "enterNumberLabel";
            this.enterNumberLabel.Size = new System.Drawing.Size(111, 13);
            this.enterNumberLabel.TabIndex = 4;
            this.enterNumberLabel.Text = "Enter a Number 1-100";
            // 
            // userFirstStrikeLabel
            // 
            this.userFirstStrikeLabel.AutoSize = true;
            this.userFirstStrikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFirstStrikeLabel.Location = new System.Drawing.Point(377, 48);
            this.userFirstStrikeLabel.Name = "userFirstStrikeLabel";
            this.userFirstStrikeLabel.Size = new System.Drawing.Size(183, 17);
            this.userFirstStrikeLabel.TabIndex = 5;
            this.userFirstStrikeLabel.Text = "You Got the First Strike!";
            this.userFirstStrikeLabel.Visible = false;
            // 
            // enemyStrikesFirstLabel
            // 
            this.enemyStrikesFirstLabel.AutoSize = true;
            this.enemyStrikesFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyStrikesFirstLabel.Location = new System.Drawing.Point(30, 48);
            this.enemyStrikesFirstLabel.Name = "enemyStrikesFirstLabel";
            this.enemyStrikesFirstLabel.Size = new System.Drawing.Size(185, 17);
            this.enemyStrikesFirstLabel.TabIndex = 6;
            this.enemyStrikesFirstLabel.Text = "The Enemy Strikes First!";
            this.enemyStrikesFirstLabel.Visible = false;
            // 
            // firstStrikeButton
            // 
            this.firstStrikeButton.Location = new System.Drawing.Point(196, 354);
            this.firstStrikeButton.Name = "firstStrikeButton";
            this.firstStrikeButton.Size = new System.Drawing.Size(175, 44);
            this.firstStrikeButton.TabIndex = 7;
            this.firstStrikeButton.Text = "See Who Gets the First Strike!";
            this.firstStrikeButton.UseVisualStyleBackColor = true;
            this.firstStrikeButton.Click += new System.EventHandler(this.firstStrikeButton_Click);
            // 
            // userNumberTextbox
            // 
            this.userNumberTextbox.Location = new System.Drawing.Point(228, 303);
            this.userNumberTextbox.Name = "userNumberTextbox";
            this.userNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.userNumberTextbox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(241, 354);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 44);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // GoombaLosesPicture
            // 
            this.GoombaLosesPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoombaLosesPicture.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHurt.png";
            this.GoombaLosesPicture.Location = new System.Drawing.Point(415, 106);
            this.GoombaLosesPicture.Name = "GoombaLosesPicture";
            this.GoombaLosesPicture.Size = new System.Drawing.Size(92, 87);
            this.GoombaLosesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GoombaLosesPicture.TabIndex = 2;
            this.GoombaLosesPicture.TabStop = false;
            this.GoombaLosesPicture.Visible = false;
            // 
            // GoombaWinsPicture
            // 
            this.GoombaWinsPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoombaWinsPicture.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHeadbonk.png" +
    "";
            this.GoombaWinsPicture.Location = new System.Drawing.Point(71, 100);
            this.GoombaWinsPicture.Name = "GoombaWinsPicture";
            this.GoombaWinsPicture.Size = new System.Drawing.Size(87, 105);
            this.GoombaWinsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GoombaWinsPicture.TabIndex = 1;
            this.GoombaWinsPicture.TabStop = false;
            this.GoombaWinsPicture.Visible = false;
            // 
            // GoombaAppearsPicture
            // 
            this.GoombaAppearsPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoombaAppearsPicture.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaCropEnemy.pn" +
    "g";
            this.GoombaAppearsPicture.Location = new System.Drawing.Point(241, 100);
            this.GoombaAppearsPicture.Name = "GoombaAppearsPicture";
            this.GoombaAppearsPicture.Size = new System.Drawing.Size(86, 93);
            this.GoombaAppearsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GoombaAppearsPicture.TabIndex = 0;
            this.GoombaAppearsPicture.TabStop = false;
            // 
            // EnemyAppearsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 422);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.userNumberTextbox);
            this.Controls.Add(this.firstStrikeButton);
            this.Controls.Add(this.enemyStrikesFirstLabel);
            this.Controls.Add(this.userFirstStrikeLabel);
            this.Controls.Add(this.enterNumberLabel);
            this.Controls.Add(this.EnemyAppearedLabel);
            this.Controls.Add(this.GoombaLosesPicture);
            this.Controls.Add(this.GoombaWinsPicture);
            this.Controls.Add(this.GoombaAppearsPicture);
            this.Name = "EnemyAppearsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnemyAppearsForm";
            ((System.ComponentModel.ISupportInitialize)(this.GoombaLosesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoombaWinsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoombaAppearsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GoombaAppearsPicture;
        private System.Windows.Forms.PictureBox GoombaWinsPicture;
        private System.Windows.Forms.PictureBox GoombaLosesPicture;
        private System.Windows.Forms.Label EnemyAppearedLabel;
        private System.Windows.Forms.Label enterNumberLabel;
        private System.Windows.Forms.Label userFirstStrikeLabel;
        private System.Windows.Forms.Label enemyStrikesFirstLabel;
        private System.Windows.Forms.Button firstStrikeButton;
        private System.Windows.Forms.TextBox userNumberTextbox;
        private System.Windows.Forms.Button startButton;
    }
}

