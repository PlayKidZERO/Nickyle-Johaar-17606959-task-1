using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickyle_Johaar_17606959_task_1
{
    [Serializable]
    class MapClass
    {
        public Tile[,] gameMap;
        public enemiesClass[] playerEnemies;
        public Random roll = new Random();
        private int heightOfGameMap;
        private int widthOfGameMap;
        private int numberOfenemies;
        private HeroClass playerCharacter;
        public ItemClass[] item;

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
        //this is the create method, the reason i call it create tile instead of create() is because it was easier for me to understand when using it
        private Tile CreateTile(TileType tiletype)
        {
            int randomX = roll.Next(0, WidthOfGameMap);
            int randomY = roll.Next(0, HeightOfGameMap);

            while (gameMap[randomX, randomY] is Obstacle || gameMap[randomX, randomY] is character || gameMap[randomX, randomY] is ItemClass)
            {
                randomX = roll.Next(0, WidthOfGameMap);
                randomY = roll.Next(0, HeightOfGameMap);
            }
            if (tiletype == TileType.Hero)
            {
                playerCharacter = new HeroClass(randomX, randomY, 100);//player hp assigned here!
                return playerCharacter;
            }
            else if (tiletype == TileType.Enemy)
            {
                int temp = roll.Next(1, 3);
                if (temp == 1)
                {
                    return new GoblinClass(randomX, randomY);
                }
                else
                {
                    return new MageClass(randomX, randomY);
                }
            }
            //this spawns the gold with the game
            else
            {
                return new GoldClass(randomX, randomY);
            }

        }
        public void MapFullUpdate()
        {
            for (int x = 0; x < WidthOfGameMap; x++)
            {
                for (int y = 0; y < HeightOfGameMap; y++)
                {
                    gameMap[x, y] = new emptyTile(x, y);
                }
            }
        }
        //this is the map update method
        public void MapUpdater()
        {
            MapInitialization();
            gameMap[playerCharacter.PositionX, playerCharacter.PositionY] = playerCharacter;

            foreach (enemiesClass enemySelect in playerEnemies)
            {
                if (enemySelect.IsDead() == false)
                {
                    gameMap[enemySelect.PositionX, enemySelect.PositionY] = enemySelect;
                }
            }
            foreach (ItemClass gold in item)
            {
                if (gold != null)
                {
                    gameMap[gold.PositionX, gold.PositionY] = gold;
                }
            }
        }
        //this is the map initialize method
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
        //This the constructer within the game
        public MapClass(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberOfenemies, int amountOfItems)
        {
            this.WidthOfGameMap = roll.Next(minWidth, maxWidth);
            this.HeightOfGameMap = roll.Next(minHeight, maxHeight);
            this.NumberOfEnemies = numberOfenemies;

            item = new ItemClass[amountOfItems];
            gameMap = new Tile[WidthOfGameMap, HeightOfGameMap];
            playerEnemies = new enemiesClass[NumberOfEnemies];

            MapFullUpdate();
            MapInitialization();

            Tile characterHero = CreateTile(TileType.Hero);
            gameMap[playerCharacter.PositionX, playerCharacter.PositionY] = characterHero;


            for (int i = 0; i < playerEnemies.Length; i++)
            {
                playerEnemies[i] = (enemiesClass)CreateTile(TileType.Enemy);
                gameMap[playerEnemies[i].PositionX, playerEnemies[i].PositionY] = playerEnemies[i];
            }
            for (int i = 0; i < item.Length; i++)
            {
                item[i] = (ItemClass)CreateTile(TileType.Gold);
                gameMap[item[i].PositionX, item[i].PositionY] = item[i];
            }
            VisionUpdater();
        }
        //this controls the item position on the map and the item pick up
        public ItemClass GetItemAtPosition(int x, int y)
        {
            ItemClass itemcollected = null;
            for (int j = 0; j < item.Length; j++)
            {
                if (item[j] != null)
                {
                    if (item[j].PositionX == x && item[j].PositionY == y)
                    {
                        itemcollected = item[j];
                        item[j] = null;
                    }
                }
            }
            return itemcollected;
        }
        //this the spawning method
        public void GenerateOB()
        {
            for (int x = 0; x < WidthOfGameMap; x++)
            {
                for (int y = 0; y < HeightOfGameMap; y++)
                {
                    if (x == 0 || y == 0 || x == WidthOfGameMap - 1 || y == HeightOfGameMap - 1)
                    {
                        gameMap[x, y] = new Obstacle(x, y, "X");
                    }
                }
            }
        }


        //this is the vision update method
        public void VisionUpdater()
        {
            playerCharacter.PlayerObserver[0] = gameMap[playerCharacter.PositionX - 1, playerCharacter.PositionY];
            playerCharacter.PlayerObserver[1] = gameMap[playerCharacter.PositionX, playerCharacter.PositionY - 1];
            playerCharacter.PlayerObserver[2] = gameMap[playerCharacter.PositionX + 1, playerCharacter.PositionY];
            playerCharacter.PlayerObserver[3] = gameMap[playerCharacter.PositionX, playerCharacter.PositionY + 1];

            foreach (enemiesClass enemySelect in playerEnemies)
            {
                enemySelect.PlayerObserver[0] = gameMap[enemySelect.PositionX - 1, enemySelect.PositionY];
                enemySelect.PlayerObserver[1] = gameMap[enemySelect.PositionX, enemySelect.PositionY - 1];
                enemySelect.PlayerObserver[2] = gameMap[enemySelect.PositionX + 1, enemySelect.PositionY];
                enemySelect.PlayerObserver[3] = gameMap[enemySelect.PositionX, enemySelect.PositionY + 1];
            }
        }

    }
}
