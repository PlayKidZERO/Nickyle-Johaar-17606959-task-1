using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    //this control Character movement
    public  enum MovementOfCharacter
    {
        NoMovement,
        Up,
        Down,
        Left,
        Right
    }
    // this holds the values which the player has
    abstract class character:Tile
    {
        
        protected int playerHP;
        protected int playerMaxHP;
        protected int playerDamage;
        protected Tile[] playerObserver = new Tile[4];
        protected MovementOfCharacter moveToPosition;

        public int HP
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
        public Tile[] PlayerObserver
        {
            get { return playerObserver; }
            set { playerObserver = value; }
        }
        public MovementOfCharacter Movement
        {
            get { return moveToPosition; }
            set { moveToPosition = value; }
        }

        public character(int positionx, int positiony, char character) : base(positionx, positiony, character)
        {

        }
        public virtual void Attack(character lookAtTarget)
        {

        }
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
        // this controls the distance to the target
        private int DistanceTo(character lookAtTarget)
        {
            int distanceOfXposition;
            int distanceOfYposition;
            int totalDistance;     
            distanceOfXposition = Math.Abs((PositonX - lookAtTarget.PositonX) * (PositonX - lookAtTarget.PositonX));
            distanceOfYposition = Math.Abs((PositionY - lookAtTarget.PositionY) * (PositionY - lookAtTarget.PositionY));
            totalDistance = (int)Math.Round(Math.Sqrt(distanceOfXposition + distanceOfYposition), 0);
            return totalDistance;
        }
        //this is the bool that controls the range
        public virtual bool CheckRange(character lookAtTarget)
        {
            if (DistanceTo(lookAtTarget) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //this is a method for movement of the Character
        public void Move(MovementOfCharacter direction)
        {
            if (direction == MovementOfCharacter.Down)
            {
                PositionY++;
            }
            else if (direction == MovementOfCharacter.Up)
            {
                PositionY--;
            }
            else if (direction == MovementOfCharacter.Left)
            {
                PositonX--;
            }
            else if (direction == MovementOfCharacter.Right)
            {
                PositonX++;
            }
            else
            {
               
            }
        }
        public abstract MovementOfCharacter ReturnMove(MovementOfCharacter movement = 0);
        public abstract override string ToString();
    }
}
