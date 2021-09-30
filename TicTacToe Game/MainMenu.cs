using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            new GameManager().DraggableForm(this, titleLabel);
            GameManager.HighlightControls(closeBtn, CloseGameCaller);
            GameManager.HighlightControls(aboutBtn, () => { });

            // Event handler for playing a PvP game
            pvpBtn.Click += (sender, e) =>
            {
                pvpGame gameWindow = new pvpGame();
                gameWindow.Show();
                Hide();
            };

            // Event handler for opening settings & options
            settingsBtn.Click += (sender, e) =>
            {
                SettingsWindow settingsWindow = new SettingsWindow();
                settingsWindow.ShowDialog();
            };

            // Event handler for the close button
            exitBtn.Click += (sender, e) => CloseGameCaller();
        }

        private void CloseGameCaller() => GameManager.CloseGame(this);
    }
}
