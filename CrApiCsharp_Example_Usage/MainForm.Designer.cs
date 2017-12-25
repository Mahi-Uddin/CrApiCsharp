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
            this.btnSetToken = new System.Windows.Forms.Button();
            this.lblToken = new System.Windows.Forms.Label();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.tpPlayer = new System.Windows.Forms.TabPage();
            this.btnGetPlayerInfo = new System.Windows.Forms.Button();
            this.lblPlayerTag = new System.Windows.Forms.Label();
            this.tbPlayerTag = new System.Windows.Forms.TextBox();
            this.lblPlayerInfoResponse = new System.Windows.Forms.Label();
            this.rtbPlayerInfo = new System.Windows.Forms.RichTextBox();
            this.tpClan = new System.Windows.Forms.TabPage();
            this.tpTop = new System.Windows.Forms.TabPage();
            this.tcTop = new System.Windows.Forms.TabControl();
            this.tpTopPlayers = new System.Windows.Forms.TabPage();
            this.tpTopClans = new System.Windows.Forms.TabPage();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnGetClanInfo = new System.Windows.Forms.Button();
            this.lblClanTag = new System.Windows.Forms.Label();
            this.tbClanTag = new System.Windows.Forms.TextBox();
            this.lblClanInfoResponse = new System.Windows.Forms.Label();
            this.rtbClanInfoResponse = new System.Windows.Forms.RichTextBox();
            this.btnGetTopPlayersInfo = new System.Windows.Forms.Button();
            this.lblTopPlayersResponse = new System.Windows.Forms.Label();
            this.rtbTopPlayersResponse = new System.Windows.Forms.RichTextBox();
            this.btnGetTopClansInfo = new System.Windows.Forms.Button();
            this.lblTopClansResponse = new System.Windows.Forms.Label();
            this.rtbTopClansInfoResponse = new System.Windows.Forms.RichTextBox();
            this.tcMain.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpPlayer.SuspendLayout();
            this.tpClan.SuspendLayout();
            this.tpTop.SuspendLayout();
            this.tcTop.SuspendLayout();
            this.tpTopPlayers.SuspendLayout();
            this.tpTopClans.SuspendLayout();
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
            // tpPlayer
            // 
            this.tpPlayer.Controls.Add(this.btnGetPlayerInfo);
            this.tpPlayer.Controls.Add(this.lblPlayerTag);
            this.tpPlayer.Controls.Add(this.tbPlayerTag);
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
            // lblPlayerTag
            // 
            this.lblPlayerTag.AutoSize = true;
            this.lblPlayerTag.Location = new System.Drawing.Point(25, 25);
            this.lblPlayerTag.Name = "lblPlayerTag";
            this.lblPlayerTag.Size = new System.Drawing.Size(29, 13);
            this.lblPlayerTag.TabIndex = 9;
            this.lblPlayerTag.Text = "Tag:";
            // 
            // tbPlayerTag
            // 
            this.tbPlayerTag.Location = new System.Drawing.Point(97, 22);
            this.tbPlayerTag.Name = "tbPlayerTag";
            this.tbPlayerTag.Size = new System.Drawing.Size(327, 20);
            this.tbPlayerTag.TabIndex = 8;
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
            // rtbPlayerInfo
            // 
            this.rtbPlayerInfo.Location = new System.Drawing.Point(97, 79);
            this.rtbPlayerInfo.Name = "rtbPlayerInfo";
            this.rtbPlayerInfo.Size = new System.Drawing.Size(441, 287);
            this.rtbPlayerInfo.TabIndex = 5;
            this.rtbPlayerInfo.Text = "";
            // 
            // tpClan
            // 
            this.tpClan.Controls.Add(this.btnGetClanInfo);
            this.tpClan.Controls.Add(this.lblClanTag);
            this.tpClan.Controls.Add(this.tbClanTag);
            this.tpClan.Controls.Add(this.lblClanInfoResponse);
            this.tpClan.Controls.Add(this.rtbClanInfoResponse);
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
            this.tpTopPlayers.Controls.Add(this.btnGetTopPlayersInfo);
            this.tpTopPlayers.Controls.Add(this.lblTopPlayersResponse);
            this.tpTopPlayers.Controls.Add(this.rtbTopPlayersResponse);
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
            this.tpTopClans.Controls.Add(this.btnGetTopClansInfo);
            this.tpTopClans.Controls.Add(this.lblTopClansResponse);
            this.tpTopClans.Controls.Add(this.rtbTopClansInfoResponse);
            this.tpTopClans.Location = new System.Drawing.Point(4, 22);
            this.tpTopClans.Name = "tpTopClans";
            this.tpTopClans.Padding = new System.Windows.Forms.Padding(3);
            this.tpTopClans.Size = new System.Drawing.Size(551, 355);
            this.tpTopClans.TabIndex = 1;
            this.tpTopClans.Text = "Top Clans";
            this.tpTopClans.UseVisualStyleBackColor = true;
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
            // btnGetClanInfo
            // 
            this.btnGetClanInfo.Location = new System.Drawing.Point(448, 21);
            this.btnGetClanInfo.Name = "btnGetClanInfo";
            this.btnGetClanInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetClanInfo.TabIndex = 15;
            this.btnGetClanInfo.Text = "Get Info";
            this.btnGetClanInfo.UseVisualStyleBackColor = true;
            this.btnGetClanInfo.Click += new System.EventHandler(this.btnGetClanInfo_Click);
            // 
            // lblClanTag
            // 
            this.lblClanTag.AutoSize = true;
            this.lblClanTag.Location = new System.Drawing.Point(25, 26);
            this.lblClanTag.Name = "lblClanTag";
            this.lblClanTag.Size = new System.Drawing.Size(29, 13);
            this.lblClanTag.TabIndex = 14;
            this.lblClanTag.Text = "Tag:";
            // 
            // tbClanTag
            // 
            this.tbClanTag.Location = new System.Drawing.Point(97, 23);
            this.tbClanTag.Name = "tbClanTag";
            this.tbClanTag.Size = new System.Drawing.Size(327, 20);
            this.tbClanTag.TabIndex = 13;
            // 
            // lblClanInfoResponse
            // 
            this.lblClanInfoResponse.AutoSize = true;
            this.lblClanInfoResponse.Location = new System.Drawing.Point(25, 83);
            this.lblClanInfoResponse.Name = "lblClanInfoResponse";
            this.lblClanInfoResponse.Size = new System.Drawing.Size(58, 13);
            this.lblClanInfoResponse.TabIndex = 12;
            this.lblClanInfoResponse.Text = "Response:";
            // 
            // rtbClanInfoResponse
            // 
            this.rtbClanInfoResponse.Location = new System.Drawing.Point(97, 80);
            this.rtbClanInfoResponse.Name = "rtbClanInfoResponse";
            this.rtbClanInfoResponse.Size = new System.Drawing.Size(441, 287);
            this.rtbClanInfoResponse.TabIndex = 11;
            this.rtbClanInfoResponse.Text = "";
            // 
            // btnGetTopPlayersInfo
            // 
            this.btnGetTopPlayersInfo.Location = new System.Drawing.Point(238, 15);
            this.btnGetTopPlayersInfo.Name = "btnGetTopPlayersInfo";
            this.btnGetTopPlayersInfo.Size = new System.Drawing.Size(140, 23);
            this.btnGetTopPlayersInfo.TabIndex = 18;
            this.btnGetTopPlayersInfo.Text = "Get Top Players Info";
            this.btnGetTopPlayersInfo.UseVisualStyleBackColor = true;
            this.btnGetTopPlayersInfo.Click += new System.EventHandler(this.btnGetTopPlayersInfo_Click);
            // 
            // lblTopPlayersResponse
            // 
            this.lblTopPlayersResponse.AutoSize = true;
            this.lblTopPlayersResponse.Location = new System.Drawing.Point(19, 66);
            this.lblTopPlayersResponse.Name = "lblTopPlayersResponse";
            this.lblTopPlayersResponse.Size = new System.Drawing.Size(58, 13);
            this.lblTopPlayersResponse.TabIndex = 17;
            this.lblTopPlayersResponse.Text = "Response:";
            // 
            // rtbTopPlayersResponse
            // 
            this.rtbTopPlayersResponse.Location = new System.Drawing.Point(91, 63);
            this.rtbTopPlayersResponse.Name = "rtbTopPlayersResponse";
            this.rtbTopPlayersResponse.Size = new System.Drawing.Size(441, 287);
            this.rtbTopPlayersResponse.TabIndex = 16;
            this.rtbTopPlayersResponse.Text = "";
            // 
            // btnGetTopClansInfo
            // 
            this.btnGetTopClansInfo.Location = new System.Drawing.Point(238, 10);
            this.btnGetTopClansInfo.Name = "btnGetTopClansInfo";
            this.btnGetTopClansInfo.Size = new System.Drawing.Size(140, 23);
            this.btnGetTopClansInfo.TabIndex = 21;
            this.btnGetTopClansInfo.Text = "Get Top Clans Info";
            this.btnGetTopClansInfo.UseVisualStyleBackColor = true;
            this.btnGetTopClansInfo.Click += new System.EventHandler(this.btnGetTopClansInfo_Click);
            // 
            // lblTopClansResponse
            // 
            this.lblTopClansResponse.AutoSize = true;
            this.lblTopClansResponse.Location = new System.Drawing.Point(19, 61);
            this.lblTopClansResponse.Name = "lblTopClansResponse";
            this.lblTopClansResponse.Size = new System.Drawing.Size(58, 13);
            this.lblTopClansResponse.TabIndex = 20;
            this.lblTopClansResponse.Text = "Response:";
            // 
            // rtbTopClansInfoResponse
            // 
            this.rtbTopClansInfoResponse.Location = new System.Drawing.Point(91, 58);
            this.rtbTopClansInfoResponse.Name = "rtbTopClansInfoResponse";
            this.rtbTopClansInfoResponse.Size = new System.Drawing.Size(441, 287);
            this.rtbTopClansInfoResponse.TabIndex = 19;
            this.rtbTopClansInfoResponse.Text = "";
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
            this.tpClan.ResumeLayout(false);
            this.tpClan.PerformLayout();
            this.tpTop.ResumeLayout(false);
            this.tcTop.ResumeLayout(false);
            this.tpTopPlayers.ResumeLayout(false);
            this.tpTopPlayers.PerformLayout();
            this.tpTopClans.ResumeLayout(false);
            this.tpTopClans.PerformLayout();
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
        private System.Windows.Forms.Label lblPlayerTag;
        private System.Windows.Forms.TextBox tbPlayerTag;
        private System.Windows.Forms.Button btnGetClanInfo;
        private System.Windows.Forms.Label lblClanTag;
        private System.Windows.Forms.TextBox tbClanTag;
        private System.Windows.Forms.Label lblClanInfoResponse;
        private System.Windows.Forms.RichTextBox rtbClanInfoResponse;
        private System.Windows.Forms.Button btnGetTopPlayersInfo;
        private System.Windows.Forms.Label lblTopPlayersResponse;
        private System.Windows.Forms.RichTextBox rtbTopPlayersResponse;
        private System.Windows.Forms.Button btnGetTopClansInfo;
        private System.Windows.Forms.Label lblTopClansResponse;
        private System.Windows.Forms.RichTextBox rtbTopClansInfoResponse;
    }
}

