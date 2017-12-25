using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrApiCsharp;

namespace CrApiCsharp_Example_Usage
{
    public partial class MainForm : Form
    {
        string Token;
        API API;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSetToken_Click(object sender, EventArgs e)
        {
            Token = tbToken.Text;
            API = new API(Token);
        }

        private void btnGetPlayerInfo_Click(object sender, EventArgs e)
        {
            string json = API.Get(EndPoints.Player, tbPlayerTag.Text);
            Player player = API.Parse<Player>(json);
            foreach (var achievement in player.achievements)
            {
                rtbPlayerInfo.AppendText(achievement.info + Environment.NewLine);
            }
        }

        private void btnGetClanInfo_Click(object sender, EventArgs e)
        {
            string json = API.Get(EndPoints.Clan, tbClanTag.Text);
            Clan clan = API.Parse<Clan>(json);
            foreach (var clanMember in clan.members)
            {
                rtbClanInfoResponse.AppendText(clanMember.name + Environment.NewLine);
            }
        }

        private void btnGetTopPlayersInfo_Click(object sender, EventArgs e)
        {
            string json = API.Get(EndPoints.Top, "players");
            List<TopPlayer> topPlayers = API.Parse<List<TopPlayer>>(json);
            foreach (var player in topPlayers)
            {
                rtbTopPlayersResponse.AppendText(player.name + Environment.NewLine);
            }
        }

        private void btnGetTopClansInfo_Click(object sender, EventArgs e)
        {
            string json = API.Get(EndPoints.Top, "clans");
            List<TopClan> topClans = API.Parse<List<TopClan>>(json);
            foreach (var clan in topClans)
            {
                rtbTopClansInfoResponse.AppendText(clan.name + Environment.NewLine);
            }
        }
    }
}
