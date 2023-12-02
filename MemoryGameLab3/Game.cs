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
    public partial class Game : Form
    {
        private Configuration configuration;
        private PictureBox[] cards;
        private Label actualMovesLabel;
        private Label actualResultLabel;
        private Label timeLabel;
        private Label actualTimeLabel;
        private Button pauseButton;
        private Button configureButton;
        private Image hidden;
        private int[] indexesOfImages;
        private int cardsNumber;
        private int invertedIndex;
        private int moves;
        private int cardsReversed;
        private int widthForDetailLabels;
        private int gameLengthInSeconds;
        private bool isPaused;
        private string name;


        public Game(string name, Configuration configuration)
        {
            InitializeComponent();

            this.configuration = configuration;

            cardsNumber = configuration.getCardsNumber();

            this.name = name;

            isPaused = false;
            gameLengthInSeconds = 0;
            widthForDetailLabels = 200;
            cardsReversed = 0;
            moves = 0;
            invertedIndex = Constants.ANY_INVERTED;
            indexesOfImages = new int[cardsNumber];

            initializeIndexesOfImages();
            
            cards = new PictureBox[cardsNumber];
            hidden = Image.FromFile("./images/hidden.png");

            prepareForGame();
            addDetailLabels();
        }

        private void initializeIndexesOfImages()
        {
            int j = 0;
            for (int i = 0; i < cardsNumber; i+=2)
            {
                indexesOfImages[i] = j;
                indexesOfImages[i + 1] = j;
                ++j;
            }
        }

        private void startGame()
        {
            this.timeCounterTimer.Enabled = true;

            pauseButton.Enabled = false;

            reversAllCards();

            System.Threading.Thread.Sleep(configuration.getSecondsForOneRevers() * 1000);

            hideAllCards();

            pauseButton.Enabled = true;
        }

        private void reversAllCards()
        {
            for (int i = 0; i < cardsNumber; i++)
            {
                this.cards[i].Load("./images/image (" + indexesOfImages[i].ToString() + ").png");
            }

            Application.DoEvents();
        }

        private void hideAllCards()
        {
            for (int i = 0; i < cardsNumber; i++)
            {
                this.cards[i].Load("./images/hidden.png");
            }

            Application.DoEvents();
        }

        private void prepareForGame()
        {
            string pathToImage;

            int cardsInRow = (int)Math.Sqrt(cardsNumber) + 1;
            int cardWidth, cardHeight;

            if (cardsNumber > 80) { cardWidth = 45; cardHeight = 75; }
            else { cardWidth = 60; cardHeight = 100; }

            int widthForOneCard = cardWidth + 4, heightForOneCard = cardHeight + 4;
            int startX = 10, startY = 10;

            this.Size = new System.Drawing.Size(Math.Max((cardsInRow + 1) * widthForOneCard + widthForDetailLabels + 2 * startX, 700), 
                                                Math.Max((cardsInRow + 1) * heightForOneCard + 2 * startY, 700) );

            shuffleIndexesOfImages(cardsNumber);

            for (int i=0; i<cardsNumber; i++)
            {
                pathToImage = "./images/image (" + indexesOfImages[i].ToString() + ").png";

                this.cards[i] = new PictureBox();

                this.Controls.Add(this.cards[i]);

                this.cards[i].Name = "card" + i.ToString();
                this.cards[i].Image = hidden;
                this.cards[i].Size = new System.Drawing.Size(cardWidth, cardHeight);
                this.cards[i].TabIndex = i;
                this.cards[i].Location = new System.Drawing.Point( widthForOneCard * (i % cardsInRow) + startX, 
                                                                    (int)(i / cardsInRow ) * heightForOneCard + startY );
                this.cards[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.cards[i].WaitOnLoad = true;

                this.cards[i].Click += new System.EventHandler(this.cardPictureBox_Click);
            }    

        }

        private void addDetailLabels()
        {
            this.actualMovesLabel = new Label();

            this.Controls.Add(this.actualMovesLabel);

            this.actualMovesLabel.Size = new System.Drawing.Size(widthForDetailLabels, 20);
            this.actualMovesLabel.Location = new System.Drawing.Point(this.Width - widthForDetailLabels, 10);
            this.actualMovesLabel.Text = "Wykonane ruchy:";


            this.actualResultLabel = new Label();

            this.Controls.Add(this.actualResultLabel);

            this.actualResultLabel.Size = new System.Drawing.Size(widthForDetailLabels, 20);
            this.actualResultLabel.Location = new System.Drawing.Point(this.Width - widthForDetailLabels, 40);
            this.actualResultLabel.Text = moves.ToString();


            this.actualTimeLabel = new Label();

            this.Controls.Add(this.actualTimeLabel);

            this.actualTimeLabel.Size = new System.Drawing.Size(widthForDetailLabels, 20);
            this.actualTimeLabel.Location = new System.Drawing.Point(this.Width - widthForDetailLabels, 70);
            this.actualTimeLabel.Text = "Upłynęło czasu:";


            this.timeLabel = new Label();

            this.Controls.Add(this.timeLabel);

            this.timeLabel.Size = new System.Drawing.Size(widthForDetailLabels, 20);
            this.timeLabel.Location = new System.Drawing.Point(this.Width - widthForDetailLabels, 90);
            this.timeLabel.Text = "00:00";


            this.pauseButton = new Button();

            this.Controls.Add(this.pauseButton);

            this.pauseButton.Location = new System.Drawing.Point(this.Width - widthForDetailLabels, 110);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(widthForDetailLabels, 20);
            this.pauseButton.Text = "Pauza";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Tag = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);


            this.configureButton = new Button();

            this.Controls.Add(this.configureButton);

            this.configureButton.Location = new System.Drawing.Point(this.Width - widthForDetailLabels, 130);
            this.configureButton.Name = "configureButton";
            this.configureButton.Size = new System.Drawing.Size(widthForDetailLabels, 25);
            this.configureButton.Text = "Konfiguruj";
            this.configureButton.UseVisualStyleBackColor = true;
            this.configureButton.Click += new System.EventHandler(this.configureButton_Click);
        }

        private void configureButton_Click(object sender, EventArgs e)
        {
            configuration.ShowDuringGame();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if(!isPaused)
            {
                timeCounterTimer.Stop();
                this.pauseButton.Text = "Wznów";
                isPaused = true;
            }
            else
            {
                timeCounterTimer.Start();
                this.pauseButton.Text = "Pauza";
                isPaused = false;
            }
            
        }

        private void cardPictureBox_Click(object sender, EventArgs e)
        {
            if (sender is null || isPaused) { return; }

            int index = (sender as PictureBox).TabIndex;

            if (index == invertedIndex) { return; }

            this.cards[index].Load("./images/image (" + indexesOfImages[index].ToString() + ").png");
            Application.DoEvents();

            if (invertedIndex == Constants.ANY_INVERTED)
            {
                invertedIndex = index;
            }
            else
            {
                ++moves;
                this.actualResultLabel.Text = moves.ToString();
                pauseButton.Enabled = false;

                System.Threading.Thread.Sleep(configuration.getMilisecondsForRevers());

                if (indexesOfImages[index] == indexesOfImages[invertedIndex])
                {
                    cardsReversed += 2;
                    cards[index].Visible = false;
                    cards[invertedIndex].Visible = false;

                    if (isWin()) { winScenario(); }
                }
                else
                {
                    cards[index].Image = hidden;
                    cards[invertedIndex].Image = hidden;
                }
                pauseButton.Enabled = true;
                invertedIndex = Constants.ANY_INVERTED;
            }
        }

        private void shuffleIndexesOfImages(int levelOfRandomization)
        {
            Random rand = new Random();
            int buf, j, k;

            for(int i=0; i<levelOfRandomization; i++)
            {
                j = rand.Next() % cardsNumber;
                k = rand.Next() % cardsNumber;
                buf = indexesOfImages[j];
                indexesOfImages[j] = indexesOfImages[k];
                indexesOfImages[k] = buf;
            }
        }

        private bool isWin()
        {
            return cardsReversed == cardsNumber;
        }

        private void winScenario()
        {
            timeCounterTimer.Enabled = false;
            allResults endForm = new allResults(name, moves + gameLengthInSeconds);
            endForm.Show();
        }

        private void timeCounterTimer_Tick(object sender, EventArgs e)
        {
            ++gameLengthInSeconds;
            timeLabel.Text = gameLengthToString();
        }

        private string gameLengthToString()
        {
            int sec = gameLengthInSeconds % 60;
            int min = gameLengthInSeconds / 60;

            string secStr, minStr;

            if (sec < 10) { secStr = "0" + sec.ToString(); }
            else { secStr = sec.ToString(); }

            if (min < 10) { minStr = "0" + min.ToString(); }
            else { minStr = min.ToString(); }

            return minStr + ":" + secStr;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Game_Shown(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
