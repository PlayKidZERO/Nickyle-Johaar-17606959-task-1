using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    class HeroClass:character
    {
        //this controls the hero of the game
        public HeroClass(int positionx, int positiony, int playerhp, char character = 'H', int playerdamage = 2) : base(positionx, positiony, character)
        {

        }
        //this displays the output throughout the game
        public override string ToString()
        {
            return "Your Values:\n"  + "\nPlayer Damage:" + PlayerDamage +"\t"+ "HitPoints:" + PlayerHP + "/" + PlayerMaxHP + "\n" + PositonX + "," + PositionY + "";

        }
        // this is return method
        public override MovementOfCharacter ReturnMove(MovementOfCharacter movementOfPlayer)
        {
            if (movementOfPlayer == MovementOfCharacter.Left)
            {
                if (PlayerObserver[0] is emptyTile)
                {
                    movementOfPlayer = MovementOfCharacter.Left;
                    PositonX--;
                }
                else
                {
                    movementOfPlayer = MovementOfCharacter.NoMovement;
                }
            }
            else if (movementOfPlayer == MovementOfCharacter.Up)
            {
                if (PlayerObserver[1] is emptyTile)
                {
                    movementOfPlayer = MovementOfCharacter.Up;
                    PositionY--;
                }
                else
                {
                    movementOfPlayer = MovementOfCharacter.NoMovement;
                }
            }
            else if (movementOfPlayer == MovementOfCharacter.Right)
            {
                if (PlayerObserver[2] is emptyTile)
                {
                    movementOfPlayer = MovementOfCharacter.Right;
                    PositonX++;
                }
                else
                {
                    movementOfPlayer = MovementOfCharacter.NoMovement;
                }
            }
            else if (movementOfPlayer == MovementOfCharacter.Down)
            {
                if (PlayerObserver[3] is emptyTile)
                {
                    movementOfPlayer = MovementOfCharacter.Down;
                    PositionY++;
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
