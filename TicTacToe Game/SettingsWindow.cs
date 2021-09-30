using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();

            // Close Window Event
            cancelBtn.Click += (sender, e) => Close();

            // Load Window Event
            Load += (sender, e) =>
            {
                playerOneTxt.Text = Properties.Settings.Default.PlayerOne;
                playerTwoTxt.Text = Properties.Settings.Default.PlayerTwo;
                symbolOneTxt.Text = Properties.Settings.Default.SymbolOne;
                symbolTwoTxt.Text = Properties.Settings.Default.SymbolTwo;
                swapChk.Checked = Properties.Settings.Default.SwapSymbols;
                onTopChk.Checked = Properties.Settings.Default.FormTopMost;
            };

            // Save Changes Event
            saveBtn.Click += (sender, e) => SaveSettings();

            // Ok and Close Button Event
            okBtn.Click += (sender, e) => SaveSettings();
        }

        private void SaveSettings()
        {
            playerOneTxt.Text = Properties.Settings.Default.PlayerOne = playerOneTxt.Text;
            Properties.Settings.Default.PlayerTwo = playerTwoTxt.Text;
            Properties.Settings.Default.SymbolOne = symbolOneTxt.Text;
            Properties.Settings.Default.SymbolTwo = symbolTwoTxt.Text;
            Properties.Settings.Default.SwapSymbols = swapChk.Checked;
            Properties.Settings.Default.FormTopMost = onTopChk.Checked;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
