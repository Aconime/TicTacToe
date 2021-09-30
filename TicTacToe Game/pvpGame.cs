using System;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class pvpGame : Form
    {

        private int gamesPlayed = 0;
        private int currentPlayer;
        private int playerOneScore = 0;
        private int playerTwoScore = 0;
        private string playerOneSymbol;
        private string playerTwoSymbol;
        private string playerOneName;
        private string playerTwoName;
        private bool formTopMost;
        private bool swapSymbolsEachRound;

        private void CurrentPlayerPlaying()
        {
            if (currentPlayer == 0)
            {
                playerOnePlayingLbl.Visible = true;
                playerTwoPlayingLbl.Visible = false;
            }
            else if (currentPlayer == 1)
            {
                playerTwoPlayingLbl.Visible = true;
                playerOnePlayingLbl.Visible = false;
            }
        }

        private void InitGame()
        {
            gamesPlayed += 1;
            playerOneName = Properties.Settings.Default.PlayerOne;
            playerTwoName = Properties.Settings.Default.PlayerTwo;
            formTopMost = Properties.Settings.Default.FormTopMost;
            swapSymbolsEachRound = Properties.Settings.Default.SwapSymbols;

            if (swapSymbolsEachRound)
            {
                if (gamesPlayed % 2 == 1)
                {
                    playerOneSymbol = Properties.Settings.Default.SymbolOne;
                    playerTwoSymbol = Properties.Settings.Default.SymbolTwo;
                    currentPlayer = 0;
                }
                else
                {
                    playerOneSymbol = Properties.Settings.Default.SymbolTwo;
                    playerTwoSymbol = Properties.Settings.Default.SymbolOne;
                    currentPlayer = 1;
                }
            } else
            {
                playerOneSymbol = Properties.Settings.Default.SymbolOne;
                playerTwoSymbol = Properties.Settings.Default.SymbolTwo;

                if (gamesPlayed % 2 == 1) currentPlayer = 0;
                else currentPlayer = 1;
            }

            CurrentPlayerPlaying();

            playerOneNameLbl.Text = playerOneName;
            playerTwoNameLbl.Text = playerTwoName;
            playerOneMessageLbl.Text = $"{playerOneName} is playing as \"{playerOneSymbol}\"";
            playerTwoMessageLbl.Text = $"{playerTwoName} is playing as \"{playerTwoSymbol}\"";
            playerOneScoreLbl.Text = playerOneScore.ToString();
            playerTwoScoreLbl.Text = playerTwoScore.ToString();
            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
            box6.Text = "";
            box7.Text = "";
            box8.Text = "";
            box9.Text = "";
            gameAreaGb.Text = "GAME - " + gamesPlayed.ToString();

            TopMost = formTopMost;
        }

        public pvpGame()
        {
            InitializeComponent();

            InitGame();

            new GameManager().DraggableForm(this, titleLabel);
            GameManager.HighlightControls(closeBtn, () => GameManager.CloseGame(this));
            GameManager.HighlightControls(helpBtn, () => { });

            // Event handlers for the boxes - Click events for displaying "O" or "X"
            box1.Click += new EventHandler(Box_Clicked);
            box2.Click += new EventHandler(Box_Clicked);
            box3.Click += new EventHandler(Box_Clicked);
            box4.Click += new EventHandler(Box_Clicked);
            box5.Click += new EventHandler(Box_Clicked);
            box6.Click += new EventHandler(Box_Clicked);
            box7.Click += new EventHandler(Box_Clicked);
            box8.Click += new EventHandler(Box_Clicked);
            box9.Click += new EventHandler(Box_Clicked);
        }

        private void Box_Clicked(object sender, EventArgs e)
        {
            Button box = (Button)sender;
            if (box.Text == "")
            {
                GameManager.BoxClicked(box, currentPlayer, playerOneSymbol, playerTwoSymbol);
                CheckGameStats();
            }
        }

        private void CheckGameStats()
        {
            if (box1.Text == playerOneSymbol && box2.Text == playerOneSymbol && box3.Text == playerOneSymbol) GameOver();
            else if (box4.Text == playerOneSymbol && box5.Text == playerOneSymbol && box6.Text == playerOneSymbol) GameOver();
            else if (box7.Text == playerOneSymbol && box8.Text == playerOneSymbol && box9.Text == playerOneSymbol) GameOver();
            else if (box1.Text == playerOneSymbol && box5.Text == playerOneSymbol && box9.Text == playerOneSymbol) GameOver();
            else if (box3.Text == playerOneSymbol && box5.Text == playerOneSymbol && box7.Text == playerOneSymbol) GameOver();
            else if (box1.Text == playerOneSymbol && box4.Text == playerOneSymbol && box7.Text == playerOneSymbol) GameOver();
            else if (box2.Text == playerOneSymbol && box5.Text == playerOneSymbol && box8.Text == playerOneSymbol) GameOver();
            else if (box3.Text == playerOneSymbol && box6.Text == playerOneSymbol && box9.Text == playerOneSymbol) GameOver();
            else if (box1.Text == playerTwoSymbol && box2.Text == playerTwoSymbol && box3.Text == playerTwoSymbol) GameOver();
            else if (box4.Text == playerTwoSymbol && box5.Text == playerTwoSymbol && box6.Text == playerTwoSymbol) GameOver();
            else if (box7.Text == playerTwoSymbol && box8.Text == playerTwoSymbol && box9.Text == playerTwoSymbol) GameOver();
            else if (box1.Text == playerTwoSymbol && box5.Text == playerTwoSymbol && box9.Text == playerTwoSymbol) GameOver();
            else if (box3.Text == playerTwoSymbol && box5.Text == playerTwoSymbol && box7.Text == playerTwoSymbol) GameOver();
            else if (box1.Text == playerTwoSymbol && box4.Text == playerTwoSymbol && box7.Text == playerTwoSymbol) GameOver();
            else if (box2.Text == playerTwoSymbol && box5.Text == playerTwoSymbol && box8.Text == playerTwoSymbol) GameOver();
            else if (box3.Text == playerTwoSymbol && box6.Text == playerTwoSymbol && box9.Text == playerTwoSymbol) GameOver();
            else if (box1.Text != "" && box2.Text != "" && box3.Text != "" && box4.Text != "" && box5.Text != "" && 
                box6.Text != "" && box7.Text != "" && box8.Text != "" && box9.Text != "") GameOver(false);
            else UpdateGame();
        }

        private void GameOver(bool playerWon = true)
        {
            if (playerWon)
            {
                if (currentPlayer == 0)
                {
                    MessageBox.Show(playerOneName + " has won this round.", "Game Over!");
                    playerOneScore += 1;
                }
                else if (currentPlayer == 1)
                {
                    MessageBox.Show(playerTwoName + " has won this round.", "Game Over!");
                    playerTwoScore += 1;
                }
            } else MessageBox.Show("Game ended in a draw, good job to both players!", "Game Over!");
            
            InitGame();
        }

        private void UpdateGame()
        {
            if (currentPlayer == 0) currentPlayer += 1;
            else if (currentPlayer == 1) currentPlayer -= 1;
            CurrentPlayerPlaying();
        }
    }
}
