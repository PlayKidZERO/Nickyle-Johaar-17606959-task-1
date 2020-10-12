using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    abstract class enemiesClass : character
    {
        protected Random select = new Random();

        public override string ToString()
        {
            return "by position [" + PositionX + "," + PositionY + "] damage: (" + PlayerDamage + ")";
        }
        public enemiesClass(int positionx, int positiony, string characterS, int playerdamage, int playerhp) : base(positionx, positiony, characterS)
        {
            PlayerMaxHP = playerhp;
            PlayerHP = playerhp;
            PlayerDamage = playerdamage;
        }

    }
}
