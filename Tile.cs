using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    public abstract class Tile
    {
        protected int x;
        protected int y;
        protected char s;

        //properties
        public int PositionY
        {
            get { return y; }
            set { y = value; }
        }
        public int PositonX
        {
            get { return x; }
            set { x = value; }
        }
        public char Character
        {
            get { return s; }
        }

        //constructor
        public Tile(int positionx, int positiony, char character)
        {
            y = positiony;
            x = positionx;
            s = character;
        }
    }
    public enum TileType
    {
        Hero,
        Enemy,
        Gold,
        weapon
    }
   
}
