using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    class MapClass
    {
        public Tile[,] gameMap;
        public enemiesClass[] playerEnemies;
        public Random roll = new Random();
        private int heightOfGameMap;
        private int widthOfGameMap;
        private int numberOfenemies;
        private HeroClass playerCharacter;


        public int HeightOfGameMap
        {
            get { return heightOfGameMap; }
            set { heightOfGameMap = value; }
        }
        public int WidthOfGameMap
        {
            get { return widthOfGameMap; }
            set { widthOfGameMap = value; }
        }
        public int NumberOfEnemies
        {
            get { return numberOfenemies; }
            set { numberOfenemies = value; }
        }
        public HeroClass PlayerCharacter
        {
            get { return playerCharacter; }
            set { playerCharacter = value; }
        }


        private Tile CreateTile(TileType typeOfTile)
        {
            int randomisePositionX = roll.Next(0, WidthOfGameMap);
            int randomisePositionY = roll.Next(0, HeightOfGameMap);

            while (gameMap[randomisePositionX, randomisePositionY] is Obstacle || gameMap[randomisePositionX, randomisePositionY] is character)
            {
                randomisePositionX = roll.Next(0, WidthOfGameMap);
                randomisePositionY = roll.Next(0, HeightOfGameMap);
            }
            if (typeOfTile == TileType.Hero)
            {
                playerCharacter = new HeroClass(randomisePositionX, randomisePositionY, 20);
                return playerCharacter;
            }
            
            else
            {
                return new GoblinClass(randomisePositionX, randomisePositionY);
            }

        }
        public void MapfullUpdate()
        {
            for (int x = 0; x < WidthOfGameMap; x++)
            {
                for (int y = 0; y < HeightOfGameMap; y++)
                {
                    gameMap[x, y] = new emptyTile(x, y);
                }
            }
        }
        public void MapUpdater()
        {
            MapInitialization();
            gameMap[playerCharacter.PositonX, playerCharacter.PositionY] = playerCharacter;

            foreach (enemiesClass enemySelect in playerEnemies)
            {
                gameMap[enemySelect.PositonX, enemySelect.PositionY] = enemySelect;
            }
        }
        public void MapInitialization()
        {
            for (int x = 0; x < WidthOfGameMap; x++)
            {
                for (int y = 0; y < HeightOfGameMap; y++)
                {
                    gameMap[x, y] = new emptyTile(x, y);
                }
            }
            GenerateOB();
        }
        //this is the contructor of the game
        public MapClass(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberOfenemies)
        {
            this.WidthOfGameMap = roll.Next(minWidth, maxWidth);
            this.HeightOfGameMap = roll.Next(minHeight, maxHeight);
            this.NumberOfEnemies = numberOfenemies;

            gameMap = new Tile[WidthOfGameMap, HeightOfGameMap];
            playerEnemies = new enemiesClass[NumberOfEnemies];
            MapfullUpdate();
            MapInitialization();
            Tile characterHero = CreateTile(TileType.Hero);
            gameMap[playerCharacter.PositonX, playerCharacter.PositionY] = characterHero;


            for (int i = 0; i < playerEnemies.Length; i++)
            {
                playerEnemies[i] = (enemiesClass)CreateTile(TileType.Enemy);
                gameMap[playerEnemies[i].PositonX, playerEnemies[i].PositionY] = playerEnemies[i];
            }
            VisionUpdater();
        }
        //this method is for spawning
        public void GenerateOB()
        {
            for (int x = 0; x < WidthOfGameMap; x++)
            {
                for (int y = 0; y < HeightOfGameMap; y++)
                {
                    if (x == 0 || y == 0 || x == WidthOfGameMap - 1 || y == heightOfGameMap - 1)
                    {
                        gameMap[x, y] = new Obstacle(x, y,"X");
                    }
                }
            }
        }

        public void VisionUpdater()
        {
            playerCharacter.PlayerObserver[0] = gameMap[playerCharacter.PositonX - 1, playerCharacter.PositionY];
            playerCharacter.PlayerObserver[1] = gameMap[playerCharacter.PositonX , playerCharacter.PositionY-1];
            playerCharacter.PlayerObserver[2] = gameMap[playerCharacter.PositonX + 1, playerCharacter.PositionY];
            playerCharacter.PlayerObserver[3] = gameMap[playerCharacter.PositonX , playerCharacter.PositionY+1];

            foreach (enemiesClass enemySelect in playerEnemies)
            {
                enemySelect.PlayerObserver[0] = gameMap[enemySelect.PositonX -1, enemySelect.PositionY];
                enemySelect.PlayerObserver[1] = gameMap[enemySelect.PositonX , enemySelect.PositionY - 1];
                enemySelect.PlayerObserver[2] = gameMap[enemySelect.PositonX + 1, enemySelect.PositionY];
                enemySelect.PlayerObserver[3] = gameMap[enemySelect.PositonX, enemySelect.PositionY + 1];
            }
        }
       

    }
}
