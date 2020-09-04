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
            this.SuspendLayout();
            // 
            // MapOutPut
            // 
            this.MapOutPut.AutoSize = true;
            this.MapOutPut.Location = new System.Drawing.Point(193, 182);
            this.MapOutPut.Name = "MapOutPut";
            this.MapOutPut.Size = new System.Drawing.Size(28, 13);
            this.MapOutPut.TabIndex = 0;
            this.MapOutPut.Text = "Map";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 412);
            this.Controls.Add(this.MapOutPut);
            this.Name = "Form1";
            this.Text = "Hero Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MapOutPut;
    }
}

