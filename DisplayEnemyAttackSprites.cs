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
        public void DisplayEnemyAttackSprites(BattleEnemy currentListEnemy) 
        {
            enemyAttackPictureBox.Visible = true; //separate pictureBox control for the enemies' attacks
            HideEnemyDefaultPicture(currentListEnemy); //enemy cannot be visible in attack pictureBox and default pictureBox simultaneously
            try
            {
                if (currentListEnemy is Goomba)
                {
                    enemyAttackPictureBox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHeadbonkRotated.png");
                    enemyAttackPictureBox.Location = new Point(186, 23);
                }
                else if (currentListEnemy is SpikedGoomba)
                {
                    enemyAttackPictureBox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoombaHeadbonkRotated.png");
                    enemyAttackPictureBox.Location = new Point(186, 23);
                }
                else if (currentListEnemy is Paragoomba)
                {
                    enemyAttackPictureBox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/ParagoombaAttack.png");
                    enemyAttackPictureBox.Location = new Point(174, 70);
                }

                marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioHurt.png");
            }
            catch
            {
                MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                Environment.Exit(1);
            }
            return;
        }

        public void HideEnemyDefaultPicture(BattleEnemy enemyToHide)
        {
            switch (enemyToHide.SpotOnScreen)
            {
                case 1:
                    enemy1BattlePicture.Visible = false;
                    return;
                case 2:
                    enemy2BattlePicture.Visible = false;
                    return;
                case 3:
                    enemy3BattlePicture.Visible = false;
                    return;
            }
        }

        public void DisplayHiddenSprites(BattleEnemy attackingEnemy)
        {
            enemyAttackPictureBox.Visible = false;
            switch (attackingEnemy.SpotOnScreen)
            {
                case 1:
                    enemy1BattlePicture.Visible = true;
                    return;
                case 2:
                    enemy2BattlePicture.Visible = true;
                    return;
                case 3:
                    enemy3BattlePicture.Visible = true;
                    return;
            }
        }
    }
}