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
            string json = API.Get(EndPoints.Player, tbTag.Text);
            rtbPlayerInfo.Text = json;
        }
    }
}
