using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Mario
{
    public partial class EnemyAppearsForm : Form
    {
        public static bool userWon;

        public EnemyAppearsForm()
        {
            InitializeComponent();            
        }

        private void firstStrikeButton_Click(object sender, EventArgs e) //This button will generate a random number for the enemy
        {                                                                //The numbers will be compared to determine the First Strike
            int enemyNumber; //variable to hold the random enemy number            
            int userNumber; //variable to hold the user-entered number
            
            Random rand = new Random(); //generate a random number for the enemy
            enemyNumber = rand.Next(100) + 1;

            if (int.TryParse(userNumberTextbox.Text, out userNumber)) //ensures input is an int
            {
                if (userNumber >= 1 && userNumber <= 100) //ensures input is 1-100
                {
                    if ((userNumber - enemyNumber) % 2 == 0)
                    {
                        userFirstStrikeLabel.Visible = true;
                        GoombaLosesPicture.Visible = true;
                        GoombaAppearsPicture.Visible = false;
                        EnemyAppearedLabel.Visible = false;
                        userWon = true;
                    }
                    else
                    {
                        enemyStrikesFirstLabel.Visible = true;
                        GoombaWinsPicture.Visible = true;
                        GoombaAppearsPicture.Visible = false;
                        EnemyAppearedLabel.Visible = false;
                        userWon = false;
                    }
                    firstStrikeButton.Visible = false;
                    startButton.Visible = true;
                    userNumberTextbox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You Must Enter a Number 1-100");
                }
            }
            else
            {
                MessageBox.Show("You Must Enter a Number 1-100");
            }            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            BattleForm myBattleForm = new BattleForm();
            myBattleForm.ShowDialog();
            this.Close();
        }        
    }
}