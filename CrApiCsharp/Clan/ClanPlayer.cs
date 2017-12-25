using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Short summary of the player (from clan view)
    /// </summary>
    public class ClanPlayer
    {
        /// <summary>
        /// Name of the player
        /// </summary>
        public string name;
        /// <summary>
        /// TAG of the player
        /// </summary>
        public string tag;
        /// <summary>
        /// Role of the player
        /// </summary>
        public int rank;
        /// <summary>
        /// Role of the player
        /// </summary>
        public string role;
        /// <summary>
        /// Level of the player
        /// </summary>
        public int expLevel;
        /// <summary>
        /// Trophies of the player
        /// </summary>
        public int trophies;
        /// <summary>
        /// Number of crowns, player collected in the last clan chest
        /// </summary>
        public int clanChestCrowns;
        /// <summary>
        /// Percentage of number of crowns, player collected last clan chest
        /// </summary>
        public float clanChestCrownsPercent;
        /// <summary>
        /// Donations donated by the player
        /// </summary>
        public int donations;
        /// <summary>
        /// Donations received from the clan
        /// </summary>
        public int donationsReceived;
        /// <summary>
        /// Donations delta
        /// </summary>
        public int donationsDelta;
        /// <summary>
        /// Arena of the player
        /// </summary>
        public Arena arena;
        /// <summary>
        /// Previous rank in clan
        /// </summary>
        public int previousRank;

        /// <summary>
        /// Returns Player's name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
    }
}
