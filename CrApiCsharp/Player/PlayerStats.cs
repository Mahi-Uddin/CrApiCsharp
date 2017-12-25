using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Player overall stats
    /// </summary>
    public class PlayerStats
    {
        /// <summary>
        /// Number of cards that player won in tournaments
        /// </summary>
        public int tournamentCardsWon;
        /// <summary>
        /// Best player's trophies
        /// </summary>
        public int maxTrophies;
        /// <summary>
        /// Number of three crown wins
        /// </summary>
        public int threeCrownWins;
        /// <summary>
        /// Number of all cards that player can use
        /// </summary>
        public int cardsFound;
        /// <summary>
        /// The player's favorite card
        /// </summary>
        public FavouriteCard favoriteCard;
        /// <summary>
        /// Player's total donations
        /// </summary>
        public int totalDonations;
        /// <summary>
        /// Maximum wins in challenge
        /// </summary>
        public int challengeMaxWins;
        /// <summary>
        /// Number of cards that player won in challenges
        /// </summary>
        public int challengeCardsWon;
        /// <summary>
        /// Player's current level
        /// </summary>
        public int level;
    }
}
