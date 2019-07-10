using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper_Mario
{
    class SpikedGoomba : BattleEnemy
    {
        public SpikedGoomba(int spotOnScreen) : base(spotOnScreen, 2)
        {
            Health = 2;
            MaxHealth = 2;
            Defense = 0;
            IsSpiked = true;
            IsFlying = false;
            IsAlive = true;

            BattleForm.enemyList.Add(this);
        }

        public override void Attack()
        {
            BattleForm.CURRENT_MARIO_HP -= 2;
            base.Attack();
            return;
        }
    }
}
