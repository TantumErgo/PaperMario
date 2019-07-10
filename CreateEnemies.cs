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
        public void CreateEnemies()
        {
            enemy1 = new Goomba(1); //in current version, Goomba is always enemy1 because Goomba always appears on the EnemyAppearsForm

            Random randEnemy = new Random();

            int enemy2_ID = randEnemy.Next(TYPES_OF_ENEMIES) + 1; //The random number generated will be one of the ID values of the current enemy classes available for building
            enemy2 = BuildEnemyCaller(enemy2, enemy2_ID, 2); //first parameter is the abstract object in memory to derive, second param is used as detailed above, third param is used for sprite display
            Thread.Sleep(2000); //Sleep function is used to ensure enough time passes before calling randomEnemy.Next()

            int enemy3_ID = randEnemy.Next(TYPES_OF_ENEMIES) + 1;
            enemy3 = BuildEnemyCaller(enemy3, enemy3_ID, 3);
            Thread.Sleep(2000);
        }
    }
}