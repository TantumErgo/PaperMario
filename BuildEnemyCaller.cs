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
        public BattleEnemy BuildEnemyCaller(BattleEnemy enemyToSet, int id, int spotOnScreen) //named this because this function calls the appropriate object's constructor
        {
            switch(id)
            {
                case 1:
                    enemyToSet = new Goomba(spotOnScreen);
                    break;
                case 2:
                    enemyToSet = new SpikedGoomba(spotOnScreen);
                    break;
                case 3:
                    enemyToSet = new Paragoomba(spotOnScreen);
                    break;
            }
            return enemyToSet;
        }
    }
}
