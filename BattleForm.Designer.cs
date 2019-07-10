namespace Paper_Mario
{
    partial class BattleForm
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
            this.components = new System.ComponentModel.Container();
            this.backToAttackSelectButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.enemyAttackButton = new System.Windows.Forms.Button();
            this.userHPLabel = new System.Windows.Forms.Label();
            this.enemyAttackPictureBox = new System.Windows.Forms.PictureBox();
            this.hammerAttackPictureBox = new System.Windows.Forms.PictureBox();
            this.spikedGoombaAttackPicturebox = new System.Windows.Forms.PictureBox();
            this.spikedGoombaLaughPicturebox = new System.Windows.Forms.PictureBox();
            this.spikedGoombaHurtPicturebox = new System.Windows.Forms.PictureBox();
            this.marioWinPicturebox = new System.Windows.Forms.PictureBox();
            this.marioDefeatedPicturebox = new System.Windows.Forms.PictureBox();
            this.marioHurtPicturebox = new System.Windows.Forms.PictureBox();
            this.marioSpikeJumpPicturebox = new System.Windows.Forms.PictureBox();
            this.marioHammerPicturebox = new System.Windows.Forms.PictureBox();
            this.marioJumpPicturebox = new System.Windows.Forms.PictureBox();
            this.marioDefaultPicturebox = new System.Windows.Forms.PictureBox();
            this.enemy3BattlePicture = new System.Windows.Forms.PictureBox();
            this.enemy2BattlePicture = new System.Windows.Forms.PictureBox();
            this.enemy1BattlePicture = new System.Windows.Forms.PictureBox();
            this.hammerPicture = new System.Windows.Forms.PictureBox();
            this.jumpPicture = new System.Windows.Forms.PictureBox();
            this.tattlePictureBox = new System.Windows.Forms.PictureBox();
            this.enemy1HPLabel = new System.Windows.Forms.Label();
            this.enemy2HPLabel = new System.Windows.Forms.Label();
            this.enemy3HPLabel = new System.Windows.Forms.Label();
            this.noSelectHammerToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyAttackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerAttackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikedGoombaAttackPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikedGoombaLaughPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikedGoombaHurtPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioWinPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioDefeatedPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioHurtPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioSpikeJumpPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioHammerPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioJumpPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioDefaultPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3BattlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2BattlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1BattlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tattlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backToAttackSelectButton
            // 
            this.backToAttackSelectButton.Location = new System.Drawing.Point(132, 360);
            this.backToAttackSelectButton.Name = "backToAttackSelectButton";
            this.backToAttackSelectButton.Size = new System.Drawing.Size(95, 48);
            this.backToAttackSelectButton.TabIndex = 2;
            this.backToAttackSelectButton.Text = "Back to Attack Select";
            this.backToAttackSelectButton.UseVisualStyleBackColor = true;
            this.backToAttackSelectButton.Visible = false;
            this.backToAttackSelectButton.Click += new System.EventHandler(this.backToAttackSelectButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionLabel.Location = new System.Drawing.Point(363, 385);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(302, 23);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Select Your Attack";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyAttackButton
            // 
            this.enemyAttackButton.Location = new System.Drawing.Point(246, 360);
            this.enemyAttackButton.Name = "enemyAttackButton";
            this.enemyAttackButton.Size = new System.Drawing.Size(75, 48);
            this.enemyAttackButton.TabIndex = 9;
            this.enemyAttackButton.Text = "Enemy Attack";
            this.enemyAttackButton.UseVisualStyleBackColor = true;
            this.enemyAttackButton.Visible = false;
            this.enemyAttackButton.Click += new System.EventHandler(this.enemyAttackButton_Click);
            // 
            // userHPLabel
            // 
            this.userHPLabel.AutoSize = true;
            this.userHPLabel.BackColor = System.Drawing.SystemColors.Window;
            this.userHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userHPLabel.Location = new System.Drawing.Point(147, 273);
            this.userHPLabel.Name = "userHPLabel";
            this.userHPLabel.Size = new System.Drawing.Size(27, 15);
            this.userHPLabel.TabIndex = 10;
            this.userHPLabel.Text = "HP:";
            this.userHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyAttackPictureBox
            // 
            this.enemyAttackPictureBox.Image = global::Paper_Mario.Properties.Resources.GoombaHeadbonkRotated;
            this.enemyAttackPictureBox.Location = new System.Drawing.Point(186, 23);
            this.enemyAttackPictureBox.Name = "enemyAttackPictureBox";
            this.enemyAttackPictureBox.Size = new System.Drawing.Size(124, 128);
            this.enemyAttackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyAttackPictureBox.TabIndex = 22;
            this.enemyAttackPictureBox.TabStop = false;
            this.enemyAttackPictureBox.Visible = false;
            // 
            // hammerAttackPictureBox
            // 
            this.hammerAttackPictureBox.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/HammerAttack.png";
            this.hammerAttackPictureBox.Location = new System.Drawing.Point(521, 231);
            this.hammerAttackPictureBox.Name = "hammerAttackPictureBox";
            this.hammerAttackPictureBox.Size = new System.Drawing.Size(60, 52);
            this.hammerAttackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hammerAttackPictureBox.TabIndex = 21;
            this.hammerAttackPictureBox.TabStop = false;
            this.hammerAttackPictureBox.Visible = false;
            // 
            // spikedGoombaAttackPicturebox
            // 
            this.spikedGoombaAttackPicturebox.Image = global::Paper_Mario.Properties.Resources.SpikedGoombaHeadbonk;
            this.spikedGoombaAttackPicturebox.Location = new System.Drawing.Point(931, 58);
            this.spikedGoombaAttackPicturebox.Name = "spikedGoombaAttackPicturebox";
            this.spikedGoombaAttackPicturebox.Size = new System.Drawing.Size(84, 140);
            this.spikedGoombaAttackPicturebox.TabIndex = 20;
            this.spikedGoombaAttackPicturebox.TabStop = false;
            this.spikedGoombaAttackPicturebox.Visible = false;
            // 
            // spikedGoombaLaughPicturebox
            // 
            this.spikedGoombaLaughPicturebox.Image = global::Paper_Mario.Properties.Resources.SpikedGoombaLaugh;
            this.spikedGoombaLaughPicturebox.Location = new System.Drawing.Point(705, 40);
            this.spikedGoombaLaughPicturebox.Name = "spikedGoombaLaughPicturebox";
            this.spikedGoombaLaughPicturebox.Size = new System.Drawing.Size(85, 121);
            this.spikedGoombaLaughPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spikedGoombaLaughPicturebox.TabIndex = 19;
            this.spikedGoombaLaughPicturebox.TabStop = false;
            this.spikedGoombaLaughPicturebox.Visible = false;
            // 
            // spikedGoombaHurtPicturebox
            // 
            this.spikedGoombaHurtPicturebox.Image = global::Paper_Mario.Properties.Resources.SpikedGoombaHurt;
            this.spikedGoombaHurtPicturebox.Location = new System.Drawing.Point(672, 293);
            this.spikedGoombaHurtPicturebox.Name = "spikedGoombaHurtPicturebox";
            this.spikedGoombaHurtPicturebox.Size = new System.Drawing.Size(86, 100);
            this.spikedGoombaHurtPicturebox.TabIndex = 18;
            this.spikedGoombaHurtPicturebox.TabStop = false;
            this.spikedGoombaHurtPicturebox.Visible = false;
            // 
            // marioWinPicturebox
            // 
            this.marioWinPicturebox.Image = global::Paper_Mario.Properties.Resources.MarioWin;
            this.marioWinPicturebox.Location = new System.Drawing.Point(833, 241);
            this.marioWinPicturebox.Name = "marioWinPicturebox";
            this.marioWinPicturebox.Size = new System.Drawing.Size(112, 131);
            this.marioWinPicturebox.TabIndex = 17;
            this.marioWinPicturebox.TabStop = false;
            this.marioWinPicturebox.Visible = false;
            // 
            // marioDefeatedPicturebox
            // 
            this.marioDefeatedPicturebox.Image = global::Paper_Mario.Properties.Resources.MarioDefeated12;
            this.marioDefeatedPicturebox.Location = new System.Drawing.Point(413, 296);
            this.marioDefeatedPicturebox.Name = "marioDefeatedPicturebox";
            this.marioDefeatedPicturebox.Size = new System.Drawing.Size(153, 76);
            this.marioDefeatedPicturebox.TabIndex = 16;
            this.marioDefeatedPicturebox.TabStop = false;
            this.marioDefeatedPicturebox.Visible = false;
            // 
            // marioHurtPicturebox
            // 
            this.marioHurtPicturebox.Image = global::Paper_Mario.Properties.Resources.MarioHurt;
            this.marioHurtPicturebox.Location = new System.Drawing.Point(12, 12);
            this.marioHurtPicturebox.Name = "marioHurtPicturebox";
            this.marioHurtPicturebox.Size = new System.Drawing.Size(127, 136);
            this.marioHurtPicturebox.TabIndex = 15;
            this.marioHurtPicturebox.TabStop = false;
            this.marioHurtPicturebox.Visible = false;
            // 
            // marioSpikeJumpPicturebox
            // 
            this.marioSpikeJumpPicturebox.Image = global::Paper_Mario.Properties.Resources.MarioSpikeJump;
            this.marioSpikeJumpPicturebox.Location = new System.Drawing.Point(806, 4);
            this.marioSpikeJumpPicturebox.Name = "marioSpikeJumpPicturebox";
            this.marioSpikeJumpPicturebox.Size = new System.Drawing.Size(100, 144);
            this.marioSpikeJumpPicturebox.TabIndex = 14;
            this.marioSpikeJumpPicturebox.TabStop = false;
            this.marioSpikeJumpPicturebox.Visible = false;
            // 
            // marioHammerPicturebox
            // 
            this.marioHammerPicturebox.Image = global::Paper_Mario.Properties.Resources.MarioHammer2;
            this.marioHammerPicturebox.Location = new System.Drawing.Point(716, 61);
            this.marioHammerPicturebox.Name = "marioHammerPicturebox";
            this.marioHammerPicturebox.Size = new System.Drawing.Size(98, 127);
            this.marioHammerPicturebox.TabIndex = 13;
            this.marioHammerPicturebox.TabStop = false;
            this.marioHammerPicturebox.Visible = false;
            // 
            // marioJumpPicturebox
            // 
            this.marioJumpPicturebox.Image = global::Paper_Mario.Properties.Resources.MarioJump;
            this.marioJumpPicturebox.Location = new System.Drawing.Point(580, 70);
            this.marioJumpPicturebox.Name = "marioJumpPicturebox";
            this.marioJumpPicturebox.Size = new System.Drawing.Size(100, 128);
            this.marioJumpPicturebox.TabIndex = 12;
            this.marioJumpPicturebox.TabStop = false;
            this.marioJumpPicturebox.Visible = false;
            // 
            // marioDefaultPicturebox
            // 
            this.marioDefaultPicturebox.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioDefault.png";
            this.marioDefaultPicturebox.Location = new System.Drawing.Point(132, 138);
            this.marioDefaultPicturebox.Name = "marioDefaultPicturebox";
            this.marioDefaultPicturebox.Size = new System.Drawing.Size(100, 128);
            this.marioDefaultPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.marioDefaultPicturebox.TabIndex = 11;
            this.marioDefaultPicturebox.TabStop = false;
            // 
            // enemy3BattlePicture
            // 
            this.enemy3BattlePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enemy3BattlePicture.Enabled = false;
            this.enemy3BattlePicture.Image = global::Paper_Mario.Properties.Resources.Paragoomba;
            this.enemy3BattlePicture.Location = new System.Drawing.Point(815, 165);
            this.enemy3BattlePicture.Name = "enemy3BattlePicture";
            this.enemy3BattlePicture.Size = new System.Drawing.Size(85, 95);
            this.enemy3BattlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy3BattlePicture.TabIndex = 8;
            this.enemy3BattlePicture.TabStop = false;
            this.enemy3BattlePicture.Click += new System.EventHandler(this.enemy3BattlePicture_Click);
            // 
            // enemy2BattlePicture
            // 
            this.enemy2BattlePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enemy2BattlePicture.Enabled = false;
            this.enemy2BattlePicture.Image = global::Paper_Mario.Properties.Resources.SpikedGoomba1;
            this.enemy2BattlePicture.Location = new System.Drawing.Point(686, 166);
            this.enemy2BattlePicture.Name = "enemy2BattlePicture";
            this.enemy2BattlePicture.Size = new System.Drawing.Size(84, 120);
            this.enemy2BattlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy2BattlePicture.TabIndex = 7;
            this.enemy2BattlePicture.TabStop = false;
            this.enemy2BattlePicture.Click += new System.EventHandler(this.enemy2BattlePicture_Click);
            // 
            // enemy1BattlePicture
            // 
            this.enemy1BattlePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enemy1BattlePicture.Enabled = false;
            this.enemy1BattlePicture.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaCropEnemy.pn" +
    "g";
            this.enemy1BattlePicture.Location = new System.Drawing.Point(580, 194);
            this.enemy1BattlePicture.Name = "enemy1BattlePicture";
            this.enemy1BattlePicture.Size = new System.Drawing.Size(84, 91);
            this.enemy1BattlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy1BattlePicture.TabIndex = 6;
            this.enemy1BattlePicture.TabStop = false;
            this.enemy1BattlePicture.Click += new System.EventHandler(this.enemy1BattlePicture_Click);
            // 
            // hammerPicture
            // 
            this.hammerPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hammerPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hammerPicture.Enabled = false;
            this.hammerPicture.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/Hammer%20Picture.p" +
    "ng";
            this.hammerPicture.Location = new System.Drawing.Point(304, 194);
            this.hammerPicture.Name = "hammerPicture";
            this.hammerPicture.Size = new System.Drawing.Size(31, 29);
            this.hammerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hammerPicture.TabIndex = 5;
            this.hammerPicture.TabStop = false;
            this.noSelectHammerToolTip.SetToolTip(this.hammerPicture, "The Hammer cannot be used against flying enemies.\n(Click off of the Hammer pictur" +
        "e to hide this message)");
            this.hammerPicture.Visible = false;
            this.hammerPicture.Click += new System.EventHandler(this.hammerPicture_Click);
            // 
            // jumpPicture
            // 
            this.jumpPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jumpPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jumpPicture.Enabled = false;
            this.jumpPicture.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/Jump%20Picture.png" +
    "";
            this.jumpPicture.Location = new System.Drawing.Point(280, 157);
            this.jumpPicture.Name = "jumpPicture";
            this.jumpPicture.Size = new System.Drawing.Size(30, 29);
            this.jumpPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jumpPicture.TabIndex = 4;
            this.jumpPicture.TabStop = false;
            this.jumpPicture.Visible = false;
            this.jumpPicture.Click += new System.EventHandler(this.jumpPicture_Click);
            // 
            // tattlePictureBox
            // 
            this.tattlePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tattlePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tattlePictureBox.Enabled = false;
            this.tattlePictureBox.ImageLocation = "https://raw.githubusercontent.com/TantumErgo/PaperMario/master/TattleIcon.png";
            this.tattlePictureBox.Location = new System.Drawing.Point(280, 230);
            this.tattlePictureBox.Name = "tattlePictureBox";
            this.tattlePictureBox.Size = new System.Drawing.Size(30, 37);
            this.tattlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tattlePictureBox.TabIndex = 23;
            this.tattlePictureBox.TabStop = false;
            this.tattlePictureBox.Visible = false;
            this.tattlePictureBox.Click += new System.EventHandler(this.tattlePictureBox_Click);
            // 
            // enemy1HPLabel
            // 
            this.enemy1HPLabel.AutoSize = true;
            this.enemy1HPLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enemy1HPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemy1HPLabel.Location = new System.Drawing.Point(595, 293);
            this.enemy1HPLabel.Name = "enemy1HPLabel";
            this.enemy1HPLabel.Size = new System.Drawing.Size(37, 15);
            this.enemy1HPLabel.TabIndex = 24;
            this.enemy1HPLabel.Text = "label1";
            this.enemy1HPLabel.Visible = false;
            // 
            // enemy2HPLabel
            // 
            this.enemy2HPLabel.AutoSize = true;
            this.enemy2HPLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enemy2HPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemy2HPLabel.Location = new System.Drawing.Point(700, 293);
            this.enemy2HPLabel.Name = "enemy2HPLabel";
            this.enemy2HPLabel.Size = new System.Drawing.Size(37, 15);
            this.enemy2HPLabel.TabIndex = 25;
            this.enemy2HPLabel.Text = "label1";
            this.enemy2HPLabel.Visible = false;
            // 
            // enemy3HPLabel
            // 
            this.enemy3HPLabel.AutoSize = true;
            this.enemy3HPLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enemy3HPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemy3HPLabel.Location = new System.Drawing.Point(828, 293);
            this.enemy3HPLabel.Name = "enemy3HPLabel";
            this.enemy3HPLabel.Size = new System.Drawing.Size(37, 15);
            this.enemy3HPLabel.TabIndex = 26;
            this.enemy3HPLabel.Text = "label1";
            this.enemy3HPLabel.Visible = false;
            // 
            // noSelectHammerToolTip
            // 
            this.noSelectHammerToolTip.Active = false;
            this.noSelectHammerToolTip.AutoPopDelay = 50;
            this.noSelectHammerToolTip.InitialDelay = 50;
            this.noSelectHammerToolTip.ReshowDelay = 100;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 448);
            this.Controls.Add(this.enemy3HPLabel);
            this.Controls.Add(this.enemy2HPLabel);
            this.Controls.Add(this.enemy1HPLabel);
            this.Controls.Add(this.tattlePictureBox);
            this.Controls.Add(this.enemyAttackPictureBox);
            this.Controls.Add(this.hammerAttackPictureBox);
            this.Controls.Add(this.spikedGoombaAttackPicturebox);
            this.Controls.Add(this.spikedGoombaLaughPicturebox);
            this.Controls.Add(this.spikedGoombaHurtPicturebox);
            this.Controls.Add(this.marioWinPicturebox);
            this.Controls.Add(this.marioDefeatedPicturebox);
            this.Controls.Add(this.marioHurtPicturebox);
            this.Controls.Add(this.marioSpikeJumpPicturebox);
            this.Controls.Add(this.marioHammerPicturebox);
            this.Controls.Add(this.marioJumpPicturebox);
            this.Controls.Add(this.marioDefaultPicturebox);
            this.Controls.Add(this.userHPLabel);
            this.Controls.Add(this.enemyAttackButton);
            this.Controls.Add(this.enemy3BattlePicture);
            this.Controls.Add(this.enemy2BattlePicture);
            this.Controls.Add(this.enemy1BattlePicture);
            this.Controls.Add(this.hammerPicture);
            this.Controls.Add(this.jumpPicture);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.backToAttackSelectButton);
            this.Name = "BattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleForm";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BattleForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemyAttackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerAttackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikedGoombaAttackPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikedGoombaLaughPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikedGoombaHurtPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioWinPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioDefeatedPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioHurtPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioSpikeJumpPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioHammerPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioJumpPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioDefaultPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3BattlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2BattlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1BattlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tattlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backToAttackSelectButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox jumpPicture;
        private System.Windows.Forms.PictureBox hammerPicture;
        private System.Windows.Forms.PictureBox enemy1BattlePicture;
        private System.Windows.Forms.PictureBox enemy2BattlePicture;
        private System.Windows.Forms.PictureBox enemy3BattlePicture;
        private System.Windows.Forms.Button enemyAttackButton;
        private System.Windows.Forms.Label userHPLabel;
        private System.Windows.Forms.PictureBox marioDefaultPicturebox;
        private System.Windows.Forms.PictureBox marioJumpPicturebox;
        private System.Windows.Forms.PictureBox marioHammerPicturebox;
        private System.Windows.Forms.PictureBox marioSpikeJumpPicturebox;
        private System.Windows.Forms.PictureBox marioHurtPicturebox;
        private System.Windows.Forms.PictureBox marioDefeatedPicturebox;
        private System.Windows.Forms.PictureBox marioWinPicturebox;
        private System.Windows.Forms.PictureBox spikedGoombaHurtPicturebox;
        private System.Windows.Forms.PictureBox spikedGoombaLaughPicturebox;
        private System.Windows.Forms.PictureBox spikedGoombaAttackPicturebox;
        private System.Windows.Forms.PictureBox hammerAttackPictureBox;
        private System.Windows.Forms.PictureBox enemyAttackPictureBox;
        private System.Windows.Forms.PictureBox tattlePictureBox;
        private System.Windows.Forms.Label enemy1HPLabel;
        private System.Windows.Forms.Label enemy2HPLabel;
        private System.Windows.Forms.Label enemy3HPLabel;
        private System.Windows.Forms.ToolTip noSelectHammerToolTip;
    }
}