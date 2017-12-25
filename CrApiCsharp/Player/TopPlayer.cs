using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Clash Royale Top Player class
    /// </summary>
    public class TopPlayer
    {
        /// <summary>
        /// Player's name
        /// </summary>
        public string name;
        /// <summary>
        /// Player's tag
        /// </summary>
        public string tag;
        /// <summary>
        /// Player's rank in the current leaderboard
        /// </summary>
        public int rank;
        /// <summary>
        /// Player's previous rank in the current leaderboard
        /// </summary>
        public int previousRank;
        /// <summary>
        /// Player's XP level
        /// </summary>
        public int expLevel;
        /// <summary>
        /// Player's trophies
        /// </summary>
        public int trophies;
        /// <summary>
        /// Player's clan summary
        /// </summary>
        public TopPlayerClan clan;
        /// <summary>
        /// Player's arena
        /// </summary>
        public Arena arena;
    }
}
