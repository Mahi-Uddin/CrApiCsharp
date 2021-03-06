﻿using System;
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
        /// Level of card
        /// </summary>
        public int level;
        /// <summary>
        /// Max Level of card
        /// </summary>
        public int maxLevel;
        /// <summary>
        /// Number of cards that the player has
        /// </summary>
        public int count;
        /// <summary>
        /// IconURLs of the card
        /// </summary>
        public IconURLs iconUrls;
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
        /// Rarity of the card
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
