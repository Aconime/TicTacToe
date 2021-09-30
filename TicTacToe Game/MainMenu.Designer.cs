
namespace TicTacToe_Game
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.headerLine = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pvpBtn = new System.Windows.Forms.Button();
            this.pvcBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.cvcBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerLine)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLine
            // 
            this.headerLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLine.BackColor = System.Drawing.Color.Gray;
            this.headerLine.Location = new System.Drawing.Point(6, 46);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(468, 1);
            this.headerLine.TabIndex = 21;
            this.headerLine.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.AutoSize = true;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.closeBtn.Location = new System.Drawing.Point(450, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(19, 21);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.Text = "X";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.titleLabel.Location = new System.Drawing.Point(9, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(126, 25);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "TIC-TAC-TOE";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 88);
            this.label1.TabIndex = 22;
            this.label1.Text = "MAIN MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pvpBtn
            // 
            this.pvpBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pvpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.pvpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.pvpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pvpBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pvpBtn.Location = new System.Drawing.Point(-1, 154);
            this.pvpBtn.Name = "pvpBtn";
            this.pvpBtn.Size = new System.Drawing.Size(482, 46);
            this.pvpBtn.TabIndex = 23;
            this.pvpBtn.Text = "    PLAYER VS PLAYER";
            this.pvpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pvpBtn.UseCompatibleTextRendering = true;
            this.pvpBtn.UseVisualStyleBackColor = true;
            // 
            // pvcBtn
            // 
            this.pvcBtn.Enabled = false;
            this.pvcBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pvcBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.pvcBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.pvcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pvcBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pvcBtn.Location = new System.Drawing.Point(-1, 203);
            this.pvcBtn.Name = "pvcBtn";
            this.pvcBtn.Size = new System.Drawing.Size(482, 46);
            this.pvcBtn.TabIndex = 24;
            this.pvcBtn.Text = "    PLAYER VS COMPUTER";
            this.pvcBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pvcBtn.UseCompatibleTextRendering = true;
            this.pvcBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.settingsBtn.Location = new System.Drawing.Point(-1, 301);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(482, 46);
            this.settingsBtn.TabIndex = 26;
            this.settingsBtn.Text = "    SETTINGS && OPTIONS";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.UseCompatibleTextRendering = true;
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // cvcBtn
            // 
            this.cvcBtn.Enabled = false;
            this.cvcBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cvcBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.cvcBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cvcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cvcBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cvcBtn.Location = new System.Drawing.Point(-1, 252);
            this.cvcBtn.Name = "cvcBtn";
            this.cvcBtn.Size = new System.Drawing.Size(482, 46);
            this.cvcBtn.TabIndex = 25;
            this.cvcBtn.Text = "    COMPUTER VS COMPUTER";
            this.cvcBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cvcBtn.UseCompatibleTextRendering = true;
            this.cvcBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitBtn.Location = new System.Drawing.Point(-1, 350);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(482, 46);
            this.exitBtn.TabIndex = 27;
            this.exitBtn.Text = "    EXIT GAME";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.UseCompatibleTextRendering = true;
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.AutoSize = true;
            this.aboutBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aboutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.aboutBtn.Location = new System.Drawing.Point(429, 12);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(14, 21);
            this.aboutBtn.TabIndex = 28;
            this.aboutBtn.Text = "i";
            this.aboutBtn.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 562);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.cvcBtn);
            this.Controls.Add(this.pvcBtn);
            this.Controls.Add(this.pvpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerLine);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.headerLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox headerLine;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pvpBtn;
        private System.Windows.Forms.Button pvcBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button cvcBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label aboutBtn;
    }
}