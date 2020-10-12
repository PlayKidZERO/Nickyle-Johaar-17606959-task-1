using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    class MageClass : enemiesClass
    {
        public MageClass(int positionx, int positiony, string characterS = "M", int playerdamage = 5, int playerhp = 5) : base(positionx, positiony, characterS, playerdamage, playerhp)
        {
            PlayerDamage = playerdamage;
            PlayerHP = playerhp;
            PlayerMaxHP = playerhp;
        }
        public override string ToString()
        {
            return "Mage by position (" + PositionX + "," + PositionY + ") Damage dealt by Mage:(" + PlayerDamage + ") PlayerHP:" + PlayerHP;
        }

        public override bool CheckRange(character target)
        {
            if (DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //this is the return method in the mage class
        public override MovementOfCharacter ReturnMove(MovementOfCharacter playerCharacterMovement = 0)
        {
            return MovementOfCharacter.NoMovement;
        }

    }
}
