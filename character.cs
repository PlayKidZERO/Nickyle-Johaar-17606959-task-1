using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    abstract class character : Tile
    {
        ////this control Character movement
        //public enum MovementOfCharacter
        //{
        //    NoMovement,
        //    Up,
        //    Down,
        //    Left,
        //    Right
        //}
        // this holds the values which the player has
        protected int playerHP;
        protected int playerDamage;
        protected int playerMaxHP;
        protected int goldPickUp;
        protected MovementOfCharacter moveToPosition;
        protected Tile[] playerObserver = new Tile[4];//this is the vision for the Character or player


        public character(int positionx, int positiony, string characterS) : base(positionx, positiony, characterS)
        {

        }
        public Tile[] PlayerObserver
        {
            get { return playerObserver; }
            set { playerObserver = value; }
        }
        public int PlayerHP
        {
            get { return playerHP; }
            set { playerHP = value; }
        }
        public int PlayerMaxHP
        {
            get { return playerMaxHP; }
            set { playerMaxHP = value; }
        }
        public int PlayerDamage
        {
            get { return playerDamage; }
            set { playerDamage = value; }
        }

        public int GoldPickUp
        {
            get { return goldPickUp; }
            set { goldPickUp = value; }
        }
        public MovementOfCharacter Movement
        {
            get { return moveToPosition; }
            set { moveToPosition = value; }
        }
        //this is a method for movement of the Character
        public void Move(MovementOfCharacter MovementOfCharacter)
        {
            if (MovementOfCharacter == MovementOfCharacter.Down)
            {
                PositionY++;
            }
            else if (MovementOfCharacter == MovementOfCharacter.Up)
            {
                PositionY--;
            }
            else if (MovementOfCharacter == MovementOfCharacter.Left)
            {
                PositionX--;
            }
            else if (MovementOfCharacter == MovementOfCharacter.Right)
            {
                PositionX++;
            }

        }
        //this places the move at zero in return method
        public abstract MovementOfCharacter ReturnMove(MovementOfCharacter move = 0);
        public abstract override string ToString();

        //this is the check range method
        public virtual bool CheckRange(character target)
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
        //Checks if player is dead
        public bool IsDead()
        {
            if (playerHP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //this is the method for picking up gold within the game
        public void PickUp(ItemClass golditem)
        {
            if (golditem is GoldClass)
            {
                GoldClass gold = (GoldClass)golditem;
                goldPickUp += gold.pointsOfGainGold;
            }
        }
        //this is the distanceto method
        public int DistanceTo(character target)
        {
            int distanceOfXposition;
            int distanceOfYposition;
            int totalDistance;

            distanceOfXposition = Math.Abs((PositionX - target.PositionX) * (PositionX - target.PositionX));
            distanceOfYposition = Math.Abs((PositionY - target.PositionY) * (PositionY - target.PositionY));

            totalDistance = (int)Math.Round(Math.Sqrt(distanceOfXposition + distanceOfYposition), 0);
            return totalDistance;
        }

        //this the attack method
        public virtual void Attack(character target)
        {
            target.PlayerHP -= playerDamage;
        }
    }
}
