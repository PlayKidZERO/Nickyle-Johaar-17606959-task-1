using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    //this is a abstract class which holds protected variables
    abstract class Tile
    {
        protected int x;
        protected int y;
        protected string s;

        //this is the constructor which controls the positions
        public Tile(int positionx, int positiony, string characterS)
        {
            x = positionx;
            y = positiony;
            s = characterS;
        }
        //these are all the properties for the positions
        public int PositionX
        {
            get { return x; }
            set { x = value; }
        }
        public int PositionY
        {
            get { return y; }
            set { y = value; }
        }
        public string Character
        {
            get { return s; }
        }


    }

}
