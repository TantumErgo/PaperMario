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
        public void Tattle(BattleEnemy enemyToTattle) //retrieves enemy info from database and displays to user
        {
            try
            {
                using (var db = new EnemyDatabaseContext4())
                {
                    var query = from g in db.Enemies
                                where g.EnemyId == enemyToTattle.ID
                                select g;

                    foreach (var item in query)
                    {
                        TattleForm tattleForm = new TattleForm(item);
                        tattleForm.ShowDialog();
                    }
                }
            }
            catch //Mainly used to catch SqlException when attempting to communicate with database; attempts again by re-sending data
            {
                BattleEnemy enemyToResend = enemyToTattle;
                Tattle(enemyToResend);
            }

            for (int i = 0; i < (enemyList.ToArray()).Length; i++) //This for loop makes enemy HP bars visible
            {
                var tattledEnemyType = enemyToTattle.GetType(); //once one enemy of any type is Tattled, HP bars of all enemies of that type are visible
                if (enemyList[i].GetType() == tattledEnemyType)
                {
                    switch (enemyList[i].SpotOnScreen)
                    {
                        case 1:
                            enemy1HPLabel.Visible = true;
                            enemy1HPLabel.Text = "HP: " + enemy1.Health + " / " + enemy1.MaxHealth;
                            break;
                        case 2:
                            enemy2HPLabel.Visible = true;
                            enemy2HPLabel.Text = "HP: " + enemy2.Health + " / " + enemy2.MaxHealth;
                            break;
                        case 3:
                            enemy3HPLabel.Visible = true;
                            enemy3HPLabel.Text = "HP: " + enemy3.Health + " / " + enemy3.MaxHealth;
                            break;
                    }
                }
            }
        }
    }
}