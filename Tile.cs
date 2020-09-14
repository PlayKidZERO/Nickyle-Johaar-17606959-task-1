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

        //public Tile(int xPos, int yPos)
        //{
        //    this.x = xPos;
        //    this.y= yPos;
        //}
    }
    public enum TileType
    {
        Hero,
        Enemy,
        Gold,
        weapon,
    }
   
}
