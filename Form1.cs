using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nickyle_Johaar_17606959_task_1
{
    public partial class Form1 : Form
    {
        List<enemiesClass> enemies = new List<enemiesClass>();
        GameEngineClass workingGameEngine;
        public Form1()
        {
            InitializeComponent();
            workingGameEngine = new GameEngineClass();
            MapDisplayOutPut();
            PlayerDisplayStatistics();
        }
        private void LoadButton_Click_1(object sender, EventArgs e)
        {
            workingGameEngine.LoadGame();
            enemies = new List<enemiesClass>();
            MapOutPut.Text = "";
            MapOutPut.Text = workingGameEngine.ToString();
            PlayerDisplayStatistics();

            foreach (enemiesClass enemySelected in workingGameEngine.MapDisplay.playerEnemies)
            {
                if (workingGameEngine.MapDisplay.PlayerCharacter.CheckRange(enemySelected) && enemySelected.IsDead() == false)
                {
                    enemies.Add(enemySelected);
                    EnemyOutPut.Items.Add(enemySelected.ToString());
                }
            }
        }
        public void MapDisplayOutPut()
        {
            MapOutPut.Text = workingGameEngine.ToString();
        }
        public void GameOperation()
        {
            enemies = new List<enemiesClass>();
            EnemyOutPut.Items.Clear();
            EnemyOutPut.Items.Remove(EnemyOutPut.SelectedItem);
            workingGameEngine.EnemyMove();
            MapOutPut.Text = "";
            MapOutPut.Text = workingGameEngine.ToString();
            PlayerDisplayStatistics();

            foreach (enemiesClass enemySelected in workingGameEngine.MapDisplay.playerEnemies)
            {
                if (workingGameEngine.MapDisplay.PlayerCharacter.CheckRange(enemySelected) && enemySelected.IsDead() == false)
                {
                    enemies.Add(enemySelected);
                    EnemyOutPut.Items.Add(enemySelected.ToString());
                }
            }
        }
       

        public void PlayerDisplayStatistics()
        {
            DisplayResults.Text = "";
            DisplayResults.Text = workingGameEngine.MapDisplay.PlayerCharacter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            workingGameEngine.SaveGame();
        }
        private void UpButton_Click(object sender, EventArgs e)
        {
            workingGameEngine.MovePlayer(MovementOfCharacter.Up);
            GameOperation();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            workingGameEngine.MovePlayer(MovementOfCharacter.Down);
            GameOperation();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            workingGameEngine.MovePlayer(MovementOfCharacter.Right);
            GameOperation();
        }

        private void LeftButon_Click(object sender, EventArgs e)
        {
            workingGameEngine.MovePlayer(MovementOfCharacter.Left);
            GameOperation();
        }
        
        private void AttackButton_Click(object sender, EventArgs e)
        {
            if (EnemyOutPut.SelectedText != " ")
            {
                workingGameEngine.MapDisplay.PlayerCharacter.Attack(enemies[EnemyOutPut.SelectedIndex]);
                OutPutOfGame.Text = enemies[EnemyOutPut.SelectedIndex].ToString();
                workingGameEngine.EnemyAttack();
                MapOutPut.Text = "";
                MapOutPut.Text = workingGameEngine.ToString();
                PlayerDisplayStatistics();
            }
        }

        
    }
}
