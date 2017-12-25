using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    public class Battle
    {
        /// <summary>
        /// Battle type
        /// </summary>
        public string type;
        /// <summary>
        /// Battle mode
        /// </summary>
        public BattleMode mode;
        /// <summary>
        /// UTC time of the battle
        /// </summary>
        public int utcTime;
        /// <summary>
        /// Deck type used in the battle
        /// </summary>
        public string deckType;
        /// <summary>
        /// Team size of the battle
        /// </summary>
        public int teamSize;
        /// <summary>
        /// Winner of the battle
        /// </summary>
        public int winner;
        /// <summary>
        /// Crowns of the team
        /// </summary>
        public int teamCrowns;
        /// <summary>
        /// Crowns of the opponent
        /// </summary>
        public int opponentCrowns;
        /// <summary>
        /// Teams of the battle
        /// </summary>
        public Team[] team;
        /// <summary>
        /// Opponents of the battle
        /// </summary>
        public Opponent[] opponent;
        /// <summary>
        /// Arena of the battle
        /// </summary>
        public Arena arena;
    }
}
