using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    class MapClass
    {
        private int widthOfGameMap;
        private int heightOfGameMap;
        private int numberOfenemies;

        public int WidthOfGameMap
        {
            get { return widthOfGameMap; }
            set { widthOfGameMap = value; }
        }
        public int HeightOfGameMap
        {
            get { return heightOfGameMap; }
            set { heightOfGameMap = value; }
        }
        public int NumberOfEnemies
        {
            get { return numberOfenemies; }
            set { numberOfenemies = value; }
        }
       
    }
}
