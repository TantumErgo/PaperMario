using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Mario
{
    public partial class BattleForm : Form
    {
        public void DisplayUserAttackSprites(AttackType selectedAttack, BattleEnemy enemyToAttack) 
        {
            if (selectedAttack == AttackType.Jump) //user takes damage instead if enemy is spiked and is jumped on
            {
                IsEnemySpiked(enemyToAttack);
            }
            else if (selectedAttack == AttackType.Hammer)
            {
                try
                {
                    marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioHammer.png");
                }
                catch
                {
                    MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                    Environment.Exit(1);
                }
                HammerSpriteDisplay(enemyToAttack); //the Hammer itself is a separate sprite in its own pictureBox control
                enemyToAttack.Health -= 1; //because damage logic is only one line, object logic is combined with UI logic
                instructionLabel.Text = "The Enemy Took 1 Damage! The Enemies Attack Next!";
            }
            else //Tattle attack does no damage
            {
                try
                {
                    marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioTattle.png");
                }
                catch
                {
                    MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                    Environment.Exit(1);
                }
                instructionLabel.Visible = false;
            }
        }

        public void IsEnemySpiked(BattleEnemy enemyToAttack) //primary focus of this function is displaying user sprite
        {
            if (enemyToAttack.IsSpiked) //sets the Image property of the pictureBox
            {
                try
                {
                    marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioSpikeJump.png");

                    switch (enemyToAttack.SpotOnScreen)
                    {
                        case 1:
                            enemy1BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoombaLaugh.png");
                            break;
                        case 2:
                            enemy2BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoombaLaugh.png");
                            break;
                        case 3:
                            enemy3BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoombaLaugh.png");
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                    Environment.Exit(1);
                }
                BattleForm.CURRENT_MARIO_HP -= 1; //because damage logic is only one line of code, object logic is combined with UI logic
                instructionLabel.Text = "You Took 1 Damage! The Enemies Attack Next!";
            }
            else
            {
                try
                {
                    marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioJump.png");
                }
                catch
                {
                    MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                    Environment.Exit(1);
                }
                enemyToAttack.Health -= 1;
                instructionLabel.Text = "The Enemy Took 1 Damage! The Enemies Attack Next!";
            }

            switch (enemyToAttack.SpotOnScreen) //sets the Location of the pictureBox
            {
                case 1:
                    {
                        marioDefaultPicturebox.Location = new Point(575, 65);
                        return;
                    }
                case 2:
                    {
                        marioDefaultPicturebox.Location = new Point(672, 20);
                        return;
                    }
                case 3:
                    {
                        marioDefaultPicturebox.Location = new Point(806, 18);
                        return;
                    }
            }
        }

        public void HammerSpriteDisplay(BattleEnemy enemyToAttack) 
        {
            hammerAttackPictureBox.Visible = true;

            switch (enemyToAttack.SpotOnScreen)
            {
                case 1:
                    marioDefaultPicturebox.Location = new Point(461, 160);
                    hammerAttackPictureBox.Location = new Point(548, 225);
                    return;
                case 2:
                    marioDefaultPicturebox.Location = new Point(587, 162);
                    hammerAttackPictureBox.Location = new Point(674, 227);
                    return;
                case 3:
                    marioDefaultPicturebox.Location = new Point(716, 150);
                    hammerAttackPictureBox.Location = new Point(803, 215);
                    return;
            }
        }
    }
}