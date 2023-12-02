namespace MemoryGameLab3
{
    public partial class Start : Form
    {
        Configuration configuration;

        public Start()
        {
            InitializeComponent();
            configuration = new Configuration();
        }

        private void configurationStart_Click(object sender, EventArgs e)
        {
            configuration.ShowDialog();
        }

        private void startGameStart_Click(object sender, EventArgs e)
        {
            Game game = new Game(this.textBox1.Text, configuration);
            Hide();
            game.Show();
        }
    }
}