using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Class that contains the best players in Clash Royale
    /// </summary>
    public class TopPlayers
    {
        /// <summary>
        /// The milliseconds format DateTime when was this list last updated
        /// </summary>
        public ulong lastUpdated;
        /// <summary>
        /// Top players
        /// </summary>
        public Player[] clans;
    }
}
