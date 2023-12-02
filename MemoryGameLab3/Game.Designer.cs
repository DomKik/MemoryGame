namespace MemoryGameLab3
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.timeCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeCounterTimer
            // 
            this.timeCounterTimer.Interval = 1000;
            this.timeCounterTimer.Tick += new System.EventHandler(this.timeCounterTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Game";
            this.Text = "Memory Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Shown += new System.EventHandler(this.Game_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timeCounterTimer;
    }
}