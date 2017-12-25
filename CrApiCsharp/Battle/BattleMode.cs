using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    public class BattleMode
    {
        /// <summary>
        /// Name of the battle mode
        /// </summary>
        public string name;
        /// <summary>
        /// Deck type used in the current battle mode
        /// </summary>
        public string deck;
        /// <summary>
        /// Card levels in the battle
        /// </summary>
        public string cardLevels;
        /// <summary>
        /// Overtime Seconds of the battle mode
        /// </summary>
        public int overtimeSeconds;
        /// <summary>
        /// Both players
        /// </summary>
        public string players;
        /// <summary>
        /// Both player is using same deck or not
        /// </summary>
        public bool sameDeck;
    }
}
