using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    //enemy class that controlls damage 
    abstract class enemiesClass: character
    {
        protected Random select = new Random();

        public override string ToString()
        {
            return "your position: " + PositonX + "," + PositionY + "damage: " + PlayerDamage;
        }
        public enemiesClass(int positionx, int positiony, string character, int playerhp,int playerdamage ) : base(positionx, positiony, character)
        {
            PlayerMaxHP = playerhp;
            PlayerHP = playerhp;
            PlayerDamage = playerdamage;
        }

    }
}
