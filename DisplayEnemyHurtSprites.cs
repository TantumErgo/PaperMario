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
        public void DisplayEnemyHurtSprites(BattleEnemy clickedEnemy)
        {
            switch (clickedEnemy.SpotOnScreen) //uses same logic as DisplayEnemyDefaultSprites, but calls a different function
            {
                case 1:
                    PictureBoxLoaderHurt(clickedEnemy);
                    return;
                case 2:
                    PictureBoxLoaderHurt(clickedEnemy);
                    return;
                case 3:
                    PictureBoxLoaderHurt(clickedEnemy);
                    return;
            }
        }

        public void PictureBoxLoaderHurt(BattleEnemy enemyToDisplay) //displays enemies' hurt sprites only
        {
            try
            {
                if (enemyToDisplay.SpotOnScreen == 1)
                {
                    if (enemyToDisplay is Goomba)
                        enemy1BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHurt.png");
                    else if (enemyToDisplay is SpikedGoomba)
                        enemy1BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoombaHurt.png");
                    else if (enemyToDisplay is Paragoomba)
                        enemy1BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHurt.png");
                }
                else if (enemyToDisplay.SpotOnScreen == 2)
                {
                    if (enemyToDisplay is Goomba)
                        enemy2BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHurt.png");
                    else if (enemyToDisplay is SpikedGoomba)
                        enemy2BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoombaHurt.png");
                    else if (enemyToDisplay is Paragoomba)
                        enemy2BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHurt.png");
                }
                else if (enemyToDisplay.SpotOnScreen == 3)
                {
                    if (enemyToDisplay is Goomba)
                        enemy3BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHurt.png");
                    else if (enemyToDisplay is SpikedGoomba)
                        enemy3BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoombaHurt.png");
                    else if (enemyToDisplay is Paragoomba)
                        enemy3BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaHurt.png");
                }
                return;
            }
            catch
            {
                MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                Environment.Exit(1);
            }
        }        
    }
}