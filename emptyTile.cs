﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    class emptyTile : Tile
    {
        public emptyTile(int positionx, int positiony, string characterS = ".") : base(positionx, positiony, characterS)
        {

        }
    }
}
