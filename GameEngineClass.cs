using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Nickyle_Johaar_17606959_task_1
{
    public enum TileType
    {
        Hero,
        Enemy,
        Gold,
        Weapon
    }
    public enum MovementOfCharacter
    {
        NoMovement,
        Up,
        Down,
        Left,
        Right
    }
    class GameEngineClass
    {
        private MapClass mapDisplay = new MapClass(30, 30, 30, 60, 10, 10);

        public MapClass MapDisplay
        {
            get { return mapDisplay; }
            set { mapDisplay = value; }
        }
        //this method updates and moves the enemy within the game
        public void EnemyMove()
        {
            MovementOfCharacter playerMovement;
            mapDisplay.VisionUpdater();
            foreach (enemiesClass enemySelect in mapDisplay.playerEnemies)
            {
                mapDisplay.VisionUpdater();
                playerMovement = enemySelect.ReturnMove();
                if (enemySelect is GoblinClass)
                {
                    if (enemySelect.CheckRange(mapDisplay.PlayerCharacter))
                    {
                        enemySelect.Attack(mapDisplay.PlayerCharacter);
                    }
                }
                else if (enemySelect is MageClass)
                {
                    if (enemySelect.CheckRange(mapDisplay.PlayerCharacter))
                    {
                        enemySelect.Attack(mapDisplay.PlayerCharacter);
                    }
                    for (int i = 0; i < mapDisplay.playerEnemies.Length; i++)
                    {
                        if (mapDisplay.playerEnemies[i].PositionX != enemySelect.PositionX && mapDisplay.playerEnemies[i].PositionY != enemySelect.PositionY)
                        {
                            if (enemySelect.CheckRange(mapDisplay.playerEnemies[i]))
                            {
                                enemySelect.Attack(mapDisplay.playerEnemies[i]);
                            }
                        }
                    }
                }
                mapDisplay.MapUpdater();
            }

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
        //this is the load  method
        public void LoadGame()
        {
            BinaryFormatter format = new BinaryFormatter();
            FileStream file = new FileStream("file.bin", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (file)
                {
                    MapClass mapD = (MapClass)format.Deserialize(file);
                    mapDisplay = mapD;
                }
                mapDisplay.MapUpdater();
                MessageBox.Show("Game Loaded");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
        }
        //this is the save game method
        public void SaveGame()
        {
            BinaryFormatter format = new BinaryFormatter();
            FileStream file = new FileStream("file.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (file)
                {
                    format.Serialize(file, mapDisplay);
                }
                MessageBox.Show("Game Saved");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        //this is for the PLAYER MOVEMENT
        public bool MovePlayer(MovementOfCharacter dir)
        {
            if (mapDisplay.PlayerCharacter.ReturnMove(dir) == MovementOfCharacter.NoMovement)
            {
                return false;
            }
            else
            {
                ItemClass pickUp = mapDisplay.GetItemAtPosition(mapDisplay.PlayerCharacter.PositionX, mapDisplay.PlayerCharacter.PositionY);
                if (pickUp != null)
                {
                    mapDisplay.PlayerCharacter.PickUp(pickUp);
                }
                return true;
            }
        }
        //this is the enemy attack method
        public void EnemyAttack()
        {
            mapDisplay.MapUpdater();
            foreach (enemiesClass enemySelect in mapDisplay.playerEnemies)
            {
                if (enemySelect is GoblinClass)
                {
                    if (enemySelect.CheckRange(mapDisplay.PlayerCharacter))
                    {
                        enemySelect.Attack(mapDisplay.PlayerCharacter);
                    }
                }
                else if (enemySelect is MageClass)
                {
                    if (enemySelect.CheckRange(mapDisplay.PlayerCharacter))
                    {
                        enemySelect.Attack(mapDisplay.PlayerCharacter);
                    }
                    for (int i = 0; i < mapDisplay.playerEnemies.Length; i++)
                    {
                        if (mapDisplay.playerEnemies[i].PositionX != enemySelect.PositionX && mapDisplay.playerEnemies[i].PositionY != enemySelect.PositionY)
                        {
                            if (enemySelect.CheckRange(mapDisplay.playerEnemies[i]))
                            {
                                enemySelect.Attack(mapDisplay.playerEnemies[i]);
                            }
                        }
                    }
                }
            }

        }


    }
}
