using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp_Example_Usage
{

    public class Rootobject
    {
        public Battle[] battles { get; set; }
    }

    public class Battle
    {
        public string type { get; set; }
        public Mode mode { get; set; }
        public int utcTime { get; set; }
        public string deckType { get; set; }
        public int teamSize { get; set; }
        public int winner { get; set; }
        public int teamCrowns { get; set; }
        public int opponentCrowns { get; set; }
        public Team[] team { get; set; }
        public Opponent[] opponent { get; set; }
        public Arena arena { get; set; }
    }

    public class Mode
    {
        public string name { get; set; }
        public string deck { get; set; }
        public string cardLevels { get; set; }
        public int overtimeSeconds { get; set; }
        public string players { get; set; }
        public bool sameDeck { get; set; }
    }

    public class Arena
    {
        public string name { get; set; }
        public string arena { get; set; }
        public int arenaID { get; set; }
        public int trophyLimit { get; set; }
    }

    public class Team
    {
        public string tag { get; set; }
        public string name { get; set; }
        public int crownsEarned { get; set; }
        public int startTrophies { get; set; }
        public Clan clan { get; set; }
        public Deck[] deck { get; set; }
    }

    public class Clan
    {
        public string tag { get; set; }
        public string name { get; set; }
        public Badge badge { get; set; }
    }

    public class Badge
    {
        public string name { get; set; }
        public string category { get; set; }
        public int id { get; set; }
        public string image { get; set; }
    }

    public class Deck
    {
        public string name { get; set; }
        public int level { get; set; }
        public int maxLevel { get; set; }
        public Iconurls iconUrls { get; set; }
        public string key { get; set; }
        public int elixir { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int arena { get; set; }
        public string description { get; set; }
    }

    public class Iconurls
    {
        public string medium { get; set; }
    }

    public class Opponent
    {
        public string tag { get; set; }
        public string name { get; set; }
        public int crownsEarned { get; set; }
        public int startTrophies { get; set; }
        public Clan1 clan { get; set; }
        public Deck1[] deck { get; set; }
    }

    public class Clan1
    {
        public string tag { get; set; }
        public string name { get; set; }
        public Badge1 badge { get; set; }
    }

    public class Badge1
    {
        public string name { get; set; }
        public string category { get; set; }
        public int id { get; set; }
        public string image { get; set; }
    }

    public class Deck1
    {
        public string name { get; set; }
        public int level { get; set; }
        public int maxLevel { get; set; }
        public Iconurls1 iconUrls { get; set; }
        public string key { get; set; }
        public int elixir { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int arena { get; set; }
        public string description { get; set; }
    }

    public class Iconurls1
    {
        public string medium { get; set; }
    }
}
