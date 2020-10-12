using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    class GoldClass : ItemClass
    {
        private int goldPoints;
        private Random roll = new Random();
        //this is the gold class
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        public GoldClass(int positionx, int positiony, string characterS = "@") : base(positionx, positiony, characterS)
        {
            goldPoints = roll.Next(1, 6);
        }
        public int pointsOfGainGold
        {
            get { return goldPoints; }
            set { goldPoints = value; }
        }

    }
}
