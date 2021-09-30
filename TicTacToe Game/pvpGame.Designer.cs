
namespace TicTacToe_Game
{
    partial class pvpGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pvpGame));
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.headerLine = new System.Windows.Forms.PictureBox();
            this.playerOneNameLbl = new System.Windows.Forms.Label();
            this.playerTwoNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerOneScoreLbl = new System.Windows.Forms.Label();
            this.playerTwoScoreLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playerTwoPlayingLbl = new System.Windows.Forms.Label();
            this.playerOnePlayingLbl = new System.Windows.Forms.Label();
            this.playerOneMessageLbl = new System.Windows.Forms.Label();
            this.playerTwoMessageLbl = new System.Windows.Forms.Label();
            this.gameAreaGb = new System.Windows.Forms.GroupBox();
            this.box9 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box1 = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerLine)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gameAreaGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.titleLabel.Location = new System.Drawing.Point(9, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(126, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TIC-TAC-TOE";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.AutoSize = true;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.closeBtn.Location = new System.Drawing.Point(336, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(19, 21);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            // 
            // headerLine
            // 
            this.headerLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLine.BackColor = System.Drawing.Color.Gray;
            this.headerLine.Location = new System.Drawing.Point(6, 34);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(351, 1);
            this.headerLine.TabIndex = 2;
            this.headerLine.TabStop = false;
            // 
            // playerOneNameLbl
            // 
            this.playerOneNameLbl.AutoEllipsis = true;
            this.playerOneNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerOneNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playerOneNameLbl.Location = new System.Drawing.Point(15, 24);
            this.playerOneNameLbl.Name = "playerOneNameLbl";
            this.playerOneNameLbl.Size = new System.Drawing.Size(255, 19);
            this.playerOneNameLbl.TabIndex = 12;
            this.playerOneNameLbl.Text = "<Player>";
            // 
            // playerTwoNameLbl
            // 
            this.playerTwoNameLbl.AutoEllipsis = true;
            this.playerTwoNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerTwoNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playerTwoNameLbl.Location = new System.Drawing.Point(15, 46);
            this.playerTwoNameLbl.Name = "playerTwoNameLbl";
            this.playerTwoNameLbl.Size = new System.Drawing.Size(255, 19);
            this.playerTwoNameLbl.TabIndex = 13;
            this.playerTwoNameLbl.Text = "<Player>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerOneScoreLbl);
            this.groupBox1.Controls.Add(this.playerTwoScoreLbl);
            this.groupBox1.Controls.Add(this.playerOneNameLbl);
            this.groupBox1.Controls.Add(this.playerTwoNameLbl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 76);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SCORE";
            // 
            // playerOneScoreLbl
            // 
            this.playerOneScoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerOneScoreLbl.AutoEllipsis = true;
            this.playerOneScoreLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerOneScoreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.playerOneScoreLbl.Location = new System.Drawing.Point(276, 25);
            this.playerOneScoreLbl.Name = "playerOneScoreLbl";
            this.playerOneScoreLbl.Size = new System.Drawing.Size(69, 19);
            this.playerOneScoreLbl.TabIndex = 14;
            this.playerOneScoreLbl.Text = "0";
            this.playerOneScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playerTwoScoreLbl
            // 
            this.playerTwoScoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerTwoScoreLbl.AutoEllipsis = true;
            this.playerTwoScoreLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerTwoScoreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.playerTwoScoreLbl.Location = new System.Drawing.Point(276, 47);
            this.playerTwoScoreLbl.Name = "playerTwoScoreLbl";
            this.playerTwoScoreLbl.Size = new System.Drawing.Size(69, 19);
            this.playerTwoScoreLbl.TabIndex = 15;
            this.playerTwoScoreLbl.Text = "0";
            this.playerTwoScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.playerTwoPlayingLbl);
            this.groupBox2.Controls.Add(this.playerOnePlayingLbl);
            this.groupBox2.Controls.Add(this.playerOneMessageLbl);
            this.groupBox2.Controls.Add(this.playerTwoMessageLbl);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(6, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 76);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLAYING";
            // 
            // playerTwoPlayingLbl
            // 
            this.playerTwoPlayingLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerTwoPlayingLbl.AutoSize = true;
            this.playerTwoPlayingLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerTwoPlayingLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.playerTwoPlayingLbl.Location = new System.Drawing.Point(272, 46);
            this.playerTwoPlayingLbl.Name = "playerTwoPlayingLbl";
            this.playerTwoPlayingLbl.Size = new System.Drawing.Size(64, 19);
            this.playerTwoPlayingLbl.TabIndex = 15;
            this.playerTwoPlayingLbl.Text = "PLAYING";
            this.playerTwoPlayingLbl.Visible = false;
            // 
            // playerOnePlayingLbl
            // 
            this.playerOnePlayingLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerOnePlayingLbl.AutoSize = true;
            this.playerOnePlayingLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerOnePlayingLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.playerOnePlayingLbl.Location = new System.Drawing.Point(272, 24);
            this.playerOnePlayingLbl.Name = "playerOnePlayingLbl";
            this.playerOnePlayingLbl.Size = new System.Drawing.Size(64, 19);
            this.playerOnePlayingLbl.TabIndex = 14;
            this.playerOnePlayingLbl.Text = "PLAYING";
            // 
            // playerOneMessageLbl
            // 
            this.playerOneMessageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerOneMessageLbl.AutoEllipsis = true;
            this.playerOneMessageLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerOneMessageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playerOneMessageLbl.Location = new System.Drawing.Point(15, 24);
            this.playerOneMessageLbl.Name = "playerOneMessageLbl";
            this.playerOneMessageLbl.Size = new System.Drawing.Size(250, 19);
            this.playerOneMessageLbl.TabIndex = 12;
            this.playerOneMessageLbl.Text = "<Player> is playing as <Symbol>";
            // 
            // playerTwoMessageLbl
            // 
            this.playerTwoMessageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerTwoMessageLbl.AutoEllipsis = true;
            this.playerTwoMessageLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.playerTwoMessageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playerTwoMessageLbl.Location = new System.Drawing.Point(15, 46);
            this.playerTwoMessageLbl.Name = "playerTwoMessageLbl";
            this.playerTwoMessageLbl.Size = new System.Drawing.Size(250, 19);
            this.playerTwoMessageLbl.TabIndex = 13;
            this.playerTwoMessageLbl.Text = "<Player> is playing as <Symbol>";
            // 
            // gameAreaGb
            // 
            this.gameAreaGb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameAreaGb.Controls.Add(this.box9);
            this.gameAreaGb.Controls.Add(this.box8);
            this.gameAreaGb.Controls.Add(this.box7);
            this.gameAreaGb.Controls.Add(this.box6);
            this.gameAreaGb.Controls.Add(this.box5);
            this.gameAreaGb.Controls.Add(this.box4);
            this.gameAreaGb.Controls.Add(this.box3);
            this.gameAreaGb.Controls.Add(this.box2);
            this.gameAreaGb.Controls.Add(this.box1);
            this.gameAreaGb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gameAreaGb.Location = new System.Drawing.Point(6, 205);
            this.gameAreaGb.Name = "gameAreaGb";
            this.gameAreaGb.Size = new System.Drawing.Size(351, 351);
            this.gameAreaGb.TabIndex = 17;
            this.gameAreaGb.TabStop = false;
            this.gameAreaGb.Text = "GAME - 0";
            // 
            // box9
            // 
            this.box9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box9.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box9.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box9.Location = new System.Drawing.Point(226, 234);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(90, 90);
            this.box9.TabIndex = 20;
            this.box9.UseVisualStyleBackColor = false;
            // 
            // box8
            // 
            this.box8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box8.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box8.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box8.Location = new System.Drawing.Point(130, 234);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(90, 90);
            this.box8.TabIndex = 19;
            this.box8.UseVisualStyleBackColor = false;
            // 
            // box7
            // 
            this.box7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box7.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box7.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box7.Location = new System.Drawing.Point(34, 234);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(90, 90);
            this.box7.TabIndex = 18;
            this.box7.UseVisualStyleBackColor = false;
            // 
            // box6
            // 
            this.box6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box6.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box6.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box6.Location = new System.Drawing.Point(226, 138);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(90, 90);
            this.box6.TabIndex = 17;
            this.box6.UseVisualStyleBackColor = false;
            // 
            // box5
            // 
            this.box5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box5.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box5.Location = new System.Drawing.Point(130, 138);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(90, 90);
            this.box5.TabIndex = 16;
            this.box5.UseVisualStyleBackColor = false;
            // 
            // box4
            // 
            this.box4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box4.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box4.Location = new System.Drawing.Point(34, 138);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(90, 90);
            this.box4.TabIndex = 15;
            this.box4.UseVisualStyleBackColor = false;
            // 
            // box3
            // 
            this.box3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box3.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box3.Location = new System.Drawing.Point(226, 42);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(90, 90);
            this.box3.TabIndex = 14;
            this.box3.UseVisualStyleBackColor = false;
            // 
            // box2
            // 
            this.box2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box2.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box2.Location = new System.Drawing.Point(130, 42);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(90, 90);
            this.box2.TabIndex = 13;
            this.box2.UseVisualStyleBackColor = false;
            // 
            // box1
            // 
            this.box1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.box1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.box1.Location = new System.Drawing.Point(34, 42);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(90, 90);
            this.box1.TabIndex = 12;
            this.box1.UseVisualStyleBackColor = false;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.AutoSize = true;
            this.helpBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.helpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.helpBtn.Location = new System.Drawing.Point(315, 7);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(17, 21);
            this.helpBtn.TabIndex = 18;
            this.helpBtn.Text = "?";
            this.helpBtn.Visible = false;
            // 
            // pvpGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 562);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.gameAreaGb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.headerLine);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(363, 562);
            this.MinimumSize = new System.Drawing.Size(363, 562);
            this.Name = "pvpGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.headerLine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gameAreaGb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.PictureBox headerLine;
        private System.Windows.Forms.Label playerTwoNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label playerTwoScoreLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label playerOneMessageLbl;
        private System.Windows.Forms.Label playerTwoMessageLbl;
        private System.Windows.Forms.GroupBox gameAreaGb;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Label playerTwoPlayingLbl;
        private System.Windows.Forms.Label playerOnePlayingLbl;
        private System.Windows.Forms.Label playerOneScoreLbl;
        private System.Windows.Forms.Label playerOneNameLbl;
        private System.Windows.Forms.Label helpBtn;
    }
}

