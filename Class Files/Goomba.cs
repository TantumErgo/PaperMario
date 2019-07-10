using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paper_Mario.Properties;

namespace Paper_Mario
{
    public class Goomba : BattleEnemy
    {
        public Goomba(int spotOnScreen) : base(spotOnScreen, 1)
        {
            Health = 2;
            MaxHealth = 2;
            Defense = 0;
            IsSpiked = false;
            IsFlying = false;
            IsAlive = true;
            
            BattleForm.enemyList.Add(this);
        }

        public override void Attack()
        {
            BattleForm.CURRENT_MARIO_HP -= 1;
            base.Attack(); 
            return;
        }
    }
}
