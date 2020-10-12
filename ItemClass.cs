using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    abstract class ItemClass : Tile
    {
        //public abstract string ToString();
        public ItemClass(int positionx, int positiony, string characterS) : base(positionx, positiony, characterS)
        {

        }


    }
}
