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
        public void DisplayEnemyDefaultSprites(BattleEnemy enemyToDisplay)
        {
            switch(enemyToDisplay.SpotOnScreen) //uses the property to determine the correct picturebox control to load
            {
                case 1:
                    PictureBoxLoader(enemyToDisplay);
                    return;
                case 2:
                    PictureBoxLoader(enemyToDisplay);                    
                    return;
                case 3:
                    PictureBoxLoader(enemyToDisplay);                    
                    return;
            }
        }

        public void PictureBoxLoader(BattleEnemy enemyToDisplay) 
        {
            try
            {
                if (enemyToDisplay.SpotOnScreen == 1)
                {
                    if (enemyToDisplay is Goomba)
                        enemy1BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaCropEnemy.png");
                    else if (enemyToDisplay is SpikedGoomba)
                        enemy1BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoomba.png");
                    else if (enemyToDisplay is Paragoomba)
                        enemy1BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/Paragoomba.png");
                }
                else if (enemyToDisplay.SpotOnScreen == 2)
                {
                    if (enemyToDisplay is Goomba)
                        enemy2BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaCropEnemy.png");
                    else if (enemyToDisplay is SpikedGoomba)
                        enemy2BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoomba.png");
                    else if (enemyToDisplay is Paragoomba)
                        enemy2BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/Paragoomba.png");
                }
                else if (enemyToDisplay.SpotOnScreen == 3)
                {
                    if (enemyToDisplay is Goomba)
                        enemy3BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/GoombaCropEnemy.png");
                    else if (enemyToDisplay is SpikedGoomba)
                        enemy3BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/SpikedGoomba.png");
                    else if (enemyToDisplay is Paragoomba)
                        enemy3BattlePicture.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/Paragoomba.png");
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