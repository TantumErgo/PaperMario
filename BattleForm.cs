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
        public const int TYPES_OF_ENEMIES = 3; //holds the number of functional enemies in the database; is used in generating random enemies
        public static int MAX_MARIO_HP = 25;
        public static int CURRENT_MARIO_HP = MAX_MARIO_HP;       
        
        public static List<BattleEnemy> enemyList = new List<BattleEnemy> (); //List is for use with the for loop that controls Enemies' attacks

        private BattleEnemy enemy1; 
        private BattleEnemy enemy2; 
        private BattleEnemy enemy3;  
        
        public enum AttackType //will be passed as parameter to various sprite display funtions and will be used in object damage logic
        {
            Default,
            Jump,
            Hammer,
            Tattle
        }
        
        public static AttackType attackType; //variable to hold the enum      

        public BattleForm()
        {
            InitializeComponent();

            CreateEnemies(); //creates enemy objects in memory; NOTE: sprites are displayed separately from object logic, because sprites are not associated directly with the object in the code
            DisplayEnemyDefaultSprites(enemy1);
            DisplayEnemyDefaultSprites(enemy2);
            DisplayEnemyDefaultSprites(enemy3);

            if (EnemyAppearsForm.userWon)
            {
                attackType = AttackType.Jump;
                DisplayEnemyHurtSprites(enemy1);
                DisplayUserAttackSprites(attackType, enemy1);
                userHPLabel.Text = "HP: " + BattleForm.CURRENT_MARIO_HP.ToString() + " / " + MAX_MARIO_HP;
                instructionLabel.Text = "The Enemy Took 1 Damage!";
            }
            else
            {
                DisplayEnemyAttackSprites(enemyList[0]); 
                enemyList[0].Attack();
                userHPLabel.Text = "HP: " + BattleForm.CURRENT_MARIO_HP.ToString() + " / " + MAX_MARIO_HP;
                instructionLabel.Text = "You Took 1 Damage!";
            }

            backToAttackSelectButton.Visible = true;                       
        }

        private void backToAttackSelectButton_Click(object sender, EventArgs e)
        {
            SelectAttack();
        }

        private void BattleForm_Load(object sender, EventArgs e) //everything in this event is used for debug only
        {
            /*//debugging Tattle
            TattleDebugForm tattleDebug = new TattleDebugForm();
            tattleDebug.ShowDialog(); */
        }

        private void jumpPicture_Click(object sender, EventArgs e) //after user selects attack by clicking on the icon, next has to click an enemy
        {
            attackType = AttackType.Jump;
            enemy1BattlePicture.Enabled = true;
            enemy2BattlePicture.Enabled = true;
            enemy3BattlePicture.Enabled = true;

            instructionLabel.Text = "Select Enemy to Attack";
            backToAttackSelectButton.Visible = true; //button to return to default screen

            hammerPicture.Visible = false;
            hammerPicture.Enabled = false;
            tattlePictureBox.Visible = false;
            jumpPicture.Enabled = false;
        }

        private void hammerPicture_Click(object sender, EventArgs e) //same as above, with additional constraints
        {
            attackType = AttackType.Hammer;

            int nearestGroundEnemy = 0;
            nearestGroundEnemy = NearestGroundEnemy();

            switch (nearestGroundEnemy)
            {
                case 1:
                    enemy1BattlePicture.Enabled = true;
                    break;
                case 2:
                    enemy2BattlePicture.Enabled = true;
                    break;
                case 3:
                    enemy3BattlePicture.Enabled = true;
                    break;
                default:
                    break;
            }

            instructionLabel.Text = "Hammer Can Only Be Used On Nearest Ground Enemy";
            backToAttackSelectButton.Visible = true;

            jumpPicture.Visible = false;
            tattlePictureBox.Visible = false;
            hammerPicture.Enabled = false;            
        }

        private void tattlePictureBox_Click(object sender, EventArgs e)
        {
            attackType = AttackType.Tattle;
            enemy1BattlePicture.Enabled = true;
            enemy2BattlePicture.Enabled = true;
            enemy3BattlePicture.Enabled = true;

            instructionLabel.Text = "Select Enemy to Attack";
            backToAttackSelectButton.Visible = true; //button to return to default screen

            hammerPicture.Visible = false;
            hammerPicture.Enabled = false;
            jumpPicture.Visible = false;
            tattlePictureBox.Enabled = false;
        }

        private void enemy1BattlePicture_Click(object sender, EventArgs e) //clicking enemy picture completes user's turn
        {
            enemy1BattlePicture.Enabled = false;
            enemy2BattlePicture.Enabled = false;
            enemy3BattlePicture.Enabled = false;
            backToAttackSelectButton.Visible = false;

            if (attackType == AttackType.Tattle)
            {
                DisplayUserAttackSprites(attackType, enemy1);
                Tattle(enemy1);                                
            }
            else
            {
                DisplayEnemyHurtSprites(enemy1);
                DisplayUserAttackSprites(attackType, enemy1);
                enemy1HPLabel.Text = "HP: " + enemy1.Health + " / " + enemy1.MaxHealth;
            }

            if (enemy1.Health <= 0) //tests to see if enemy1 is still alive after user attacks
            {
                enemy1.IsAlive = false;
                enemy1BattlePicture.Visible = false;
                enemyList.Remove(enemy1);
                enemy1HPLabel.Visible = false;               
            }

            enemyAttackButton.Visible = true; //click this button to call enemy attacks and end user's turn
        }

        private void enemy2BattlePicture_Click(object sender, EventArgs e)
        {
            enemy1BattlePicture.Enabled = false;
            enemy2BattlePicture.Enabled = false;
            enemy3BattlePicture.Enabled = false;

            if (attackType == AttackType.Tattle)
            {
                DisplayUserAttackSprites(attackType, enemy2);
                Tattle(enemy2);
            }
            else
            {
                DisplayEnemyHurtSprites(enemy2);
                DisplayUserAttackSprites(attackType, enemy2);
                enemy2HPLabel.Text = "HP: " + enemy2.Health + " / " + enemy2.MaxHealth;
            }

            backToAttackSelectButton.Visible = false;

            if(enemy2.Health <= 0) 
            {
                enemy2.IsAlive = false;
                enemy2BattlePicture.Visible = false;
                enemyList.Remove(enemy2);
                enemy2HPLabel.Visible = false;
            }

            enemyAttackButton.Visible = true;
        }

        private void enemy3BattlePicture_Click(object sender, EventArgs e)
        {
            enemy3BattlePicture.Enabled = false;
            enemy1BattlePicture.Enabled = false;
            enemy2BattlePicture.Enabled = false;
            backToAttackSelectButton.Visible = false;

            if (attackType == AttackType.Tattle)
            {
                DisplayUserAttackSprites(attackType, enemy3);                
                Tattle(enemy3);
            }
            else
            {
                DisplayEnemyHurtSprites(enemy3);
                DisplayUserAttackSprites(attackType, enemy3);
                enemy3HPLabel.Text = "HP: " + enemy3.Health + " / " + enemy3.MaxHealth;
            }

            if (enemy3.Health <= 0)
            {
                enemy3.IsAlive = false;
                enemy3BattlePicture.Visible = false;
                enemyList.Remove(enemy3);
                enemy3HPLabel.Visible = false;
            }

            enemyAttackButton.Visible = true;
        }

        private void enemyAttackButton_Click(object sender, EventArgs e)
        {
            enemyAttackButton.Visible = false; //hide button when clicked
            SelectAttack(); //called to reset all sprites to their defaults before launching enemy attacks
            instructionLabel.Visible = false; //this and next few lines hides additional sprites after defaults are reset
            jumpPicture.Visible = false;
            hammerPicture.Visible = false;
            tattlePictureBox.Visible = false;

            for (int i = 0; i < (enemyList.ToArray()).Length; i++)
            {
                DisplayEnemyAttackSprites(enemyList[i]); //displays sprites for the UI
                enemyList[i].Attack(); //updates object logic
                DisplayHiddenSprites(enemyList[i]); //re-displays the default sprite in the enemy#PictureBox and hides enemyAttackPictureBox)                                
                userHPLabel.Text = "HP: " + BattleForm.CURRENT_MARIO_HP.ToString() + " / " + MAX_MARIO_HP;
            }

            instructionLabel.Visible = true; 
            backToAttackSelectButton.Visible = true; //after enemies' attacks complete, user must click this button to go back to the default screen

            try
            {
                marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioDefault.png");
            }
            catch
            {
                MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                Environment.Exit(1);
            }

            if (enemyList.Count == 0) //tests to see if the user won or lost the game
            {
                try
                {
                    marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioWin2.png");
                }
                catch
                {
                    MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                    Environment.Exit(1);
                }
                instructionLabel.Text = "You Win!";
                backToAttackSelectButton.Visible = false;
            }
            else if (BattleForm.CURRENT_MARIO_HP <= 0)
            {
                try
                {
                    marioDefaultPicturebox.Load("https://raw.githubusercontent.com/TantumErgo/PaperMario/master/MarioDefeated1.png");
                    marioDefaultPicturebox.Location = new Point(120, 200);
                }
                catch
                {
                    MessageBox.Show("Internet connection is required to run this program. Please check your internet connection and restart the program.");
                    Environment.Exit(1);
                }
                instructionLabel.Text = "You Lose!";
                backToAttackSelectButton.Visible = false;
            }
        }

        bool toolTipShown = false; //Tooltip is shown if user attempts to select the Hammer attack when there are only flying enemies remaining
        
        private void BattleForm_MouseDown(object sender, MouseEventArgs e)
        {
            Control ctrl = this.GetChildAtPoint(e.Location); //this is required because the Hammer "button" is actually a disabled pictureBox

            if (ctrl != null)
            {
                if (ctrl == this.hammerPicture && !toolTipShown && attackType != AttackType.Hammer)
                {
                    this.noSelectHammerToolTip.Active = true;
                    string toolTipString = this.noSelectHammerToolTip.GetToolTip(this.hammerPicture);
                    this.noSelectHammerToolTip.Show(toolTipString, this.hammerPicture, this.hammerPicture.Width/2, this.hammerPicture.Height/2);
                    toolTipShown = true;                    
                }
            }
            else //when user clicks off of the hammerPicture pictureBox control, the Tooltip disappears
            {
                this.noSelectHammerToolTip.Active = false;
                this.noSelectHammerToolTip.Hide(this.hammerPicture);
                toolTipShown = false;
            }
        }
    }
}
