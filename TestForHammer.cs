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
        public bool TestForHammer() //Hammer can only be used on nearest GROUND enemy
        {
            bool hammerResult;            
            enemyList.ToArray();

            try
            {
                if (enemyList[0].IsFlying)
                {
                    if (enemyList[1].IsFlying)
                    {
                        if (enemyList[2].IsFlying)
                        {
                            hammerResult = false;
                            return hammerResult;
                        }
                        else
                        {
                            return hammerResult = true;
                        }
                    }
                    else
                    {
                        return hammerResult = true;
                    }
                }
                else
                {
                    return hammerResult = true;
                }
            }
            catch
            {
                return hammerResult = false;
            }            
        }
    }
}