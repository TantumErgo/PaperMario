//NOTE: It's required to return the value of the SpotOnScreen property in case the user defeats enemies out of order (most notably if enemy2
//is defeated before enemy1 and enemy3. The List will resize, but the index values will not map to the locations of the PictureBoxes

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
        public int NearestGroundEnemy()
        {
            enemyList.ToArray();

            try
            {
                if (enemyList[0].IsFlying)
                {
                    if (enemyList[1].IsFlying)
                    {
                        if (enemyList[2].IsFlying)
                        {
                            return 0;
                        }
                        else
                        {
                            return enemyList[2].SpotOnScreen;
                        }
                    }
                    else
                    {
                        return enemyList[1].SpotOnScreen;
                    }
                }
                else
                {
                    return enemyList[0].SpotOnScreen;
                }
            }
            catch
            {
                return 0; 
            }
        }
    }
}
