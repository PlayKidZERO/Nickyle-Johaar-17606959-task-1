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
            this.SuspendLayout();
            // 
            // MapOutPut
            // 
            this.MapOutPut.AutoSize = true;
            this.MapOutPut.Location = new System.Drawing.Point(38, 59);
            this.MapOutPut.Name = "MapOutPut";
            this.MapOutPut.Size = new System.Drawing.Size(28, 13);
            this.MapOutPut.TabIndex = 0;
            this.MapOutPut.Text = "Map";
            // 
            // DisplayResults
            // 
            this.DisplayResults.Location = new System.Drawing.Point(457, 29);
            this.DisplayResults.Name = "DisplayResults";
            this.DisplayResults.Size = new System.Drawing.Size(226, 166);
            this.DisplayResults.TabIndex = 1;
            this.DisplayResults.Text = "";
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(492, 227);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(143, 30);
            this.UpButton.TabIndex = 2;
            this.UpButton.Text = "Move Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(492, 273);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(143, 30);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "Move Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(492, 322);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(143, 30);
            this.RightButton.TabIndex = 4;
            this.RightButton.Text = "Move Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButon
            // 
            this.LeftButon.Location = new System.Drawing.Point(492, 371);
            this.LeftButon.Name = "LeftButon";
            this.LeftButon.Size = new System.Drawing.Size(143, 30);
            this.LeftButon.TabIndex = 5;
            this.LeftButon.Text = "Move Left";
            this.LeftButon.UseVisualStyleBackColor = true;
            this.LeftButon.Click += new System.EventHandler(this.LeftButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 491);
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
    }
}

