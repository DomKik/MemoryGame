namespace MemoryGameLab3
{
    partial class Configuration
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
            this.OKButtonConfiguration = new System.Windows.Forms.Button();
            this.typeLabelConfiguration = new System.Windows.Forms.Label();
            this.easyButtonConfiguration = new System.Windows.Forms.Button();
            this.mediumButtonConfiguration = new System.Windows.Forms.Button();
            this.hardButtonConfiguration = new System.Windows.Forms.Button();
            this.modeConfiguration = new System.Windows.Forms.Label();
            this.milisecondsForOneReversLabel = new System.Windows.Forms.Label();
            this.secondsForReversLabel = new System.Windows.Forms.Label();
            this.milisecondsForOneReversTextBox = new System.Windows.Forms.TextBox();
            this.secondsForReversTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKButtonConfiguration
            // 
            this.OKButtonConfiguration.Location = new System.Drawing.Point(213, 469);
            this.OKButtonConfiguration.Name = "OKButtonConfiguration";
            this.OKButtonConfiguration.Size = new System.Drawing.Size(75, 23);
            this.OKButtonConfiguration.TabIndex = 0;
            this.OKButtonConfiguration.Text = "OK";
            this.OKButtonConfiguration.UseVisualStyleBackColor = true;
            this.OKButtonConfiguration.Click += new System.EventHandler(this.OKButtonConfiguration_Click);
            // 
            // typeLabelConfiguration
            // 
            this.typeLabelConfiguration.AutoSize = true;
            this.typeLabelConfiguration.Location = new System.Drawing.Point(161, 48);
            this.typeLabelConfiguration.Name = "typeLabelConfiguration";
            this.typeLabelConfiguration.Size = new System.Drawing.Size(32, 15);
            this.typeLabelConfiguration.TabIndex = 1;
            this.typeLabelConfiguration.Text = "Tryb:";
            // 
            // easyButtonConfiguration
            // 
            this.easyButtonConfiguration.Location = new System.Drawing.Point(52, 85);
            this.easyButtonConfiguration.Name = "easyButtonConfiguration";
            this.easyButtonConfiguration.Size = new System.Drawing.Size(128, 23);
            this.easyButtonConfiguration.TabIndex = 2;
            this.easyButtonConfiguration.Text = "Łatwy ("+easy.ToString()+" kart)";
            this.easyButtonConfiguration.UseVisualStyleBackColor = true;
            this.easyButtonConfiguration.Click += new System.EventHandler(this.easyButtonConfiguration_Click);
            // 
            // mediumButtonConfiguration
            // 
            this.mediumButtonConfiguration.Location = new System.Drawing.Point(213, 85);
            this.mediumButtonConfiguration.Name = "mediumButtonConfiguration";
            this.mediumButtonConfiguration.Size = new System.Drawing.Size(156, 23);
            this.mediumButtonConfiguration.TabIndex = 3;
            this.mediumButtonConfiguration.Text = "Normalny ("+medium.ToString()+" kart)";
            this.mediumButtonConfiguration.UseVisualStyleBackColor = true;
            this.mediumButtonConfiguration.Click += new System.EventHandler(this.mediumButtonConfiguration_Click);
            // 
            // hardButtonConfiguration
            // 
            this.hardButtonConfiguration.Location = new System.Drawing.Point(401, 85);
            this.hardButtonConfiguration.Name = "hardButtonConfiguration";
            this.hardButtonConfiguration.Size = new System.Drawing.Size(114, 23);
            this.hardButtonConfiguration.TabIndex = 4;
            this.hardButtonConfiguration.Text = "Trudny ("+hard.ToString()+" kart)";
            this.hardButtonConfiguration.UseVisualStyleBackColor = true;
            this.hardButtonConfiguration.Click += new System.EventHandler(this.hardButtonConfiguration_Click);
            // 
            // modeConfiguration
            // 
            this.modeConfiguration.AutoSize = true;
            this.modeConfiguration.Location = new System.Drawing.Point(262, 48);
            this.modeConfiguration.Name = "modeConfiguration";
            this.modeConfiguration.Size = new System.Drawing.Size(38, 15);
            this.modeConfiguration.TabIndex = 5;
            this.modeConfiguration.Text = "Łatwy";
            // 
            // milisecondsForOneReversLabel
            // 
            this.milisecondsForOneReversLabel.AutoSize = true;
            this.milisecondsForOneReversLabel.Location = new System.Drawing.Point(161, 151);
            this.milisecondsForOneReversLabel.Name = "milisecondsForOneReversLabel";
            this.milisecondsForOneReversLabel.Size = new System.Drawing.Size(192, 15);
            this.milisecondsForOneReversLabel.TabIndex = 6;
            this.milisecondsForOneReversLabel.Text = "czas odwrócenia kart [milisekundy]";
            // 
            // secondsForReversLabel
            // 
            this.secondsForReversLabel.AutoSize = true;
            this.secondsForReversLabel.Location = new System.Drawing.Point(163, 263);
            this.secondsForReversLabel.Name = "secondsForReversLabel";
            this.secondsForReversLabel.Size = new System.Drawing.Size(239, 15);
            this.secondsForReversLabel.TabIndex = 7;
            this.secondsForReversLabel.Text = "czas odwrócenia kart na początku [sekundy]";
            // 
            // milisecondsForOneReversTextBox
            // 
            this.milisecondsForOneReversTextBox.Location = new System.Drawing.Point(213, 196);
            this.milisecondsForOneReversTextBox.Name = "milisecondsForOneReversTextBox";
            this.milisecondsForOneReversTextBox.Size = new System.Drawing.Size(100, 23);
            this.milisecondsForOneReversTextBox.TabIndex = 8;
            this.milisecondsForOneReversTextBox.Text = "1500";
            // 
            // secondsForReversTextBox
            // 
            this.secondsForReversTextBox.Location = new System.Drawing.Point(213, 323);
            this.secondsForReversTextBox.Name = "secondsForReversTextBox";
            this.secondsForReversTextBox.Size = new System.Drawing.Size(100, 23);
            this.secondsForReversTextBox.TabIndex = 9;
            this.secondsForReversTextBox.Text = "4";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 515);
            this.Controls.Add(this.secondsForReversTextBox);
            this.Controls.Add(this.milisecondsForOneReversTextBox);
            this.Controls.Add(this.secondsForReversLabel);
            this.Controls.Add(this.milisecondsForOneReversLabel);
            this.Controls.Add(this.modeConfiguration);
            this.Controls.Add(this.hardButtonConfiguration);
            this.Controls.Add(this.mediumButtonConfiguration);
            this.Controls.Add(this.easyButtonConfiguration);
            this.Controls.Add(this.typeLabelConfiguration);
            this.Controls.Add(this.OKButtonConfiguration);
            this.Name = "Configuration";
            this.Text = "Memory Game [konfiguracja]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OKButtonConfiguration;
        private Label typeLabelConfiguration;
        private Button easyButtonConfiguration;
        private Button mediumButtonConfiguration;
        private Button hardButtonConfiguration;
        private Label modeConfiguration;
        private Label milisecondsForOneReversLabel;
        private Label secondsForReversLabel;
        private TextBox milisecondsForOneReversTextBox;
        private TextBox secondsForReversTextBox;
    }
}