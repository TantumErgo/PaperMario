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
        private void SelectAttack() //default screen to begin each turn; user must select attack type
        {
            backToAttackSelectButton.Visible = false; //this is the button that calls SelectAttack(); once clicked it should be hidden
            userHPLabel.Text = "HP: " + BattleForm.CURRENT_MARIO_HP.ToString() + " / " + MAX_MARIO_HP;            
            attackType = AttackType.Default;

            hammerAttackPictureBox.Visible = false; //hides hammer sprite if hammer was the previous attack used
            enemyAttackPictureBox.Visible = false; //used to hide after an Enemy First Strike
            if(enemy1.IsAlive) //This test is required because enemy1BattlePicture is used in First Strikes
            {
                enemy1BattlePicture.Visible = true;
            }

            try
            {
                marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioDefault.png");
                marioDefaultPicturebox.Location = new Point(132, 138);

                DisplayEnemyDefaultSprites(enemy1);
                DisplayEnemyDefaultSprites(enemy2);
                DisplayEnemyDefaultSprites(enemy3);

                enemy1BattlePicture.Enabled = false; //enemies cannot be clickable until after user selects attack
                enemy2BattlePicture.Enabled = false;
                enemy3BattlePicture.Enabled = false;

                jumpPicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/Jump%20Picture.png"); //attack "button" for user selection
                jumpPicture.Visible = true;
                jumpPicture.Enabled = true;
                hammerPicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/Hammer%20Picture.png"); //attack "button" for user selection
                hammerPicture.Visible = true;
                tattlePictureBox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/TattleIcon.png"); //attack "button" for user selection
                tattlePictureBox.Visible = true;
                tattlePictureBox.Enabled = true;

                instructionLabel.Visible = true;
                instructionLabel.Text = "Select Your Attack";
            }
            catch
            {
                MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                Environment.Exit(1);
            }

            bool hammerEnabled = TestForHammer();            
            if (hammerEnabled) //Hammer cannot be used on flying enemies; if both ground enemies are dead, hammer cannot be selected  
            {
                hammerPicture.Enabled = true;
            }
            else
            {
                hammerPicture.Enabled = false;
            }
        }        
    }
}