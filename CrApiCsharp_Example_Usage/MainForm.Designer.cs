namespace CrApiCsharp_Example_Usage
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpPlayer = new System.Windows.Forms.TabPage();
            this.tpClan = new System.Windows.Forms.TabPage();
            this.tpTop = new System.Windows.Forms.TabPage();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.tcTop = new System.Windows.Forms.TabControl();
            this.tpTopPlayers = new System.Windows.Forms.TabPage();
            this.tpTopClans = new System.Windows.Forms.TabPage();
            this.rtbPlayerInfo = new System.Windows.Forms.RichTextBox();
            this.lblPlayerInfoResponse = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.btnSetToken = new System.Windows.Forms.Button();
            this.btnGetPlayerInfo = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tcMain.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpPlayer.SuspendLayout();
            this.tpTop.SuspendLayout();
            this.tcTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpHome);
            this.tcMain.Controls.Add(this.tpPlayer);
            this.tcMain.Controls.Add(this.tpClan);
            this.tcMain.Controls.Add(this.tpTop);
            this.tcMain.Controls.Add(this.tpAbout);
            this.tcMain.Location = new System.Drawing.Point(1, 1);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(570, 414);
            this.tcMain.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.btnSetToken);
            this.tpHome.Controls.Add(this.lblToken);
            this.tpHome.Controls.Add(this.tbToken);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(562, 388);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tpPlayer
            // 
            this.tpPlayer.Controls.Add(this.btnGetPlayerInfo);
            this.tpPlayer.Controls.Add(this.lblTag);
            this.tpPlayer.Controls.Add(this.tbTag);
            this.tpPlayer.Controls.Add(this.lblPlayerInfoResponse);
            this.tpPlayer.Controls.Add(this.rtbPlayerInfo);
            this.tpPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer.Name = "tpPlayer";
            this.tpPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayer.Size = new System.Drawing.Size(562, 388);
            this.tpPlayer.TabIndex = 1;
            this.tpPlayer.Text = "Player";
            this.tpPlayer.UseVisualStyleBackColor = true;
            // 
            // tpClan
            // 
            this.tpClan.Location = new System.Drawing.Point(4, 22);
            this.tpClan.Name = "tpClan";
            this.tpClan.Padding = new System.Windows.Forms.Padding(3);
            this.tpClan.Size = new System.Drawing.Size(562, 388);
            this.tpClan.TabIndex = 2;
            this.tpClan.Text = "Clan";
            this.tpClan.UseVisualStyleBackColor = true;
            // 
            // tpTop
            // 
            this.tpTop.Controls.Add(this.tcTop);
            this.tpTop.Location = new System.Drawing.Point(4, 22);
            this.tpTop.Name = "tpTop";
            this.tpTop.Padding = new System.Windows.Forms.Padding(3);
            this.tpTop.Size = new System.Drawing.Size(562, 388);
            this.tpTop.TabIndex = 3;
            this.tpTop.Text = "Top";
            this.tpTop.UseVisualStyleBackColor = true;
            // 
            // tpAbout
            // 
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(562, 388);
            this.tpAbout.TabIndex = 4;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // tcTop
            // 
            this.tcTop.Controls.Add(this.tpTopPlayers);
            this.tcTop.Controls.Add(this.tpTopClans);
            this.tcTop.Location = new System.Drawing.Point(3, 1);
            this.tcTop.Name = "tcTop";
            this.tcTop.SelectedIndex = 0;
            this.tcTop.Size = new System.Drawing.Size(559, 381);
            this.tcTop.TabIndex = 0;
            // 
            // tpTopPlayers
            // 
            this.tpTopPlayers.Location = new System.Drawing.Point(4, 22);
            this.tpTopPlayers.Name = "tpTopPlayers";
            this.tpTopPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tpTopPlayers.Size = new System.Drawing.Size(551, 355);
            this.tpTopPlayers.TabIndex = 0;
            this.tpTopPlayers.Text = "Top Players";
            this.tpTopPlayers.UseVisualStyleBackColor = true;
            // 
            // tpTopClans
            // 
            this.tpTopClans.Location = new System.Drawing.Point(4, 22);
            this.tpTopClans.Name = "tpTopClans";
            this.tpTopClans.Padding = new System.Windows.Forms.Padding(3);
            this.tpTopClans.Size = new System.Drawing.Size(551, 355);
            this.tpTopClans.TabIndex = 1;
            this.tpTopClans.Text = "Top Clans";
            this.tpTopClans.UseVisualStyleBackColor = true;
            // 
            // rtbPlayerInfo
            // 
            this.rtbPlayerInfo.Location = new System.Drawing.Point(97, 79);
            this.rtbPlayerInfo.Name = "rtbPlayerInfo";
            this.rtbPlayerInfo.Size = new System.Drawing.Size(441, 287);
            this.rtbPlayerInfo.TabIndex = 5;
            this.rtbPlayerInfo.Text = "";
            // 
            // lblPlayerInfoResponse
            // 
            this.lblPlayerInfoResponse.AutoSize = true;
            this.lblPlayerInfoResponse.Location = new System.Drawing.Point(25, 82);
            this.lblPlayerInfoResponse.Name = "lblPlayerInfoResponse";
            this.lblPlayerInfoResponse.Size = new System.Drawing.Size(58, 13);
            this.lblPlayerInfoResponse.TabIndex = 6;
            this.lblPlayerInfoResponse.Text = "Response:";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(11, 19);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(41, 13);
            this.lblToken.TabIndex = 6;
            this.lblToken.Text = "Token:";
            // 
            // tbToken
            // 
            this.tbToken.Location = new System.Drawing.Point(58, 16);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(413, 20);
            this.tbToken.TabIndex = 5;
            // 
            // btnSetToken
            // 
            this.btnSetToken.Location = new System.Drawing.Point(480, 14);
            this.btnSetToken.Name = "btnSetToken";
            this.btnSetToken.Size = new System.Drawing.Size(75, 23);
            this.btnSetToken.TabIndex = 7;
            this.btnSetToken.Text = "Set Token";
            this.btnSetToken.UseVisualStyleBackColor = true;
            this.btnSetToken.Click += new System.EventHandler(this.btnSetToken_Click);
            // 
            // btnGetPlayerInfo
            // 
            this.btnGetPlayerInfo.Location = new System.Drawing.Point(448, 20);
            this.btnGetPlayerInfo.Name = "btnGetPlayerInfo";
            this.btnGetPlayerInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetPlayerInfo.TabIndex = 10;
            this.btnGetPlayerInfo.Text = "Get Info";
            this.btnGetPlayerInfo.UseVisualStyleBackColor = true;
            this.btnGetPlayerInfo.Click += new System.EventHandler(this.btnGetPlayerInfo_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(25, 25);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 9;
            this.lblTag.Text = "Tag:";
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(97, 22);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(327, 20);
            this.tbTag.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 417);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.Text = "CrApiCsharp Example Usage";
            this.tcMain.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpPlayer.ResumeLayout(false);
            this.tpPlayer.PerformLayout();
            this.tpTop.ResumeLayout(false);
            this.tcTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpPlayer;
        private System.Windows.Forms.TabPage tpClan;
        private System.Windows.Forms.TabPage tpTop;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.TabControl tcTop;
        private System.Windows.Forms.TabPage tpTopPlayers;
        private System.Windows.Forms.TabPage tpTopClans;
        private System.Windows.Forms.RichTextBox rtbPlayerInfo;
        private System.Windows.Forms.Label lblPlayerInfoResponse;
        private System.Windows.Forms.Button btnSetToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.Button btnGetPlayerInfo;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox tbTag;
    }
}

