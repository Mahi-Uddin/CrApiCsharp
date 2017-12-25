using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    public class FavouriteCard
    {
        ///<summary>
        /// Favourite card name
        ///</summary>
        public string name;
        ///<summary>
        /// MaxLevel of the card
        ///</summary>
        public int maxLevel;
        ///<summary>
        /// Icon URLs of the card
        ///</summary>
        public IconURLs iconUrls;
        ///<summary>
        /// Key of the card
        ///</summary>
        public string key;
        ///<summary>
        /// Elixir cost of the card
        ///</summary>
        public int elixir;
        /// <summary>
        /// Type of the card (like "Troop","Building" etc.)
        /// </summary>
        public string type;
        /// <summary>
        /// Rarity of the card (like "Troop","Building" etc.)
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
