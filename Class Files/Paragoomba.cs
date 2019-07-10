using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper_Mario
{
    class Paragoomba : BattleEnemy
    {
        public Paragoomba(int spotOnScreen) : base(spotOnScreen, 3)
        {
            Health = 2;
            MaxHealth = 2;
            Defense = 0;
            IsSpiked = false;
            IsFlying = true;
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