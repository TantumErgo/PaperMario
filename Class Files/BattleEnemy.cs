using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper_Mario
{
    public abstract class BattleEnemy
    {
        //ID must be set in the base class because many functions take a generic BattleEnemy object and use the ID property's value
        //Code would become too complex if the aforementioned functions accepted derived objects as parameters
        public virtual int ID { get; private set; }

        public virtual int Health { get; set; }

        public virtual int MaxHealth { get; set; }

        public virtual int Defense { get; set; }

        public virtual bool IsSpiked { get; set; }

        public virtual bool IsFlying { get; set; }

        public virtual bool IsAlive { get; set; }
        //This property is necessary for displaying sprites correctly, because the List automatically resizes when items are deleted
        //The List is used for Attack logic, while the SpotOnScreen value remains constant, regardless of the size of the List
        //Enemies will remain in their starting places throughout the duration of their existence in the program
        public int SpotOnScreen { get; private set; }

        public virtual void Attack()
        {
            DamageForm damageForm = new DamageForm();
            damageForm.ShowDialog();
        }

        public BattleEnemy(int spotOnScreen, int id)
        {
            SpotOnScreen = spotOnScreen;
            ID = id;
        }
    }
}
