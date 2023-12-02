using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameLab3
{
    public partial class Configuration : Form
    {
        private int easy = 2, medium = 76, hard = 104;
        private int cardsNumber;

        public Configuration()
        {
            InitializeComponent();
            modeConfiguration.Text = "Łatwy";
            cardsNumber = easy;
        }

        private void easyButtonConfiguration_Click(object sender, EventArgs e)
        {
            modeConfiguration.Text = "Łatwy";
            cardsNumber = easy;
        }

        private void mediumButtonConfiguration_Click(object sender, EventArgs e)
        {
            modeConfiguration.Text = "Normalny";
            cardsNumber = medium;
        }

        private void hardButtonConfiguration_Click(object sender, EventArgs e)
        {
            modeConfiguration.Text = "Trudny";
            cardsNumber = hard;
        }

        private void OKButtonConfiguration_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public int getCardsNumber()
        {
            return cardsNumber;
        }

        public int getMilisecondsForRevers()
        {
            return Convert.ToInt32(milisecondsForOneReversTextBox.Text);
        }

        public int getSecondsForOneRevers()
        {
            return Convert.ToInt32(secondsForReversTextBox.Text);
        }

        public void ShowDuringGame()
        {
            easyButtonConfiguration.Enabled = false;
            mediumButtonConfiguration.Enabled = false;
            hardButtonConfiguration.Enabled = false;

            Show();
        }
    }
}
