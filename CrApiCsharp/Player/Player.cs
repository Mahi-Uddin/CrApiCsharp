using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Clash Royale Player class
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Player's tag
        /// </summary>
        public string tag;
        /// <summary>
        /// Player's name
        /// </summary>
        public string name;
        /// <summary>
        /// Player's current trophies
        /// </summary>
        public int trophies;
        /// <summary>
        /// Player's arena
        /// </summary>
        public Arena arena;
        /// <summary>
        /// Player's clan summary
        /// </summary>
        public PlayerClan clan;
        /// <summary>
        /// Player's stats
        /// </summary>
        public PlayerStats stats;
        /// <summary>
        /// Player's game stats
        /// </summary>
        public PlayerGames games;
        /// <summary>
        /// Player's chest cycle data
        /// </summary>
        public PlayerChestCycle chestCycle;
        /// <summary>
        /// Player's league statistics
        /// </summary>
        public LeagueStats[] LeagueStats;
        /// <summary>
        /// Current decks of the player
        /// </summary>
        public Card[] currentDeck;
        /// <summary>
        /// Unlocked cards of the player
        /// </summary>
        public Card[] cards;
        /// <summary>
        /// Achievements of the player
        /// </summary>
        public Achievement[] achievements;
        /// <summary>
        /// Player's battles
        /// </summary>
        public Battle[] battles;

        /// <summary>
        /// Return string representation of the player, returns player's name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
    }
}
