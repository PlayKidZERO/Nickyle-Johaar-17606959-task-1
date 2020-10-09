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
        protected int playerDamage;
        protected int playerMaxHP;
        protected MovementOfCharacter moveToPosition;
        protected Tile[] playerObserver = new Tile[4];

        public Tile[] PlayerObserver//This is the vision
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
        
        public MovementOfCharacter Movement
        {
            get { return moveToPosition; }
            set { moveToPosition = value; }
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
           
        }
        public abstract MovementOfCharacter ReturnMove(MovementOfCharacter movement = 0);
        public abstract override string ToString();
        //this is the bool that controls the range
        public virtual bool CheckRange(character lookAtTarget)
        {
            if (DistanceTillTarget(lookAtTarget) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public character(int positionx, int positiony, string character) : base(positionx, positiony, character)
        {

        }
        // this controls the distance to the target
        private int DistanceTillTarget(character lookAtTarget)
        {
            int totalDistance;
            int distanceOfXposition;
            int distanceOfYposition;
            distanceOfXposition = Math.Abs((PositonX - lookAtTarget.PositonX) * (PositonX - lookAtTarget.PositonX));
            distanceOfYposition = Math.Abs((PositionY - lookAtTarget.PositionY) * (PositionY - lookAtTarget.PositionY));
            totalDistance = (int)Math.Round(Math.Sqrt(distanceOfXposition + distanceOfYposition), 0);
            return totalDistance;
        }
        public virtual void Attack(character lookAtTarget)
        {
            //I tried making this work but it kept crashing
        }
    }
}
