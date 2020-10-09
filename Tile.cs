using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    //this is a abstract class which holds protected variables
    public abstract class Tile
    {
        protected int x;
        protected int y;
        protected string s;

        //this is the constructor which controls the positions
        public Tile(int positionx, int positiony, string character)
        {
            y = positiony;
            x = positionx;
            s = character;
        }
        //these are all the properties for the positions
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
        public string Character
        {
            get { return s; }
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
