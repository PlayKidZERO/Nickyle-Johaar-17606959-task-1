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
        GameEngineClass workingEngine;
        public Form1()
        {
            InitializeComponent();
            workingEngine = new GameEngineClass();
            MapOutput();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
        }
        public void MapOutput()
        {
            MapOutPut.Text = workingEngine.ToString();
        }
        public void GameOperation()
        {
            workingEngine.EnemyMove();
            MapOutPut.Text = "";
            MapOutPut.Text = workingEngine.ToString();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            workingEngine.PlayerCharacterMovement(MovementOfCharacter.Up);
            GameOperation();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            workingEngine.PlayerCharacterMovement(MovementOfCharacter.Down);
            GameOperation();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            workingEngine.PlayerCharacterMovement(MovementOfCharacter.Right);
            GameOperation();
        }

        private void LeftButon_Click(object sender, EventArgs e)
        {
            workingEngine.PlayerCharacterMovement(MovementOfCharacter.Left);
            GameOperation();
        }
    }
}
