using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    /// <summary>
    /// Card of Current Deck
    /// </summary>
    public class CurrentDeckCard
    {
        /// <summary>
        /// Name of the card
        /// </summary>
        public string name;
        /// <summary>
        /// Level of the card
        /// </summary>
        public int level;
        /// <summary>
        /// Max Level of the card
        /// </summary>
        public int maxLevel;
        /// <summary>
        /// Count of the card
        /// </summary>
        public int count;
        /// <summary>
        /// IconURLs of the card
        /// </summary>
        public int iconUrls;
        /// <summary>
        /// Card key
        /// </summary>
        public string key;
        /// <summary>
        /// Card elixir cost
        /// </summary>
        public int elixir;
        /// <summary>
        /// Card type (like "Troop","Building" etc.)
        /// </summary>
        public string type;
        /// <summary>
        /// Card rarity
        /// </summary>
        public string rarity;
        /// <summary>
        /// The arena in which the card is unlocked
        /// </summary>
        public int arena;
        /// <summary>
        /// Card description
        /// </summary>
        public string description;
    }
}
