using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{

    [Serializable]
    class GoblinClass : enemiesClass
    {
        public GoblinClass(int positionx, int positiony, string characterS = "G", int playerDamage = 1, int playerHp = 10) : base(positionx, positiony, characterS, playerDamage, playerHp)
        {

        }
        public override string ToString()
        {
            return "Goblin by position [" + PositionX + "," + PositionY + "] Damage dealt by Goblin:(" + PlayerDamage + ") Player HP:" + PlayerHP;
        }
        //this is the return move method within the goblin class
        public override MovementOfCharacter ReturnMove(MovementOfCharacter movementStructure = 0)
        {
            int randomRollSelect = select.Next(0, 4);
            movementStructure = MovementOfCharacter.NoMovement;

            while (movementStructure == MovementOfCharacter.NoMovement)
            {
                if (randomRollSelect == 0)
                {
                    if (PlayerObserver[0] is emptyTile)
                    {
                        movementStructure = MovementOfCharacter.Left;
                        PositionX--;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 4);
                    }
                }
                else if (randomRollSelect == 1)
                {
                    if (PlayerObserver[1] is emptyTile)
                    {
                        movementStructure = MovementOfCharacter.Up;
                        PositionY--;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 4);
                    }
                }
                else if (randomRollSelect == 2)
                {
                    if (PlayerObserver[2] is emptyTile)
                    {
                        movementStructure = MovementOfCharacter.Right;
                        PositionX++;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 4);
                    }
                }
                else if (randomRollSelect == 3)
                {
                    if (PlayerObserver[3] is emptyTile)
                    {
                        movementStructure = MovementOfCharacter.Down;
                        PositionY++;
                    }
                    else
                    {
                        randomRollSelect = select.Next(0, 4);
                    }
                }
                else
                {
                    movementStructure = MovementOfCharacter.NoMovement;
                }
            }
            return movementStructure;
        }

    }

}
