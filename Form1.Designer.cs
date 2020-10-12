namespace Nickyle_Johaar_17606959_task_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MapOutPut = new System.Windows.Forms.Label();
            this.DisplayResults = new System.Windows.Forms.RichTextBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButon = new System.Windows.Forms.Button();
            this.OutPutOfGame = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.EnemyOutPut = new System.Windows.Forms.ComboBox();
            this.AttackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MapOutPut
            // 
            this.MapOutPut.AutoSize = true;
            this.MapOutPut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapOutPut.Location = new System.Drawing.Point(12, 9);
            this.MapOutPut.Name = "MapOutPut";
            this.MapOutPut.Size = new System.Drawing.Size(31, 15);
            this.MapOutPut.TabIndex = 0;
            this.MapOutPut.Text = "Map";
            // 
            // DisplayResults
            // 
            this.DisplayResults.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DisplayResults.Location = new System.Drawing.Point(457, 29);
            this.DisplayResults.Name = "DisplayResults";
            this.DisplayResults.Size = new System.Drawing.Size(226, 166);
            this.DisplayResults.TabIndex = 1;
            this.DisplayResults.Text = "";
            // 
            // UpButton
            // 
            this.UpButton.BackColor = System.Drawing.Color.Lime;
            this.UpButton.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.UpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpButton.Location = new System.Drawing.Point(492, 227);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(143, 30);
            this.UpButton.TabIndex = 2;
            this.UpButton.Text = "Move Up";
            this.UpButton.UseVisualStyleBackColor = false;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.BackColor = System.Drawing.Color.Lime;
            this.DownButton.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.DownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.Location = new System.Drawing.Point(492, 273);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(143, 30);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "Move Down";
            this.DownButton.UseVisualStyleBackColor = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RightButton.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(492, 322);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(143, 30);
            this.RightButton.TabIndex = 4;
            this.RightButton.Text = "Move Right";
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButon
            // 
            this.LeftButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LeftButon.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.LeftButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButon.Location = new System.Drawing.Point(492, 371);
            this.LeftButon.Name = "LeftButon";
            this.LeftButon.Size = new System.Drawing.Size(143, 30);
            this.LeftButon.TabIndex = 5;
            this.LeftButon.Text = "Move Left";
            this.LeftButon.UseVisualStyleBackColor = false;
            this.LeftButon.Click += new System.EventHandler(this.LeftButon_Click);
            // 
            // OutPutOfGame
            // 
            this.OutPutOfGame.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OutPutOfGame.Location = new System.Drawing.Point(707, 29);
            this.OutPutOfGame.Name = "OutPutOfGame";
            this.OutPutOfGame.Size = new System.Drawing.Size(224, 166);
            this.OutPutOfGame.TabIndex = 8;
            this.OutPutOfGame.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(937, 29);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(937, 58);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(98, 23);
            this.LoadButton.TabIndex = 13;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click_1);
            // 
            // EnemyOutPut
            // 
            this.EnemyOutPut.BackColor = System.Drawing.SystemColors.ControlText;
            this.EnemyOutPut.ForeColor = System.Drawing.SystemColors.Window;
            this.EnemyOutPut.FormattingEnabled = true;
            this.EnemyOutPut.Location = new System.Drawing.Point(718, 227);
            this.EnemyOutPut.Name = "EnemyOutPut";
            this.EnemyOutPut.Size = new System.Drawing.Size(199, 21);
            this.EnemyOutPut.TabIndex = 14;
            // 
            // AttackButton
            // 
            this.AttackButton.BackColor = System.Drawing.Color.Red;
            this.AttackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackButton.Location = new System.Drawing.Point(718, 264);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(199, 49);
            this.AttackButton.TabIndex = 15;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = false;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1051, 491);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.EnemyOutPut);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OutPutOfGame);
            this.Controls.Add(this.LeftButon);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.DisplayResults);
            this.Controls.Add(this.MapOutPut);
            this.Name = "Form1";
            this.Text = "Hero Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MapOutPut;
        private System.Windows.Forms.RichTextBox DisplayResults;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButon;
        private System.Windows.Forms.RichTextBox OutPutOfGame;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ComboBox EnemyOutPut;
        private System.Windows.Forms.Button AttackButton;
    }
}

