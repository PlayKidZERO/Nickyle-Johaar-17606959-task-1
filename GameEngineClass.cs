using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    class GameEngineClass
    {
        //creates the size of the map
        private MapClass mapDisplay = new MapClass(20, 30, 20, 40, 10);

        public MapClass MapDisplay
        {
            get { return mapDisplay; }
            set { mapDisplay = value; }
        }
        public void EnemyMove()
        {
            MovementOfCharacter movement;

            foreach (enemiesClass enemy in mapDisplay.playerEnemies)
            {
                movement = enemy.ReturnMove();
                mapDisplay.VisionUpdater();
            }
            mapDisplay.MapUpdater();
        }
        public override string ToString()
        {
            string mapOfGame = "";
            for (int i = 0; i < mapDisplay.WidthOfGameMap; i++)
            {
                for (int j = 0; j < mapDisplay.HeightOfGameMap; j++)
                {
                    mapOfGame += mapDisplay.gameMap[i, j].Character + " ";
                }
                mapOfGame += "\n";
            }
            return mapOfGame;
        }
        public bool PlayerCharacterMovement(MovementOfCharacter Dir)
        {
            if (mapDisplay.PlayerCharacter.ReturnMove(Dir) == MovementOfCharacter.NoMovement)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
