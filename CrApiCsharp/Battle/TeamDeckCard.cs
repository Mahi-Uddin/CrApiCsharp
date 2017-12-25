namespace CrApiCsharp
{
    /// <summary>
    /// Team Deck Card
    /// </summary>
    public class TeamDeckCard
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
    }
}
