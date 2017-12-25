using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    public class TopClan
    {
        /// <summary>
        /// Tag of the clan
        /// </summary>
        public string tag;
        /// <summary>
        /// Name of the clan
        /// </summary>
        public string name;
        /// <summary>
        /// Clan score
        /// </summary>
        public int score;
        /// <summary>
        /// Number of members
        /// </summary>
        public int memberCount;
        /// <summary>
        /// Rank in the current leaderboard
        /// </summary>
        public int rank;
        /// <summary>
        /// Previous Rank in the current leaderboard
        /// </summary>
        public int previousRank;
        /// <summary>
        /// Badge ID
        /// </summary>
        public int badge;
        /// <summary>
        /// Clan region (country)
        /// </summary>
        public ClanRegion region;
    }
}
