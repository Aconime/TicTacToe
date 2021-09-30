using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    class GameManager
    {
        #region "Close Game"
        public static void CloseGame(Form parentForm)
        {
            var msg = MessageBox.Show("Are you sure you want to exit?", "TIC-TAC-TOE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                parentForm.Close();

                try { Application.OpenForms[0].Show(); }
                catch { }
            }
        }
        #endregion

        #region "Draggable Form"
        private int posX = 0, posY = 0;
        private bool drag = false;
        private Form parentFormCall;
        public void DraggableForm(Form parentForm, params Control[] additionalControls)
        {
            parentFormCall = parentForm;
            parentFormCall.MouseDown += new MouseEventHandler(MainControls_MouseDown);
            parentFormCall.MouseMove += new MouseEventHandler(MainControls_MouseMove);
            parentFormCall.MouseUp += new MouseEventHandler(MainControls_MouseUp);

            foreach (Control control in additionalControls)
            {
                control.MouseDown += new MouseEventHandler(MainControls_MouseDown);
                control.MouseMove += new MouseEventHandler(MainControls_MouseMove);
                control.MouseUp += new MouseEventHandler(MainControls_MouseUp);
            }

        }
        private void MainControls_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            posX = e.X;
            posY = e.Y;
        }
        private void MainControls_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag) parentFormCall.Location = new Point(parentFormCall.Location.X + e.X - posX, parentFormCall.Location.Y + e.Y - posY);
        }
        private void MainControls_MouseUp(object sender, MouseEventArgs e) => drag = false;
        #endregion

        #region "Highlight Additional Controls (Labels)"
        public static void HighlightControls(Label control, Action action)
        {
            control.Click += (sender, e) => action();
            control.MouseEnter += (sender, e) => control.ForeColor = Color.Gray;
            control.MouseLeave += (sender, e) => control.ForeColor = Color.FromArgb(45, 45, 45);
        }
        #endregion

        #region "Box Clicked In Game"
        public static void BoxClicked(Button boxReference, int playerID, string symbolForPlayer1, string symbolForPlayer2)
        {
            if (boxReference.GetType() == typeof(Button))
            {
                if (symbolForPlayer1.Length == 1 || symbolForPlayer2.Length == 1)
                {
                    if (boxReference.Text == "")
                    {
                        if (playerID == 0) boxReference.Text = symbolForPlayer1;
                        else if (playerID == 1) boxReference.Text = symbolForPlayer2;
                        else throw new Exception("Method requires a valid player ID :: (0, 1)");
                    }
                }
                else throw new Exception("Method requires 2 symbols, for player1 and player2, these need to be 1 character long :: (Length = 0)");
            }
            else throw new Exception("Method requires a reference of a button control.");
        }
        #endregion

    }
}
