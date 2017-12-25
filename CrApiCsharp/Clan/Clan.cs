using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Clash Royale Clan class
    /// </summary>
    public class Clan
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
        /// Clan description
        /// </summary>
        public string description;
        /// <summary>
        /// Clan joinable type
        /// </summary>
        public int type;
        /// <summary>
        /// Clan score
        /// </summary>
        public int score;
        /// <summary>
        /// Number of members
        /// </summary>
        public int memberCount;
        /// <summary>
        /// Required trophies to join
        /// </summary>
        public int requiredScore;
        /// <summary>
        /// Donations in clan
        /// </summary>
        public int donations;
        /// <summary>
        /// Clan's last clanchest info
        /// </summary>
        public ClanChest clanChest;
        /// <summary>
        /// Badge ID
        /// </summary>
        public int badge;
        /// <summary>
        /// Clan region (country)
        /// </summary>
        public ClanRegion region;

        /// <summary>
        /// Clan's members (short summary of each player)
        /// </summary>
        public ClanPlayer[] members;

        /// <summary>
        /// Get string representation of this clan, returns clan name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
    }
}
