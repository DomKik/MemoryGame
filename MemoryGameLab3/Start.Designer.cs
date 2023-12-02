namespace MemoryGameLab3
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startGameStart = new System.Windows.Forms.Button();
            this.configurationStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz swoją nazwę";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 23);
            this.textBox1.TabIndex = 1;
            // 
            // startGameStart
            // 
            this.startGameStart.Location = new System.Drawing.Point(181, 222);
            this.startGameStart.Name = "startGameStart";
            this.startGameStart.Size = new System.Drawing.Size(130, 23);
            this.startGameStart.TabIndex = 2;
            this.startGameStart.Text = "rozpoczęcie gry";
            this.startGameStart.UseVisualStyleBackColor = true;
            this.startGameStart.Click += new System.EventHandler(this.startGameStart_Click);
            // 
            // configurationStart
            // 
            this.configurationStart.Location = new System.Drawing.Point(387, 222);
            this.configurationStart.Name = "configurationStart";
            this.configurationStart.Size = new System.Drawing.Size(112, 23);
            this.configurationStart.TabIndex = 3;
            this.configurationStart.Text = "konfiguruj";
            this.configurationStart.UseVisualStyleBackColor = true;
            this.configurationStart.Click += new System.EventHandler(this.configurationStart_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.configurationStart);
            this.Controls.Add(this.startGameStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button startGameStart;
        private Button configurationStart;
    }
}