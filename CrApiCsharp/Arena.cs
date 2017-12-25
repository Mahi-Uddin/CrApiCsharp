using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Clash Royale Arena class
    /// </summary>
    public class Arena
    {
        /// <summary>
        /// Arena name (like "Legendary Arena")
        /// </summary>
        public string name;
        /// <summary>
        /// Arena number (like "Arena 12")
        /// </summary>
        public string arena;
        /// <summary>
        /// Arena ID
        /// </summary>
        public int arenaID;
        /// <summary>
        /// Arena minimum trophy limit
        /// </summary>
        public int trophyLimit;

        /// <summary>
        /// Returns the arena name
        /// </summary>
        /// <returns>Returns the arena name</returns>
        public override string ToString()
        {
            return name;
        }
    }
}
