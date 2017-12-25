using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Clash Royale Card
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Name of card
        /// </summary>
        public string name;
        /// <summary>
        /// Rarity of caard
        /// </summary>
        public string rarity;
        /// <summary>
        /// Level of card
        /// </summary>
        public int level;
        /// <summary>
        /// Number of cards that the player has
        /// </summary>
        public int count;
        /// <summary>
        /// Number of cards that player needs to upgrade this card ("Maxed" if the card is on the maximum level)
        /// </summary>
        public string requiredForUpgrade;
        /// <summary>
        /// Card ID
        /// </summary>
        public int card_id;
        /// <summary>
        /// Card key (name of card)
        /// </summary>
        public string key;
        /// <summary>
        /// Card key (name of card)
        /// </summary>
        public string card_key;
        /// <summary>
        /// Card elixir cost
        /// </summary>
        public int elixir;
        /// <summary>
        /// Card type (like "Troop","Building" etc.)
        /// </summary>
        public string type;
        /// <summary>
        /// The arena in which the card is unlocked
        /// </summary>
        public int arena;
        /// <summary>
        /// Card description
        /// </summary>
        public string description;
        /// <summary>
        /// Some sort of deck link
        /// </summary>
        public string decklink;
        /// <summary>
        /// Cards ammount left to upgrade
        /// </summary>
        public int? leftToUpgrade;

        /// <summary>
        /// Returns the card's name
        /// </summary>
        /// <returns>Returns the card's name</returns>
        public override string ToString()
        {
            return name;
        }
    }
}
