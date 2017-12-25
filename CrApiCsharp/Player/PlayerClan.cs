using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Player's Clan description(short/minified) from player's profile view
    /// </summary>
    public class PlayerClan
    {
        /// <summary>
        /// Clan Tag
        /// </summary>
        public string tag;
        /// <summary>
        /// Clan Name
        /// </summary>
        public string name;
        /// <summary>
        /// Role in clan
        /// </summary>
        public string role;
        /// <summary>
        /// Donations to clan
        /// </summary>
        public int donations;
        /// <summary>
        /// Donations received from clan
        /// </summary>
        public int donationsReceived;
        /// <summary>
        /// Clan badge
        /// </summary>
        public ClanBadge badge;

        /// <summary>
        /// Returns clan name
        /// </summary>
        /// <returns>Returns clan name</returns>
        public override string ToString()
        {
            return name;
        }
    }
}
