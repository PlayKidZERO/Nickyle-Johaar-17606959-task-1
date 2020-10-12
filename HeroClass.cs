using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    class HeroClass : character
    {
        public HeroClass(int positionx, int positiony, int playerhp, string characterS = "H", int playerdamage = 2) : base(positionx, positiony, characterS)
        {
            PlayerHP = playerhp;
            PlayerDamage = playerdamage;
            PlayerMaxHP = playerhp;
        }
        public override string ToString()
        {
            return "Player Values:\n" + "PlayerHP:" + PlayerHP + "/" + PlayerMaxHP + "\nPlayer at position(" + PositionX + "," + PositionY + ")\n" + "Player Damage:" + PlayerDamage
                + "\nGold Earned: " + GoldPickUp;
        }
        //this is the return move method in the hero class
        public override MovementOfCharacter ReturnMove(MovementOfCharacter movementOfPlayer)
        {
            if (movementOfPlayer == MovementOfCharacter.Left)
            {
                if (PlayerObserver[1] is emptyTile || PlayerObserver[1] is ItemClass)
                {
                    movementOfPlayer = MovementOfCharacter.Left;
                    PositionY--;
                }
                else
                {
                    movementOfPlayer = MovementOfCharacter.NoMovement;
                }
            }
            else if (movementOfPlayer == MovementOfCharacter.Up)
            {
                if (PlayerObserver[0] is emptyTile || PlayerObserver[0] is ItemClass)
                {
                    movementOfPlayer = MovementOfCharacter.Up;
                    PositionX--;
                }
                else
                {
                    movementOfPlayer = MovementOfCharacter.NoMovement;
                }
            }
            else if (movementOfPlayer == MovementOfCharacter.Right)
            {
                if (PlayerObserver[3] is emptyTile || PlayerObserver[3] is ItemClass)
                {
                    movementOfPlayer = MovementOfCharacter.Right;
                    PositionY++;
                }
                else
                {
                    movementOfPlayer = MovementOfCharacter.NoMovement;
                }
            }
            else if (movementOfPlayer == MovementOfCharacter.Down)
            {
                if (PlayerObserver[2] is emptyTile || PlayerObserver[2] is ItemClass)
                {
                    movementOfPlayer = MovementOfCharacter.Down;
                    PositionX++;
                }
                else
                {
                    movementOfPlayer = MovementOfCharacter.NoMovement;
                }
            }
            return movementOfPlayer;
        }


    }
}
