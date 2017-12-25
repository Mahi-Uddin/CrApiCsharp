namespace CrApiCsharp
{
    /// <summary>
    /// Battle opponent
    /// </summary>
    public class Opponent
    {
        /// <summary>
        /// Tag of the team
        /// </summary>
        public string tag;
        /// <summary>
        /// Name of the team
        /// </summary>
        public string name;
        /// <summary>
        /// Number of crowns earned by the team
        /// </summary>
        public int crownsEarned;
        /// <summary>
        /// Trophies count when the battle was started
        /// </summary>
        public int startTrophies;
        /// <summary>
        /// Clan of the team
        /// </summary>
        public OpponentClan clan;
        /// <summary>
        /// Deck(s) of the team
        /// </summary>
        public OpponentDeckCard[] deck;
    }
}
