using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Player's experience data
    /// </summary>
    public class PlayerExperience
    {
        /// <summary>
        /// Player's level
        /// </summary>
        public int level;
        /// <summary>
        /// Player's XP count
        /// </summary>
        public int xp;
        /// <summary>
        /// Player's XP that he needs to level up ("Max" if player level is max)
        /// </summary>
        public string xpRequiredForLevelUp;
        /// <summary>
        /// How much XP is needed to level up
        /// </summary>
        public int xpToLevelUp;
    }
}
